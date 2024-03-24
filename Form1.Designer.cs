namespace first_laba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			menuStrip1 = new MenuStrip();
			файлToolStripMenuItem = new ToolStripMenuItem();
			отрытьToolStripMenuItem = new ToolStripMenuItem();
			фильтрыToolStripMenuItem = new ToolStripMenuItem();
			точечныеToolStripMenuItem = new ToolStripMenuItem();
			инверсияToolStripMenuItem = new ToolStripMenuItem();
			grayColorsToolStripMenuItem = new ToolStripMenuItem();
			septuumToolStripMenuItem = new ToolStripMenuItem();
			increaseTheBrightnessToolStripMenuItem = new ToolStripMenuItem();
			shiftrToolStripMenuItem = new ToolStripMenuItem();
			матричныеToolStripMenuItem = new ToolStripMenuItem();
			ouvreToolStripMenuItem = new ToolStripMenuItem();
			progressBar1 = new ProgressBar();
			Cancel_button = new Button();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			motionblurToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(182, 84);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(554, 455);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтрыToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(5, 2, 0, 2);
			menuStrip1.Size = new Size(990, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отрытьToolStripMenuItem });
			файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			файлToolStripMenuItem.Size = new Size(48, 20);
			файлToolStripMenuItem.Text = "Файл";
			// 
			// отрытьToolStripMenuItem
			// 
			отрытьToolStripMenuItem.Name = "отрытьToolStripMenuItem";
			отрытьToolStripMenuItem.Size = new Size(115, 22);
			отрытьToolStripMenuItem.Text = "Отрыть";
			отрытьToolStripMenuItem.Click += отрытьToolStripMenuItem_Click;
			// 
			// фильтрыToolStripMenuItem
			// 
			фильтрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem });
			фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
			фильтрыToolStripMenuItem.Size = new Size(69, 20);
			фильтрыToolStripMenuItem.Text = "Фильтры";
			// 
			// точечныеToolStripMenuItem
			// 
			точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, grayColorsToolStripMenuItem, septuumToolStripMenuItem, increaseTheBrightnessToolStripMenuItem, shiftrToolStripMenuItem });
			точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
			точечныеToolStripMenuItem.Size = new Size(180, 22);
			точечныеToolStripMenuItem.Text = "Точечные";
			// 
			// инверсияToolStripMenuItem
			// 
			инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
			инверсияToolStripMenuItem.Size = new Size(195, 22);
			инверсияToolStripMenuItem.Text = "Инверсия";
			инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
			// 
			// grayColorsToolStripMenuItem
			// 
			grayColorsToolStripMenuItem.Name = "grayColorsToolStripMenuItem";
			grayColorsToolStripMenuItem.Size = new Size(195, 22);
			grayColorsToolStripMenuItem.Text = "gray colors";
			grayColorsToolStripMenuItem.Click += grayColorsToolStripMenuItem_Click;
			// 
			// septuumToolStripMenuItem
			// 
			septuumToolStripMenuItem.Name = "septuumToolStripMenuItem";
			septuumToolStripMenuItem.Size = new Size(195, 22);
			septuumToolStripMenuItem.Text = "Septuum";
			septuumToolStripMenuItem.Click += septuumToolStripMenuItem_Click;
			// 
			// increaseTheBrightnessToolStripMenuItem
			// 
			increaseTheBrightnessToolStripMenuItem.Name = "increaseTheBrightnessToolStripMenuItem";
			increaseTheBrightnessToolStripMenuItem.Size = new Size(195, 22);
			increaseTheBrightnessToolStripMenuItem.Text = "increase the brightness";
			increaseTheBrightnessToolStripMenuItem.Click += increaseTheBrightnessToolStripMenuItem_Click;
			// 
			// shiftrToolStripMenuItem
			// 
			shiftrToolStripMenuItem.Name = "shiftrToolStripMenuItem";
			shiftrToolStripMenuItem.Size = new Size(195, 22);
			shiftrToolStripMenuItem.Text = "shift_r";
			shiftrToolStripMenuItem.Click += shiftrToolStripMenuItem_Click;
			// 
			// матричныеToolStripMenuItem
			// 
			матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvreToolStripMenuItem, motionblurToolStripMenuItem });
			матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
			матричныеToolStripMenuItem.Size = new Size(180, 22);
			матричныеToolStripMenuItem.Text = "Матричные";
			// 
			// ouvreToolStripMenuItem
			// 
			ouvreToolStripMenuItem.Name = "ouvreToolStripMenuItem";
			ouvreToolStripMenuItem.Size = new Size(180, 22);
			ouvreToolStripMenuItem.Text = "ouvre";
			ouvreToolStripMenuItem.Click += ouvreToolStripMenuItem_Click;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(94, 651);
			progressBar1.Margin = new Padding(3, 2, 3, 2);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(734, 22);
			progressBar1.TabIndex = 2;
			progressBar1.Click += progressBar1_Click;
			// 
			// Cancel_button
			// 
			Cancel_button.Location = new Point(876, 651);
			Cancel_button.Margin = new Padding(3, 2, 3, 2);
			Cancel_button.Name = "Cancel_button";
			Cancel_button.Size = new Size(80, 22);
			Cancel_button.TabIndex = 3;
			Cancel_button.Text = "Cancel";
			Cancel_button.UseVisualStyleBackColor = true;
			Cancel_button.Click += Cancel_button_Click;
			// 
			// backgroundWorker1
			// 
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.DoWork += backgroundWorker1_DoWork;
			backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
			backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
			// 
			// motionblurToolStripMenuItem
			// 
			motionblurToolStripMenuItem.Name = "motionblurToolStripMenuItem";
			motionblurToolStripMenuItem.Size = new Size(180, 22);
			motionblurToolStripMenuItem.Text = "motionblur";
			motionblurToolStripMenuItem.Click += motionblurToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(990, 797);
			Controls.Add(Cancel_button);
			Controls.Add(progressBar1);
			Controls.Add(pictureBox1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem отрытьToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        
        private ProgressBar progressBar1;
        private Button Cancel_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem grayColorsToolStripMenuItem;
        private ToolStripMenuItem septuumToolStripMenuItem;
		private ToolStripMenuItem increaseTheBrightnessToolStripMenuItem;
		private ToolStripMenuItem shiftrToolStripMenuItem;
		private ToolStripMenuItem ouvreToolStripMenuItem;
		private ToolStripMenuItem motionblurToolStripMenuItem;
	}
}