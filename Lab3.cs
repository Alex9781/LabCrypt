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
            PlayfairCipher playfairCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                key = this.keyBox.Text,
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = playfairCipher.Encrypt(inputArgs);

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
            PlayfairCipher playfairCipher = new();

            ICipher.InputArgs inputArgs = new()
            {
                inputText = Program.InputText.ToLower(),
                key = this.keyBox.Text,
                isAlphFull = this.Is_Alph_Full_CheckBox.Checked,
            };

            Program.OutputText = playfairCipher.Decrypt(inputArgs);
        }
    }
}
