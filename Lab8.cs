#pragma warning disable CS8622
using System.Diagnostics;

namespace LabCrypt
{
    public partial class Lab8 : Form, IMyForm
    {
        private enum EncMethod
        {
            RSA,
            Elgamal,
            ECC
        }

        private EncMethod encMethod = EncMethod.RSA;

        public Lab8()
        {
            this.WindowState = FormWindowState.Maximized;
            Program.Forms.Add(this);

            InitializeComponent();

            UpdateForm();
            this.FormClosing += new FormClosingEventHandler(Program.ApplicationExit);
        }

        private void MainPage_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Program.Forms[0];
            form1.Show();
            form1.UpdateForm();
            this.Hide();
        }

        public void UpdateForm()
        {
            this.InputTextBox.Text = Program.InputText;
            this.OutputTextBox.Text = Program.OutputText;
        }

        private void RSA_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.RSA;

            this.RSA_btn.BackColor = Color.Turquoise;
            this.Elgamal_btn.BackColor = Color.Transparent;
            this.Ecc_btn.BackColor= Color.Transparent;
        }

        private void Elgamal_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Elgamal;

            this.RSA_btn.BackColor = Color.Transparent;
            this.Elgamal_btn.BackColor = Color.Turquoise;
            this.Ecc_btn.BackColor = Color.Transparent;
        }

        private void Ecc_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.ECC;

            this.RSA_btn.BackColor = Color.Transparent;
            this.Elgamal_btn.BackColor = Color.Transparent;
            this.Ecc_btn.BackColor = Color.Turquoise;
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.InputText = this.InputTextBox.Text;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.RSA:
                    RSAEncrypt();
                    break;
                case EncMethod.Elgamal:
                    ElgamalEncrypt();
                    break;
                case EncMethod.ECC:
                    ECCEnrypt();
                    break;
                default:
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.RSA:
                    RSADecrypt();
                    break;
                case EncMethod.Elgamal:
                    ElgamalDecrypt();
                    break;
                case EncMethod.ECC:
                    ECCDecrypt();
                    break;
                default:
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void RSAEncrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/rsa.py " +
                $"{this.pBox.Text} " +
                $"{this.qBox.Text} " +
                $"{this.eBox.Text} " + 
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
        }

        private void RSADecrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/rsa.py " +
                $"{this.pBox.Text} " +
                $"{this.qBox.Text} " +
                $"{this.eBox.Text} " +
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

        private void ElgamalEncrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/elgamal.py " +
                $"{this.pBox.Text} " +
                $"{this.gBox.Text} " +
                $"{this.xBox.Text} " +
                "encode " +
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
        }

        private void ElgamalDecrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/elgamal.py " +
                $"{this.pBox.Text} " +
                $"{this.gBox.Text} " +
                $"{this.xBox.Text} " +
                "decode " +
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
        }

        private void ECCEnrypt()
        {
            string input = Program.InputText.ToLower();

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/ecc.py " +
                $"{this.pBox.Text} " +
                $"{this.aBox.Text} " +
                $"{this.bBox.Text} " +
                $"{this.CbBox.Text} " +
                $"{this.x2Box.Text} " +
                $"{this.yBox.Text} " +
                $"{this.kBox.Text} " +
                $"{this.e2Box.Text} " +
                "encode " +
                $"{input}";

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
        }

        private void ECCDecrypt()
        {
            string input = Program.InputText.ToLower();

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/ecc.py " +
                $"{this.pBox.Text} " +
                $"{this.aBox.Text} " +
                $"{this.bBox.Text} " +
                $"{this.CbBox.Text} " +
                $"{this.x2Box.Text} " +
                $"{this.yBox.Text} " +
                $"{this.kBox.Text} " +
                $"{this.e2Box.Text} " +
                "decode " +
                $"{input}";

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
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Program.OutputText += e.Data + "\n\r";
        }
    }
}
