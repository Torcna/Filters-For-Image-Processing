using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace first_laba
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap source, int x, int y);
        public virtual Bitmap proccessImage(Bitmap source, BackgroundWorker worker)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int i = 0; i < source.Width; i++)
            {
                worker.ReportProgress((int)(((float)i / source.Width) *100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j<source.Height; j++)
                {
                    result.SetPixel(i, j, calculateNewPixelColor(source, i, j));

                }
            }

            return result;
        }
        public int clamp(int value, int max = 255, int min = 0)
        {
            if (value<min)
                return min;
            if (value>max)
                return max;
            return value;
        }
    }

    class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color source_color = source.GetPixel(x, y);
            Color result_color = Color.FromArgb(255-source_color.R,
                                                255-source_color.G,
                                                    255-source_color.B);
            return result_color;
        }
    }

    class Gray_filter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color source_color = source.GetPixel(x, y);
            double intensity = 0.299 * source_color.R/255 +0.587*source_color.G/255 +0.114*source_color.B/255;
            Color result_color = Color.FromArgb((int)(intensity*255), (int)(intensity*255), (int)(intensity*255));
            return result_color;
        }
    }

    class Septuum : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color source_color = source.GetPixel(x, y);
            int k = 20;
            double intensity = 0.299 * source_color.R/255 +0.587*source_color.G/255 +0.114*source_color.B/255;
            Color result_color = Color.FromArgb(clamp((int)(intensity*255) +2*k),
                                                    clamp((int)(intensity*255)+ k/2),
                                                        clamp((int)(intensity*255) -k));
            return result_color;
        }
    }

    class Spot_light : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color source_color = source.GetPixel(x, y);
            int k = 20;
            source_color = Color.FromArgb(clamp(source_color.R + k), clamp(source_color.G + k), clamp(source_color.B + k));
            return source_color;
        }
    }

    class shift_r : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override Bitmap proccessImage(Bitmap source, BackgroundWorker worker)
        {
            Bitmap result = new Bitmap(source.Width+50, source.Height);
            int t = result.Height;
            t = result.Width;
            for (int i = 0; i < source.Width; i++)
            {
                worker.ReportProgress((int)(((float)i / source.Width) * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < source.Height; j++)
                {
                    Color temp = source.GetPixel(i, j);

                    result.SetPixel(i+49, j, temp);

                }
            }
            return result;
        }
    }

    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            int Rad_x = kernel.GetLength(0) / 2;
            int Rad_y = kernel.GetLength(0) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -Rad_y; l <= Rad_y; l++)
            {
                for (int k = -Rad_x; k <= Rad_x; k++)
                {
                    int idX = clamp(x+k, source.Width-1, 0);
                    int idY = clamp(y+l, source.Height-1, 0);
                    Color neighbour = source.GetPixel(idX, idY);
                    resultR+= neighbour.R * kernel[Rad_x+k, Rad_y+l];
                    resultG+= neighbour.G * kernel[Rad_x+k, Rad_y+l];
                    resultB+= neighbour.B * kernel[Rad_x+k, Rad_y+l];
                }
            }
            return Color.FromArgb(clamp((int)resultR),
                                    clamp((int)resultG),
                                        clamp((int)resultB));
        }
    }

    class svertka : MatrixFilter
    {
        public svertka()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel=new float[sizeX, sizeY];
            for (int i = 0; i< sizeY; i++)
            {
                for (int j = 0; j<sizeX; j++)
                {
                    if ((i + j) % 2== 0)
                        kernel[i, j] = 0;
                    else
                    {
                        if (i==0 && j==1 || i==1 && j==2)
                            kernel[i, j] = 1;
                        else
                            kernel[i, j] = -1;
                    }
                }
            }

        }
    }
    class motionblur : MatrixFilter
    {
        public motionblur()
        {
            int sizeX = 9;
            int sizeY = 9;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i<sizeY; i++)
            {
                for (int j = 0; j<sizeX; j++)
                {

                    if (i == j)
                    {
                        float temp = 1.0f / (float)sizeX;
                        kernel[i, j] = temp;
                    }
                    else
                        kernel[i, j] = 0.0f;
                }
            }
        }
    }

    class gray_world : Filters
    {
        protected int R, G, B, aver;


        public override Bitmap proccessImage(Bitmap sourceImage, BackgroundWorker worker)

        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            R = 0; G = 0; B = 0; aver = 0;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / sourceImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color sourceColor = sourceImage.GetPixel(i, j);
                    R += sourceColor.R;
                    G += sourceColor.G;
                    B += sourceColor.B;
                }
            }
            R = R / (sourceImage.Width * sourceImage.Height);
            G = G / (sourceImage.Width * sourceImage.Height);
            B = B / (sourceImage.Width * sourceImage.Height);
            aver = (R + G + B) / 3;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / sourceImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
            }
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color c = source.GetPixel(x, y);
            Color resultColor = Color.FromArgb(clamp(c.R * aver / R), clamp(c.G * aver / G), clamp(c.B * aver / B));
            return resultColor;
        }
    }

    class autolevers : Filters
    {
        protected int R_min=256, G_min=256, B_min = 256;
        protected int R_max=0, G_max=0, B_max = 0;

        public override Bitmap proccessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i<sourceImage.Height; i++)
            {
                for (int j = 0; j<sourceImage.Width; j++)
                {
                    Color c = sourceImage.GetPixel(i, j);
                    if (c.R<R_min)
                        R_min=c.R;
                    if (c.R>R_max)
                        R_max=c.R;


                    if (c.G<G_min)
                        G_min=c.G;
                    if (c.G>G_max)
                        G_max=c.G;

                    if (c.B<B_min)
                        B_min=c.B;
                    if (c.B>B_max)
                        B_max=c.B;
                }
            }
            for (int i = 0; i<sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / sourceImage.Height * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j<sourceImage.Width; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }




        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color c = source.GetPixel(x, y);
            int newR = (int)((c.R - R_min) * 255.0 / (R_max - R_min));
            int newG = (int)((c.G - G_min) * 255.0 / (G_max - G_min));
            int newB = (int)((c.B - B_min) * 255.0 / (B_max - B_min));
            return Color.FromArgb(clamp(newR), clamp(newG), clamp(newB));
        }
    }

}
