#pragma warning disable CS8622 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCrypt
{
    public partial class Lab1 : Form
    {
        private enum EncMethod
        {
            Atbash,
            Caesar,
            Polybius
        }

        private EncMethod encMethod = EncMethod.Atbash;
        private Color defaultColor = Color.White;

        private string alph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?.";

        public Lab1()
        {
            this.WindowState = FormWindowState.Maximized;
            Program.Forms.Add(this);

            InitializeComponent();

            UpdateForm();

            this.FormClosing += new FormClosingEventHandler(Program.ApplicationExit);
            defaultColor = Atbash_btn.BackColor;
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

            if (encMethod == EncMethod.Atbash) AtbashEncrypt();
            else if (encMethod == EncMethod.Caesar) CaesarEncrypt();
            else PolybiusEncrypt();

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            if (encMethod == EncMethod.Atbash) AtbashDecrypt();
            else if (encMethod == EncMethod.Caesar) CaesarDecrypt();
            else PolybiusDecrypt();

            this.OutputTextBox.Text = Program.OutputText;
        }

        private void AtbashEncrypt()
        {
            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    continue;
                }
                Program.OutputText += alph[alph.Length - 1 - alph.IndexOf(c)];
            }
        }

        private void CaesarEncrypt()
        {
            if (!Int32.TryParse(this.keyBox.Text, out int key))
            {
                return;
            }

            foreach (char c in Program.InputText.ToLower())
            {
                if (!alph.Contains(c))
                {
                    Program.OutputText += c;
                    continue;
                }
                Program.OutputText += alph[(alph.IndexOf(c) + key) % alph.Length];
            }
        }

        private void PolybiusEncrypt()
        {
            foreach (char c in Program.InputText.ToLower())
            {
                int letter = alph.IndexOf(c);
                Program.OutputText += (letter / 6 + 1).ToString() + (letter % 6 + 1).ToString() + " ";
            }
        }

        private void AtbashDecrypt()
        {
            foreach (char c in Program.InputText.ToLower())
            {
                if (alph.IndexOf(c) == -1)
                {
                    Program.OutputText += c;
                    continue;
                }

                Program.OutputText += alph[alph.Length - 1 - alph.IndexOf(c)];
            }
        }

        private void CaesarDecrypt()
        {
            if (!Int32.TryParse(this.keyBox.Text, out int key))
            {
                return;
            }

            foreach (char c in Program.InputText.ToLower())
            {
                if (alph.IndexOf(c) == -1)
                {
                    Program.OutputText += c;
                    continue;
                }

                Program.OutputText += alph[(alph.IndexOf(c) - key + alph.Length) % alph.Length];
            }
        }

        private void PolybiusDecrypt()
        {
            string[] openCopy = Program.InputText.ToLower().Split(" ");
            int[] openCopyInt = new int[openCopy.Length];

            for (int i = 0; i < openCopy.Length - 1; i++)
            {
                openCopyInt[i] = (Int32.Parse(openCopy[i]));
            }

            foreach (int c in openCopyInt)
            {
                if (c == 0) continue;
                if ((c / 10 * 6 - 1) - (6 - (c % 10)) == -1)
                {
                    Program.OutputText += ' ';
                    continue;
                }
                Program.OutputText += alph[(c / 10 * 6 - 1) - (6 - (c % 10))];
            }
        }
    }
}
