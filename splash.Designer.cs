namespace employeeManagementSystem
{
    partial class splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            pictureBox1 = new PictureBox();
            Myprogress = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(128, 288);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(519, 20);
            Myprogress.TabIndex = 3;
            Myprogress.Click += progressBar1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(139, 21);
            label2.Name = "label2";
            label2.Size = new Size(517, 41);
            label2.TabIndex = 6;
            label2.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(308, 363);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 7;
            label1.Text = "BY ARYAMAN";
            // 
            // splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 418);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ProgressBar Myprogress;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label1;
    }
}