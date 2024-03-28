using System.ComponentModel;

namespace first_laba
{
	public partial class Form1 : Form
	{
		Bitmap image;
		public Form1()
		{
			InitializeComponent();
		}

		//private void Form1_Load(object sender, EventArgs e)
		//{

		//}

		private void îòðûòüToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				image = new Bitmap(dialog.FileName);

			}
			pictureBox1.Image = image;
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.Refresh();
		}

		private void èíâåðñèÿToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InvertFilter filter = new InvertFilter();
			backgroundWorker1.RunWorkerAsync(filter);

		}

		private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Bitmap new_image = ((Filters)e.Argument).proccessImage(image, backgroundWorker1);
			if (backgroundWorker1.CancellationPending != true)
			{
				image = new_image;
			}
		}

		private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar1.Value = e.ProgressPercentage;
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (!e.Cancelled)
			{
				pictureBox1.Image = image;
				pictureBox1.Refresh();

			}
			progressBar1.Value = 0;
		}

		private void Cancel_button_Click(object sender, EventArgs e)
		{
			backgroundWorker1.CancelAsync();
		}

		private void grayColorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gray_filter filter = new Gray_filter();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void septuumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Septuum filter = new Septuum();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void increaseTheBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Spot_light filter = new Spot_light();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void shiftrToolStripMenuItem_Click(object sender, EventArgs e)
		{
			shift_r filter = new shift_r();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void ouvreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			svertka svertka = new svertka();
			backgroundWorker1.RunWorkerAsync(svertka);
			Spot_light spot_Light1 = new Spot_light();
			backgroundWorker1.RunWorkerAsync(spot_Light1);

			Spot_light spot_Light2 = new Spot_light();

			backgroundWorker1.RunWorkerAsync(spot_Light2);
			Spot_light spot_Light3 = new Spot_light();
			backgroundWorker1.RunWorkerAsync(spot_Light3);
			Spot_light spot_Light4 = new Spot_light();
			backgroundWorker1.RunWorkerAsync(spot_Light4);
			Spot_light spot_Light5 = new Spot_light();
			backgroundWorker1.RunWorkerAsync(spot_Light5);
			Gray_filter filter = new Gray_filter();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void motionblurToolStripMenuItem_Click(object sender, EventArgs e)
		{
            motionblur filter = new motionblur();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void grayWorldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gray_world g = new gray_world();
			backgroundWorker1.RunWorkerAsync(g);
		}
	}
}