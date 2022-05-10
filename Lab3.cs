using System.Diagnostics;

namespace LabCrypt
{
    public partial class Lab3 : Form, IMyForm
    {
        private enum EncMethod
        {
            Matrix,
            Playfair
        }

        private EncMethod encMethod = EncMethod.Matrix;

        public Lab3()
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
            this.InputTextBox.Text = Program.InputText;
        }

        private void MainPage_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Program.Forms[0];
            form1.Show();
            form1.UpdateForm();
            this.Hide();
        }

        private void Matrix_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Matrix;
            this.Matrix_btn.BackColor = Color.Turquoise;
            this.Playfair_btn.BackColor = Color.Transparent;

        }

        private void Playfair_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Playfair;
            this.Matrix_btn.BackColor = Color.Transparent;
            this.Playfair_btn.BackColor = Color.Turquoise;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Matrix:
                    MatrixEncrypt();
                    break;
                case EncMethod.Playfair:
                    PlayfairEncrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Matrix:
                    MatrixDecrypt();
                    break;
                case EncMethod.Playfair:
                    PlayfairDecrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void MatrixEncrypt()
        {
            MatrixCipher matrixCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                key = this.keyBox.Text,
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = matrixCipher.Encrypt(inputArgs);
        }

        private void PlayfairEncrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            int isAlphFull = this.Is_Alph_Full_CheckBox.Checked ? 1 : 0;

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/playfair.py " +
                $"{isAlphFull} " +
                $"1 " +
                $"{this.keyBox.Text} " +
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

        private void MatrixDecrypt()
        {
            MatrixCipher matrixCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                key = this.keyBox.Text,
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = matrixCipher.Decrypt(inputArgs);
        }

        private void PlayfairDecrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            int isAlphFull = this.Is_Alph_Full_CheckBox.Checked ? 1 : 0;

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/playfair.py " +
                $"{isAlphFull} " +
                $"0 " +
                $"{this.keyBox.Text} " +
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

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Program.OutputText += e.Data + "\n\r";
        }
    }
}
