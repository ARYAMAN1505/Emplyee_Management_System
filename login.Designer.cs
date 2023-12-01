namespace employeeManagementSystem
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UidTb = new TextBox();
            PassTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 1;
            label1.Text = "USER LOGIN";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 137);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UidTb
            // 
            UidTb.Location = new Point(297, 63);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(125, 27);
            UidTb.TabIndex = 3;
            UidTb.TextChanged += textBox1_TextChanged;
            // 
            // PassTb
            // 
            PassTb.Location = new Point(297, 118);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(125, 27);
            PassTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(182, 63);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 5;
            label2.Text = "User Id";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(182, 118);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(242, 165);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(342, 165);
            button2.Name = "button2";
            button2.Size = new Size(80, 37);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(454, 214);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PassTb);
            Controls.Add(UidTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UidTb;
        private TextBox PassTb;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}