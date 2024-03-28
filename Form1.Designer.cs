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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.septuumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseTheBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionblurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grayWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(208, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1131, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отрытьToolStripMenuItem
            // 
            this.отрытьToolStripMenuItem.Name = "отрытьToolStripMenuItem";
            this.отрытьToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.отрытьToolStripMenuItem.Text = "Отрыть";
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayColorsToolStripMenuItem,
            this.septuumToolStripMenuItem,
            this.increaseTheBrightnessToolStripMenuItem,
            this.shiftrToolStripMenuItem,
            this.grayWorldToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            // 
            // grayColorsToolStripMenuItem
            // 
            this.grayColorsToolStripMenuItem.Name = "grayColorsToolStripMenuItem";
            this.grayColorsToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.grayColorsToolStripMenuItem.Text = "gray colors";
            // 
            // septuumToolStripMenuItem
            // 
            this.septuumToolStripMenuItem.Name = "septuumToolStripMenuItem";
            this.septuumToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.septuumToolStripMenuItem.Text = "Septuum";
            // 
            // increaseTheBrightnessToolStripMenuItem
            // 
            this.increaseTheBrightnessToolStripMenuItem.Name = "increaseTheBrightnessToolStripMenuItem";
            this.increaseTheBrightnessToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.increaseTheBrightnessToolStripMenuItem.Text = "increase the brightness";
            // 
            // shiftrToolStripMenuItem
            // 
            this.shiftrToolStripMenuItem.Name = "shiftrToolStripMenuItem";
            this.shiftrToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.shiftrToolStripMenuItem.Text = "shift_r";
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvreToolStripMenuItem,
            this.motionblurToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // ouvreToolStripMenuItem
            // 
            this.ouvreToolStripMenuItem.Name = "ouvreToolStripMenuItem";
            this.ouvreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ouvreToolStripMenuItem.Text = "ouvre";
            // 
            // motionblurToolStripMenuItem
            // 
            this.motionblurToolStripMenuItem.Name = "motionblurToolStripMenuItem";
            this.motionblurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.motionblurToolStripMenuItem.Text = "motionblur";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(107, 868);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(839, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(1001, 868);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(91, 29);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // grayWorldToolStripMenuItem
            // 
            this.grayWorldToolStripMenuItem.Name = "grayWorldToolStripMenuItem";
            this.grayWorldToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.grayWorldToolStripMenuItem.Text = "gray world";
            this.grayWorldToolStripMenuItem.Click += new System.EventHandler(this.grayWorldToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 1055);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
		private ToolStripMenuItem grayWorldToolStripMenuItem;
	}
}