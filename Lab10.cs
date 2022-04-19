using System.Diagnostics;

namespace LabCrypt
{
    public partial class Lab10 : Form, IMyForm
    {
        public enum DSA
        {
            GOST94,
            GOST12
        }
        private DSA SignMethod = DSA.GOST94;

        public Lab10()
        {
            this.WindowState = FormWindowState.Maximized;
            Program.Forms.Add(this);

            InitializeComponent();

            UpdateForm();
            this.FormClosing += new FormClosingEventHandler(Program.ApplicationExit);
        }

        public void UpdateForm()
        {
            this.InputTextBox.Text = Program.InputText;
            this.OutputTextBox.Text = Program.OutputText;
        }

        private void MainPage_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Program.Forms[0];
            form1.Show();
            form1.UpdateForm();
            this.Hide();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.InputText = this.InputTextBox.Text;
        }

        private void GOST94_ecp_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";
        }

        private void Sign_btn_Click(object sender, EventArgs e)
        {
            string input = Program.InputText;
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/gost94_dsa.py " +
                $"{this.pBox.Text} " +
                $"{this.qBox.Text} " +
                $"{this.aBox.Text} " +
                $"{this.xBox.Text} " +
                $"{this.kBox.Text} " +
                $"{this.rBox.Text} " +
                $"{this.sBox.Text} " +
                "1 " +
                $"{formatedInput}";

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:/Users/alexz/AppData/Local/Programs/Python/Python310/python.exe",
                    Arguments = strCommandParameters,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };
            process.OutputDataReceived += Process_OutputDataReceived;
            process.ErrorDataReceived += Process_OutputDataReceived;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.WaitForExit();
            Console.Read();

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Check_btn_Click(object sender, EventArgs e)
        {

        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Program.OutputText += e.Data;
        }
    }
}
