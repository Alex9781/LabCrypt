#pragma warning disable CS8622
#pragma warning disable CS8618
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
            this.keyBox.Enabled = false;

            this.TBox.Enabled = true;
            this.aBox.Enabled = true;
            this.cBox.Enabled = true;

            this.Shennon_btn.BackColor = Color.Turquoise;
            this.Gost_28147_btn.BackColor = Color.Transparent;
        }

        private void Gost_28147_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Gost_28147;

            this.ivBox.Enabled = true;
            this.keyBox.Enabled = true;

            this.TBox.Enabled = false;
            this.aBox.Enabled = false;
            this.cBox.Enabled = false;

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

            List<int> key = new List<int>();
            int a = int.Parse(this.aBox.Text);
            int c = int.Parse(this.cBox.Text);
            int[] output = input;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0) key.Add(int.Parse(this.TBox.Text));
                else key.Add((a * key[i - 1] + c) % alph.Length);
                output[i] = input[i] ^ key[i];
                Program.OutputText += $"{output[i]} ";
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

            int[] input = new int[inputStr.Length-1];

            List<int> key = new List<int>();
            int a = int.Parse(this.aBox.Text);
            int c = int.Parse(this.cBox.Text);

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(inputStr[i]);

                if (i == 0) key.Add(int.Parse(this.TBox.Text));
                else key.Add((a * key[i - 1] + c) % alph.Length);

                input[i] = input[i] ^ key[i];
                Program.OutputText += alph[(int)input[i]];
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
