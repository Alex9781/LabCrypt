#pragma warning disable CS8622
using System.Diagnostics;

namespace LabCrypt
{
    public partial class Lab9 : Form, IMyForm
    {
        public Lab9()
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

        private void ElgamalDSA_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Sign_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            ElgamalDSASign();

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Check_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            ElgamalDSACheck();

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void ElgamalDSASign()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/elgamal_dsa.py " +
                $"{this.pBox.Text} " +
                $"{this.gBox.Text} " +
                $"{this.xBox.Text} " +
                $"{this.kBox.Text} " +
                $"{this.aBox.Text} " +
                $"{this.bBox.Text} " +              
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
        }

        private void ElgamalDSACheck()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/elgamal_dsa.py " +
                $"{this.pBox.Text} " +
                $"{this.gBox.Text} " +
                $"{this.xBox.Text} " +
                $"{this.kBox.Text} " +
                $"{this.aBox.Text} " +
                $"{this.bBox.Text} " +
                "0 " +
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
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Program.OutputText += e.Data;
        }
    }
}
