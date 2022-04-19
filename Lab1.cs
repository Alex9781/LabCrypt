namespace LabCrypt
{
    public partial class Lab1 : Form, IMyForm
    {
        private enum EncMethod
        {
            Atbash,
            Caesar,
            Polybius
        }

        private EncMethod encMethod = EncMethod.Atbash;

        public Lab1()
        {
            this.WindowState = FormWindowState.Maximized;
            Program.Forms.Add(this);

            InitializeComponent();

            UpdateForm();

            this.FormClosing += new FormClosingEventHandler(Program.ApplicationExit);
        }

        public void UpdateForm()
        {
            this.InputTextBox.Text = Program.InputText.ToLower();
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

        private void Atbash_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Atbash;
            this.keyBox.Enabled = false;
            this.Atbash_btn.BackColor = Color.Turquoise;
            this.Caesar_btn.BackColor = Color.Transparent;
            this.Polybius_btn.BackColor = Color.Transparent;
        }

        private void Caesar_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Caesar;
            this.keyBox.Enabled = true;
            this.Atbash_btn.BackColor = Color.Transparent;
            this.Caesar_btn.BackColor = Color.Turquoise;
            this.Polybius_btn.BackColor = Color.Transparent;
        }

        private void Polybius_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Polybius;
            this.keyBox.Enabled = false;
            this.Atbash_btn.BackColor = Color.Transparent;
            this.Caesar_btn.BackColor = Color.Transparent;
            this.Polybius_btn.BackColor = Color.Turquoise;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Atbash:
                    AtbashEncrypt();
                    break;
                case EncMethod.Caesar:
                    CaesarEncrypt();
                    break;
                case EncMethod.Polybius:
                    PolybiusEncrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Atbash:
                    AtbashDecrypt();
                    break;
                case EncMethod.Caesar:
                    CaesarDecrypt();
                    break;
                case EncMethod.Polybius:
                    PolybiusDecrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void AtbashEncrypt()
        {
            AtbashCipher atbashCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = atbashCipher.Encrypt(inputArgs);

        }

        private void CaesarEncrypt()
        {
            CaesarCipher caesarCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
                key = this.keyBox.Text,
            };

            Program.OutputText = caesarCipher.Encrypt(inputArgs);

        }

        private void PolybiusEncrypt()
        {
            PolybiusCipher polybiusCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = polybiusCipher.Encrypt(inputArgs);
        }

        private void AtbashDecrypt()
        {
            AtbashCipher atbashCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = atbashCipher.Encrypt(inputArgs);
        }

        private void CaesarDecrypt()
        {
            CaesarCipher caesarCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
                key = this.keyBox.Text,
            };

            Program.OutputText = caesarCipher.Decrypt(inputArgs);
        }

        private void PolybiusDecrypt()
        {
            PolybiusCipher polybiusCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = polybiusCipher.Decrypt(inputArgs);
        }
    }
}
