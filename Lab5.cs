#pragma warning disable CS8622
using System.Text;
using GOST;

namespace LabCrypt
{
    public partial class Lab5 : Form, IMyForm
    {
        private enum EncMethod
        {
            Shennon,
            Gost_28147
        }

        private EncMethod encMethod = EncMethod.Shennon;
        //private readonly string alph = "абвгдежзиклмнопрстуфхцчшщьыэюя";
        private readonly string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя—,?.\n\r ";
        private byte[] lastResult;

        public Lab5()
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

        private void Shennon_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Shennon;
            this.ivBox.Enabled = false;
            this.Shennon_btn.BackColor = Color.Turquoise;
            this.Gost_28147_btn.BackColor = Color.Transparent;
        }

        private void Gost_28147_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Gost_28147;
            this.ivBox.Enabled = true;
            this.Shennon_btn.BackColor = Color.Transparent;
            this.Gost_28147_btn.BackColor = Color.Turquoise;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Shennon:
                    ShennonEncrypt();
                    break;
                case EncMethod.Gost_28147:
                    Gost_28147Encrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Shennon:
                    ShennonDecrypt();
                    break;
                case EncMethod.Gost_28147:
                    Gost_28147Decrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void ShennonEncrypt()
        {
            int[] input = new int[Program.InputText.Length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = alph.IndexOf(Program.InputText.ToLower()[i]);
            }

            int[] key = new int[Program.InputText.Length];
            Program.OutputText = "Key: ";
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = new Random().Next(0, 40);
                Program.OutputText += $"{key[i]} ";
            }
            Program.OutputText += "\nOutput: ";

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] ^ key[i];
                Program.OutputText += $"{input[i]} ";
            }
        }

        private void Gost_28147Encrypt()
        {
            byte[] key = Encoding.UTF8.GetBytes(this.keyBox.Text);
            byte[] iv = Encoding.UTF8.GetBytes(this.ivBox.Text);
            byte[] input = Encoding.UTF8.GetBytes(Program.InputText);

            var gost = new GOSTManaged();
            byte[] output = gost.XOREncode(key, iv, input);
            Program.OutputText = Encoding.UTF8.GetString(output);
            lastResult = output;
        }

        private void ShennonDecrypt()
        {
            string[] inputStr = Program.InputText.ToLower().Split(" ");
            string[] keyStr = this.keyBox.Text.Split(" ");

            int[] input = new int[inputStr.Length-1];
            int[] key = new int[inputStr.Length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(inputStr[i]);
                key[i] = int.Parse(keyStr[i]);

                input[i] = input[i] ^ key[i];
                Program.OutputText += alph[input[i]];
            }
        }

        private void Gost_28147Decrypt()
        {
            byte[] key = Encoding.UTF8.GetBytes(this.keyBox.Text);
            byte[] iv = Encoding.UTF8.GetBytes(this.ivBox.Text);

            var gost = new GOSTManaged();
            byte[] output = gost.XORDecode(key, iv, lastResult);
            Program.OutputText = Encoding.UTF8.GetString(output);
        }    
    }
}
