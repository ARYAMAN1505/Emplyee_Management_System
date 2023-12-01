using System.Diagnostics;

namespace employeeManagementSystem
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                this.Hide();
                login log = new login();
                log.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void RunPrgExecutable()
        {
            // Adjust the path to your executable if it's not in the same directory
            Process.Start("prg_executable.exe");
        }
    }
}