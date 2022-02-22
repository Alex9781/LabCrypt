#pragma warning disable CS8622 
namespace LabCrypt
{
    public partial class Lab2 : Form
    {
        private enum EncMethod
        {
            Trithemium,
            Belazo,
            Vigenere,
            Magma
        }

        private EncMethod encMethod = EncMethod.Trithemium;

        private readonly string alph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?.";
        //private readonly string alph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

        private readonly int[,] sBlocks = {
                {12, 4, 6, 2, 10, 5, 11, 9, 14, 8, 13, 7, 0, 3, 15, 1 },
                {6, 8, 2, 3, 9, 10, 5, 12, 1, 14, 4, 7, 11, 13, 0, 15 },
                {11, 3, 5, 8, 2, 15, 10, 13, 14, 1, 7, 4, 12, 9, 6, 0 },
                {12, 8, 2, 1, 13, 4, 15, 6, 7, 0, 10, 5, 3, 14, 9, 11 },
                {7, 15, 5, 10, 8, 1, 6, 13, 0, 9, 3, 14, 11, 4, 2, 12 },
                {5, 13, 15, 6, 9, 2, 12, 10, 11, 7, 8, 1, 4, 3, 14, 0 },
                {8, 14, 2, 5, 6, 9, 1, 12, 15, 4, 11, 0, 13, 10, 3, 7 },
                {1, 7, 14, 13, 0, 5, 8, 3, 4, 15, 10, 6, 9, 12, 11, 2 } };

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
            int i = 1;
            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    continue;
                }
                Program.OutputText += alph[(alph.IndexOf(c) + i - 1) % alph.Length];
                i++;
            }
        }

        private void BelazoEncrypt()
        {
            int i = 0;
            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    continue;
                }
                i %= this.keyBox.Text.Length;
                Program.OutputText += alph[(alph.IndexOf(c) + alph.IndexOf(keyBox.Text[i])) % alph.Length];
                i++;
            }
        }

        private void VigenereEncrypt()
        {
            char key = keyBox.Text[0];
            int i = 0;
            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    i++;
                    continue;
                }
                Program.OutputText += alph[((alph.IndexOf(c) + alph.IndexOf(key)) % alph.Length)];

                key = Program.InputText[i].ToString().ToLower().ToCharArray()[0];
                i++;
            }
        }

        private void MagmaEncrypt()
        {
            string[] input = Program.InputText.Split(" ");
            int[] intInput = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intInput[i] = Int32.Parse(input[i]);
            }

            List<int> intList = new(); 
            for (int i = 0; i < input.Length; i++)
            {
                intList.Add(sBlocks[i / 4, intInput[i]]);
            }

            for (int i = 0; i < 11; i++)
            {
                intList.Add(intList[0]);
                intList.RemoveAt(0);
            }

            foreach(var item in intList)
            {
                Program.OutputText += item + " ";
            }
        }

        private void TrithemiumDecrypt()
        {
            int i = 1;
            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    continue;
                }
                Program.OutputText += alph[(alph.IndexOf(c) - i + 1 + ((Program.InputText.Length / alph.Length) * alph.Length)) % alph.Length];
                i++;
            }
        }

        private void BelazoDecrypt()
        {
            int i = 0;
            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    continue;
                }
                i %= this.keyBox.Text.Length;
                Program.OutputText += alph[((alph.IndexOf(c) + alph.IndexOf(keyBox.Text[i]) * -1) + ((Program.InputText.Length / alph.Length) * alph.Length)) % alph.Length];
                i++;
            }
        }

        private void VigenereDecrypt()
        {
            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    continue;
                }
                Program.OutputText += alph[((alph.IndexOf(c) + alph.IndexOf(keyBox.Text) * -1) + ((Program.InputText.Length / alph.Length) * alph.Length)) % alph.Length];
            }
        }

        private void MagmaDecrypt()
        {
            MagmaEncrypt();
        }
    }
}
