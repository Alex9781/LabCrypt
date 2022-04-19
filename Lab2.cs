namespace LabCrypt
{
    public partial class Lab2 : Form, IMyForm
    {
        private enum EncMethod
        {
            Trithemium,
            Belazo,
            Vigenere,
            Magma
        }

        private EncMethod encMethod = EncMethod.Trithemium;

        public Lab2()
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

        private void Trithemium_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Trithemium;
            this.keyBox.Enabled = false;
            this.Trithemium_btn.BackColor = Color.Turquoise;
            this.Belazo_btn.BackColor = Color.Transparent;
            this.Vigenere_btn.BackColor = Color.Transparent;
            this.Magma_btn.BackColor = Color.Transparent;
        }

        private void Belazo_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Belazo;
            this.keyBox.Enabled = true;
            this.Trithemium_btn.BackColor = Color.Transparent;
            this.Belazo_btn.BackColor = Color.Turquoise;
            this.Vigenere_btn.BackColor = Color.Transparent;
            this.Magma_btn.BackColor = Color.Transparent;
        }

        private void Vigenere_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Vigenere;
            this.keyBox.Enabled = true;
            this.Trithemium_btn.BackColor = Color.Transparent;
            this.Belazo_btn.BackColor = Color.Transparent;
            this.Vigenere_btn.BackColor = Color.Turquoise;
            this.Magma_btn.BackColor = Color.Transparent;
        }

        private void Magma_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Magma;
            this.keyBox.Enabled = false;
            this.Trithemium_btn.BackColor = Color.Transparent;
            this.Belazo_btn.BackColor = Color.Transparent;
            this.Vigenere_btn.BackColor = Color.Transparent;
            this.Magma_btn.BackColor = Color.Turquoise;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Trithemium:
                    TrithemiumEncrypt();
                    break;
                case EncMethod.Belazo:
                    BelazoEncrypt();
                    break;
                case EncMethod.Vigenere:
                    VigenereEncrypt();
                    break;
                case EncMethod.Magma:
                    MagmaEncrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Trithemium:
                    TrithemiumDecrypt();
                    break;
                case EncMethod.Belazo:
                    BelazoDecrypt();
                    break;
                case EncMethod.Vigenere:
                    VigenereDecrypt();
                    break;
                case EncMethod.Magma:
                    MagmaDecrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void TrithemiumEncrypt()
        {
            TrithemiumCipher trithemiumCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = trithemiumCipher.Encrypt(inputArgs);
        }

        private void BelazoEncrypt()
        {
            BelazoCipher belazoCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
                key = this.keyBox.Text,
            };

            Program.OutputText = belazoCipher.Encrypt(inputArgs);
        }

        private void VigenereEncrypt()
        {
            VigenereCipher vigenereCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
                key = this.keyBox.Text,
            };

            Program.OutputText = vigenereCipher.Encrypt(inputArgs);
        }

        private void MagmaEncrypt()
        {
            MagmaCipher magmaCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = this.InputTextBox.Text,
            };

            Program.OutputText = magmaCipher.Encrypt(inputArgs);
        }

        private void TrithemiumDecrypt()
        {
            TrithemiumCipher trithemiumCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = trithemiumCipher.Decrypt(inputArgs);
        }

        private void BelazoDecrypt()
        {
            BelazoCipher belazoCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
                key = this.keyBox.Text,
            };

            Program.OutputText = belazoCipher.Decrypt(inputArgs);
        }

        private void VigenereDecrypt()
        {
            VigenereCipher vigenereCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
                key = this.keyBox.Text,
            };

            Program.OutputText = vigenereCipher.Decrypt(inputArgs);
        }

        private void MagmaDecrypt()
        {
            MagmaEncrypt();
        }
    }
}
