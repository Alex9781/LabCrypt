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
            SignMethod = DSA.GOST94;

            this.GOST94_ecp_btn.BackColor = Color.Turquoise;
            this.GOST12_ecp_btn.BackColor = Color.Transparent;
        }

        private void GOST12_ecp_btn_Click(object sender, EventArgs e)
        {
            SignMethod = DSA.GOST12;

            this.GOST94_ecp_btn.BackColor = Color.Transparent;
            this.GOST12_ecp_btn.BackColor = Color.Turquoise;
        }

        private void Sign_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (SignMethod)
            {
                case DSA.GOST94:
                    GOST94Sign();
                    break;
                case DSA.GOST12:
                    GOST12Sign();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void GOST94Sign()
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
        }

        private void GOST12Sign()
        {
            string input = Program.InputText;
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/gost12_dsa.py " +
                $"{this.a2_box.Text} " + //1
                $"{this.b2_box.Text} " + //2
                $"{this.p2_box.Text} " + //3
                $"{this.xu2_box.Text} " + //4
                $"{this.x2_box.Text} " + //5
                $"{this.y2_box.Text} " + //6
                $"{this.k2_box.Text} " + //7
                "1 " + //8
                $"{formatedInput}"; //9

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
