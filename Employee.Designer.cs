namespace employeeManagementSystem
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            label1 = new Label();
            panel1 = new Panel();
            EmpDGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            EmpGenCb = new ComboBox();
            EmpEduCb = new ComboBox();
            EmpDob = new DateTimePicker();
            EmpPosCb = new ComboBox();
            EmpPhoneTb = new TextBox();
            EmpIdTb = new TextBox();
            EmpNameTb = new TextBox();
            EmpAddTb = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 63);
            label1.Name = "label1";
            label1.Size = new Size(303, 33);
            label1.TabIndex = 2;
            label1.Text = "MANAGE EMPLOYEE";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(EmpGenCb);
            panel1.Controls.Add(EmpEduCb);
            panel1.Controls.Add(EmpDob);
            panel1.Controls.Add(EmpPosCb);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(EmpIdTb);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(1390, 594);
            panel1.TabIndex = 3;
            // 
            // EmpDGV
            // 
            EmpDGV.BackgroundColor = Color.White;
            EmpDGV.BorderStyle = BorderStyle.None;
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpDGV.Location = new Point(634, 33);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersWidth = 51;
            EmpDGV.RowTemplate.Height = 29;
            EmpDGV.Size = new Size(753, 535);
            EmpDGV.TabIndex = 23;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(483, 485);
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
            button3.Location = new Point(252, 485);
            button3.Name = "button3";
            button3.Size = new Size(81, 37);
            button3.TabIndex = 21;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(366, 485);
            button2.Name = "button2";
            button2.Size = new Size(81, 37);
            button2.TabIndex = 20;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(135, 485);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 19;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmpGenCb
            // 
            EmpGenCb.FormattingEnabled = true;
            EmpGenCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            EmpGenCb.Location = new Point(416, 219);
            EmpGenCb.Name = "EmpGenCb";
            EmpGenCb.Size = new Size(200, 28);
            EmpGenCb.TabIndex = 18;
            // 
            // EmpEduCb
            // 
            EmpEduCb.FormattingEnabled = true;
            EmpEduCb.Items.AddRange(new object[] { "B TECH", "M TECH", "BBA", "MBA", "B COM", "M COM" });
            EmpEduCb.Location = new Point(416, 420);
            EmpEduCb.Name = "EmpEduCb";
            EmpEduCb.Size = new Size(200, 28);
            EmpEduCb.TabIndex = 17;
            // 
            // EmpDob
            // 
            EmpDob.Location = new Point(416, 319);
            EmpDob.Name = "EmpDob";
            EmpDob.Size = new Size(200, 27);
            EmpDob.TabIndex = 16;
            // 
            // EmpPosCb
            // 
            EmpPosCb.FormattingEnabled = true;
            EmpPosCb.Items.AddRange(new object[] { "MANAGER", "SENIOR DEVELOPER", "JUNIOR DEVELOPER", "ACCOUNTANT", "RECEPTIONIST" });
            EmpPosCb.Location = new Point(44, 318);
            EmpPosCb.Name = "EmpPosCb";
            EmpPosCb.Size = new Size(193, 28);
            EmpPosCb.TabIndex = 15;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.Location = new Point(44, 421);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(193, 27);
            EmpPhoneTb.TabIndex = 14;
            // 
            // EmpIdTb
            // 
            EmpIdTb.Location = new Point(44, 112);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(193, 27);
            EmpIdTb.TabIndex = 13;
            EmpIdTb.TextChanged += textBox3_TextChanged;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(416, 112);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(200, 27);
            EmpNameTb.TabIndex = 12;
            // 
            // EmpAddTb
            // 
            EmpAddTb.Location = new Point(44, 220);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(193, 27);
            EmpAddTb.TabIndex = 11;
            EmpAddTb.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(44, 70);
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
            label8.Location = new Point(44, 178);
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
            label7.Location = new Point(44, 277);
            label7.Name = "label7";
            label7.Size = new Size(120, 27);
            label7.TabIndex = 8;
            label7.Text = "POSITION";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(44, 378);
            label6.Name = "label6";
            label6.Size = new Size(202, 27);
            label6.TabIndex = 7;
            label6.Text = "PHONE NUMBER";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(416, 70);
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
            label4.Location = new Point(416, 178);
            label4.Name = "label4";
            label4.Size = new Size(111, 27);
            label4.TabIndex = 5;
            label4.Text = "GENDER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(416, 378);
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
            label2.Location = new Point(416, 277);
            label2.Name = "label2";
            label2.Size = new Size(189, 27);
            label2.TabIndex = 3;
            label2.Text = "DATE OF BIRTH";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1361, 9);
            label10.Name = "label10";
            label10.Size = new Size(27, 27);
            label10.TabIndex = 4;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1282, 717);
            label11.Name = "label11";
            label11.Size = new Size(83, 23);
            label11.TabIndex = 25;
            label11.Text = "Aryaman";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1242, 717);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 19);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1404, 801);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox EmpPosCb;
        private TextBox EmpPhoneTb;
        private TextBox EmpIdTb;
        private TextBox EmpNameTb;
        private TextBox EmpAddTb;
        private ComboBox EmpGenCb;
        private ComboBox EmpEduCb;
        private DateTimePicker EmpDob;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView EmpDGV;
        private Button button4;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
    }
}