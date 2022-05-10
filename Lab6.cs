#pragma warning disable CS8622
using System.Diagnostics;

namespace LabCrypt
{
    public partial class Lab6 : Form, IMyForm
    {
        private enum EncMethod
        {
            A51,
            A52
        }

        private EncMethod encMethod = EncMethod.A51;

        public Lab6()
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

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.InputText = this.InputTextBox.Text;
        }

        private void MainPage_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Program.Forms[0];
            form1.Show();
            form1.UpdateForm();
            this.Hide();
        }

        private void A51_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.A51;
            this.A51_btn.BackColor = Color.Turquoise;
            this.A52_btn.BackColor = Color.Transparent;
        }

        private void A52_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.A52;
            this.A52_btn.BackColor = Color.Turquoise;
            this.A51_btn.BackColor = Color.Transparent;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.A51:
                    A51Encrypt();
                    break;
                case EncMethod.A52:
                    A52Encrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.A51:
                    A51Decrypt();
                    break;
                case EncMethod.A52:
                    A52Decrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void A51Encrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters = $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/a51.py " +
                $"{this.keyBox.Text} " +
                $"{this.ivBox.Text} 1 " +
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

        private void A52Encrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters = $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/a52.py " +
                $"{this.keyBox.Text} " +
                $"{this.ivBox.Text} 1 " +
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

        private void A51Decrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters = $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/a51.py " +
                $"{this.keyBox.Text} " +
                $"{this.ivBox.Text} 0 " +
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

        private void A52Decrypt()
        {
            string strCommandParameters = $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/a52.py " +
                $"{this.keyBox.Text} " +
                $"{this.ivBox.Text} 0 " +
                $"{Program.InputText}";

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
            Program.OutputText += e.Data + "\n\r";
        }
    }
}
