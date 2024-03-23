using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using System.ComponentModel;
namespace first_laba
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap source, int x, int y);
        public Bitmap proccessImage(Bitmap source,BackgroundWorker worker)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int i = 0; i < source.Width; i++)
            {
                worker.ReportProgress((int)(((float)i / source.Width) *100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j<source.Height; j++)
                {
                    result.SetPixel(i, j, calculateNewPixelColor(source,i, j));

                }
            }

            return result;
        }
        public int clamp(int value, int max=255,int min=0)
        {
            if (value<min)
                return min;
            if (value>max)
                return max;
            return value;
        }
    }

    class InvertFilter: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color source_color=source.GetPixel(x, y);
            Color result_color = Color.FromArgb(255-source_color.R,
                                                255-source_color.G,
                                                    255-source_color.B);
            return result_color;
        }
    }

    class Gray_filter: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap source, int x, int y)
        {
            Color source_color = source.GetPixel(x, y);
            double intensity = 0.299 * source_color.R/255 +0.587*source_color.G/255 +0.114*source_color.B/255;
            Color result_color = Color.FromArgb((int)(intensity*255), (int)(intensity*255), (int)(intensity*255));
            return result_color;
        }
    }

    class Septuum: Filters
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
}
