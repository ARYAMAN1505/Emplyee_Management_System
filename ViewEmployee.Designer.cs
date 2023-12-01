namespace employeeManagementSystem
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            empnamelbl = new Label();
            empgenlbl = new Label();
            empedulbl = new Label();
            empdoblbl = new Label();
            Empidlbl = new Label();
            empaddlbl = new Label();
            empposlbl = new Label();
            empphonelbl = new Label();
            EmpidTb = new TextBox();
            label11 = new Label();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 66);
            label1.Name = "label1";
            label1.Size = new Size(297, 33);
            label1.TabIndex = 27;
            label1.Text = "EMPLOYEE DETAILS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(empnamelbl);
            panel1.Controls.Add(empgenlbl);
            panel1.Controls.Add(empedulbl);
            panel1.Controls.Add(empdoblbl);
            panel1.Controls.Add(Empidlbl);
            panel1.Controls.Add(empaddlbl);
            panel1.Controls.Add(empposlbl);
            panel1.Controls.Add(empphonelbl);
            panel1.Controls.Add(EmpidTb);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(1403, 594);
            panel1.TabIndex = 30;
            // 
            // empnamelbl
            // 
            empnamelbl.AutoSize = true;
            empnamelbl.BackColor = Color.White;
            empnamelbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empnamelbl.ForeColor = Color.Navy;
            empnamelbl.Location = new Point(1096, 146);
            empnamelbl.Name = "empnamelbl";
            empnamelbl.Size = new Size(212, 27);
            empnamelbl.TabIndex = 32;
            empnamelbl.Text = "EMPLOYEE NAME";
            empnamelbl.Visible = false;
            // 
            // empgenlbl
            // 
            empgenlbl.AutoSize = true;
            empgenlbl.BackColor = Color.White;
            empgenlbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empgenlbl.ForeColor = Color.Navy;
            empgenlbl.Location = new Point(1096, 237);
            empgenlbl.Name = "empgenlbl";
            empgenlbl.Size = new Size(111, 27);
            empgenlbl.TabIndex = 31;
            empgenlbl.Text = "GENDER";
            empgenlbl.Visible = false;
            // 
            // empedulbl
            // 
            empedulbl.AutoSize = true;
            empedulbl.BackColor = Color.White;
            empedulbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empedulbl.ForeColor = Color.Navy;
            empedulbl.Location = new Point(1096, 415);
            empedulbl.Name = "empedulbl";
            empedulbl.Size = new Size(148, 27);
            empedulbl.TabIndex = 30;
            empedulbl.Text = "EDUCATION";
            empedulbl.Visible = false;
            // 
            // empdoblbl
            // 
            empdoblbl.AutoSize = true;
            empdoblbl.BackColor = Color.White;
            empdoblbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empdoblbl.ForeColor = Color.Navy;
            empdoblbl.Location = new Point(1096, 325);
            empdoblbl.Name = "empdoblbl";
            empdoblbl.Size = new Size(189, 27);
            empdoblbl.TabIndex = 29;
            empdoblbl.Text = "DATE OF BIRTH";
            empdoblbl.Visible = false;
            // 
            // Empidlbl
            // 
            Empidlbl.AutoSize = true;
            Empidlbl.BackColor = Color.White;
            Empidlbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Empidlbl.ForeColor = Color.Navy;
            Empidlbl.Location = new Point(393, 146);
            Empidlbl.Name = "Empidlbl";
            Empidlbl.Size = new Size(172, 27);
            Empidlbl.TabIndex = 28;
            Empidlbl.Text = " EMPLOYEE ID";
            Empidlbl.Visible = false;
            // 
            // empaddlbl
            // 
            empaddlbl.AutoSize = true;
            empaddlbl.BackColor = Color.White;
            empaddlbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empaddlbl.ForeColor = Color.Navy;
            empaddlbl.Location = new Point(403, 237);
            empaddlbl.Name = "empaddlbl";
            empaddlbl.Size = new Size(125, 27);
            empaddlbl.TabIndex = 27;
            empaddlbl.Text = "ADDRESS";
            empaddlbl.Visible = false;
            // 
            // empposlbl
            // 
            empposlbl.AutoSize = true;
            empposlbl.BackColor = Color.White;
            empposlbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empposlbl.ForeColor = Color.Navy;
            empposlbl.Location = new Point(403, 325);
            empposlbl.Name = "empposlbl";
            empposlbl.Size = new Size(120, 27);
            empposlbl.TabIndex = 26;
            empposlbl.Text = "POSITION";
            empposlbl.Visible = false;
            // 
            // empphonelbl
            // 
            empphonelbl.AutoSize = true;
            empphonelbl.BackColor = Color.White;
            empphonelbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empphonelbl.ForeColor = Color.Navy;
            empphonelbl.Location = new Point(403, 415);
            empphonelbl.Name = "empphonelbl";
            empphonelbl.Size = new Size(202, 27);
            empphonelbl.TabIndex = 25;
            empphonelbl.Text = "PHONE NUMBER";
            empphonelbl.Visible = false;
            // 
            // EmpidTb
            // 
            EmpidTb.Location = new Point(615, 28);
            EmpidTb.Name = "EmpidTb";
            EmpidTb.Size = new Size(193, 27);
            EmpidTb.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.OrangeRed;
            label11.Location = new Point(416, 25);
            label11.Name = "label11";
            label11.Size = new Size(172, 27);
            label11.TabIndex = 23;
            label11.Text = " EMPLOYEE ID";
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(783, 527);
            button4.Name = "button4";
            button4.Size = new Size(81, 37);
            button4.TabIndex = 22;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(863, 17);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 21;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(524, 527);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 19;
            button1.Text = "PRINT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(125, 146);
            label9.Name = "label9";
            label9.Size = new Size(172, 27);
            label9.TabIndex = 10;
            label9.Text = " EMPLOYEE ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(135, 237);
            label8.Name = "label8";
            label8.Size = new Size(125, 27);
            label8.TabIndex = 9;
            label8.Text = "ADDRESS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(135, 325);
            label7.Name = "label7";
            label7.Size = new Size(120, 27);
            label7.TabIndex = 8;
            label7.Text = "POSITION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(135, 415);
            label6.Name = "label6";
            label6.Size = new Size(202, 27);
            label6.TabIndex = 7;
            label6.Text = "PHONE NUMBER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(819, 146);
            label5.Name = "label5";
            label5.Size = new Size(212, 27);
            label5.TabIndex = 6;
            label5.Text = "EMPLOYEE NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(819, 237);
            label4.Name = "label4";
            label4.Size = new Size(111, 27);
            label4.TabIndex = 5;
            label4.Text = "GENDER";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(819, 415);
            label3.Name = "label3";
            label3.Size = new Size(148, 27);
            label3.TabIndex = 4;
            label3.Text = "EDUCATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(819, 325);
            label2.Name = "label2";
            label2.Size = new Size(189, 27);
            label2.TabIndex = 3;
            label2.Text = "DATE OF BIRTH";
            label2.Click += label2_Click;
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
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1404, 801);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEmployee";
            Load += ViewEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox EmpidTb;
        private Label label11;
        private Label empnamelbl;
        private Label empgenlbl;
        private Label empedulbl;
        private Label empdoblbl;
        private Label Empidlbl;
        private Label empaddlbl;
        private Label empposlbl;
        private Label empphonelbl;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}