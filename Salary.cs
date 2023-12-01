using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace employeeManagementSystem
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\Documents\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void fetchempdata()
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter Employee Id");
            }
            else
            {
                Con.Open();
                string query = "select * from EmployeeTbl where EmpId='" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    EmpNameTb.Text = dr["Empname"].ToString();

                    EmpPosTb.Text = dr["Emppos"].ToString();

                }
                Con.Close();
            }

        }
        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int Dailybase, total;
        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpPosTb.Text == "")
            {
                MessageBox.Show("Select an Employee");
            }
            else if (WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 28)
            {
                MessageBox.Show("Enter a valid number of days");
            }
            else
            {
                if (EmpPosTb.Text == "MANAGER")
                {
                    Dailybase = 3000;
                }
                else if (EmpPosTb.Text == "SENIOR DEVELOPER")
                {
                    Dailybase = 2500;
                }
                else if (EmpPosTb.Text == "JUNIOR DEVELOPER")
                {
                    Dailybase = 2000;
                }
                else
                {
                    Dailybase = 1000;
                }
                total = Dailybase * Convert.ToInt32(WorkedTb.Text);
                SalarySlip.Text = "Employee ID: " + EmpIdTb.Text + "\n" + "Employee Name: " + EmpNameTb.Text + "\n" + "Employee Position: " + EmpPosTb.Text + "\n" + "Days Worked: " + WorkedTb.Text + "\n" + "Daily Income: " + Dailybase + "\n" + "Total Income: " + total;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=======SALARY DOCUMENT=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(200));
            e.Graphics.DrawString("Employee ID: " + EmpIdTb.Text , new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Position: " + EmpPosTb.Text , new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Worke Days: " + WorkedTb.Text , new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Daily Pay: " + Dailybase , new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Total Salary: " + total , new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 260));


            e.Graphics.DrawString("=======BY ARYAMAN=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(200, 320));
        }
    }
}
