namespace employeeManagementSystem
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            EmpPosTb = new TextBox();
            EmpNameTb = new TextBox();
            EmpIdTb = new TextBox();
            WorkedTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            SalarySlip = new RichTextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 71);
            label1.Name = "label1";
            label1.Size = new Size(297, 33);
            label1.TabIndex = 29;
            label1.Text = "EMPLOYEE DETAILS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(101, 170);
            label5.Name = "label5";
            label5.Size = new Size(212, 27);
            label5.TabIndex = 6;
            label5.Text = "EMPLOYEE NAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(101, 391);
            label6.Name = "label6";
            label6.Size = new Size(185, 27);
            label6.TabIndex = 7;
            label6.Text = "WORKED DAYS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(101, 284);
            label8.Name = "label8";
            label8.Size = new Size(252, 27);
            label8.TabIndex = 9;
            label8.Text = "EMPLOYEE POSITION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(101, 50);
            label9.Name = "label9";
            label9.Size = new Size(172, 27);
            label9.TabIndex = 10;
            label9.Text = " EMPLOYEE ID";
            // 
            // EmpPosTb
            // 
            EmpPosTb.Enabled = false;
            EmpPosTb.Location = new Point(101, 326);
            EmpPosTb.Name = "EmpPosTb";
            EmpPosTb.Size = new Size(193, 27);
            EmpPosTb.TabIndex = 11;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Enabled = false;
            EmpNameTb.Location = new Point(101, 212);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(200, 27);
            EmpNameTb.TabIndex = 12;
            // 
            // EmpIdTb
            // 
            EmpIdTb.Location = new Point(101, 92);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(193, 27);
            EmpIdTb.TabIndex = 13;
            // 
            // WorkedTb
            // 
            WorkedTb.Location = new Point(101, 434);
            WorkedTb.Name = "WorkedTb";
            WorkedTb.Size = new Size(193, 27);
            WorkedTb.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(924, 553);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 19;
            button1.Text = "PRINT";
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
            button2.Location = new Point(373, 82);
            button2.Name = "button2";
            button2.Size = new Size(128, 37);
            button2.TabIndex = 20;
            button2.Text = "FETCH DATA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(97, 513);
            button3.Name = "button3";
            button3.Size = new Size(81, 37);
            button3.TabIndex = 21;
            button3.Text = "VIEW";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(232, 513);
            button4.Name = "button4";
            button4.Size = new Size(81, 37);
            button4.TabIndex = 22;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SalarySlip);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(WorkedTb);
            panel1.Controls.Add(EmpIdTb);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(EmpPosTb);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(2, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(1402, 633);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // SalarySlip
            // 
            SalarySlip.BorderStyle = BorderStyle.None;
            SalarySlip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SalarySlip.ForeColor = Color.Navy;
            SalarySlip.Location = new Point(583, 30);
            SalarySlip.Name = "SalarySlip";
            SalarySlip.Size = new Size(760, 500);
            SalarySlip.TabIndex = 23;
            SalarySlip.Text = "";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1404, 801);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            Load += Salary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox EmpPosTb;
        private TextBox EmpNameTb;
        private TextBox EmpIdTb;
        private TextBox WorkedTb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private RichTextBox SalarySlip;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}