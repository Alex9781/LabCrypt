#pragma warning disable CS8622
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

        //private readonly string alph = "\0абвгдежзийклмнопрстуфхцчшщъыьэюя—,?.\n\r ";
        //private readonly string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя—,?.\n\r ";

        //private readonly string alph = "\0абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string alph = "абвгдежзиклмнопрстуфхцчшщьыэюя";

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
            this.OutputTextBox.Text = Program.OutputText;
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
            Matrix key = new(3, 3);
            key.Fill(this.keyBox.Text);

            int[] input = new int[Program.InputText.Length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = alph.IndexOf(Program.InputText[i].ToString().ToLower());
            }
            List<int> lInput = input.ToList();
            while (lInput.Count % key.Dimension != 0)
            {
                lInput.Add(-1);
            }

            for (int i = 0; i < lInput.Count; i += 3)
            {
                int[,] s = { { lInput[i] }, { lInput[i + 1] }, { lInput[i + 2] } };
                Matrix chunk = new(s);
                chunk = Matrix.Multiply(key, chunk);
                foreach (int num in chunk.Data)
                {
                    Program.OutputText += num.ToString() + " ";
                }
            }
        }

        private void PlayfairEncrypt()
        {
            string open = Program.InputText.ToLower();
            List<char[]> key = new(5);
            for (int i = 0; i < 5; i++) key.Add(new char[6]);
            List<char> inputKey = new(this.keyBox.Text);
            List<char> alphCopy = new(alph);

            int a = 0, b = 0;
            for (int i = 0; i < key.Count; i++)
            {
                for (int j = 0; j < key[i].Length; j++)
                {
                    if (a < inputKey.Count)
                    {
                        key[i][j] = inputKey[a];
                        a++;
                    }
                    else
                    {
                        while (inputKey.Contains(alphCopy[b])) b++;
                        key[i][j] = alphCopy[b];
                        b++;
                    }
                }
            }

            for (int i = 1; i < open.Length; i++)
            {
                if (open[i] == open[i - 1]) open = open.Insert(i, "ф");
            }

            if (open.Length % 2 != 0) open += "ф";

            string[] openList = new string[open.Length / 2];
            for (int i = 1; i < open.Length; i += 2)
            {
                openList[(i - 1) / 2] = open[i - 1].ToString() + open[i].ToString();
            }


            int x0 = 0, x1 = 0, y0 = 0, y1 = 0;
            for (int chunk = 0; chunk < openList.Length; chunk++)
            {
                for (int keyString = 0; keyString < key.Count; keyString++)
                {
                    for (int keySymbol = 0; keySymbol < key[keyString].Length; keySymbol++)
                    {
                        if (openList[chunk][0] == key[keyString][keySymbol])
                        {
                            y1 = keyString;
                            x1 = keySymbol;
                        }
                        if (openList[chunk][1] == key[keyString][keySymbol])
                        {
                            y0 = keyString;
                            x0 = keySymbol;
                        }
                    }
                }

                for (int keyString = 0; keyString < key.Count; keyString++)
                {
                    if (key[keyString].Contains(key[y0][x0]) && key[keyString].Contains(key[y1][x1]))
                    {
                        if (x0 == 5) x0 = 0;
                        else x0++;

                        if (x1 == 5) x1 = 0;
                        else x1++;
                    }

                }

                (y0, y1) = (y1, y0);
                Program.OutputText += key[y0][x0].ToString() + key[y1][x1].ToString();
            }

        }

        private void MatrixDecrypt()
        {
            Matrix key = new(3, 3);
            key.Fill(this.keyBox.Text);
            int det = (int)key.Determinant();

            string[] sInput = Program.InputText.Split(" ");
            int[] input = new int[sInput.Length];

            for (int i = 0; i < input.Length; i++)
            {
                _ = Int32.TryParse(sInput[i], out input[i]);
            }

            for (int i = 0; i < input.Length - 1; i += 3)
            {
                int[,] s = { { input[i] }, { input[i + 1] }, { input[i + 2] } };
                Matrix chunk = new(s);

                chunk = Matrix.Multiply(key.AdditionalMatrix().Reverse().Transpose(), chunk, det);
                foreach (int num in chunk.Data)
                {
                    Program.OutputText += alph[(int)Math.Abs(num)];
                }
            }
        }

        private void PlayfairDecrypt()
        {
            string open = Program.InputText.ToLower();
            List<char[]> key = new(5);
            for (int i = 0; i < 5; i++) key.Add(new char[8]);
            List<char> inputKey = new(this.keyBox.Text);
            List<char> alphCopy = new(alph);

            int a = 0, b = 0;
            for (int i = 0; i < key.Count; i++)
            {
                for (int j = 0; j < key[i].Length; j++)
                {
                    if (a < inputKey.Count)
                    {
                        key[i][j] = inputKey[a];
                        a++;
                    }
                    else
                    {
                        while (inputKey.Contains(alphCopy[b])) b++;
                        key[i][j] = alphCopy[b];
                        b++;
                    }
                }
            }

            string[] openList = new string[open.Length / 2];
            for (int i = 1; i < open.Length; i += 2)
            {
                openList[(i - 1) / 2] = open[i - 1].ToString() + open[i].ToString();
            }


            int x0 = 0, x1 = 0, y0 = 0, y1 = 0;
            for (int chunk = 0; chunk < openList.Length; chunk++)
            {
                for (int keyString = 0; keyString < key.Count; keyString++)
                {
                    for (int keySymbol = 0; keySymbol < key[keyString].Length; keySymbol++)
                    {
                        if (openList[chunk][0] == key[keyString][keySymbol])
                        {
                            y0 = keyString;
                            x0 = keySymbol;
                        }
                        if (openList[chunk][1] == key[keyString][keySymbol])
                        {
                            y1 = keyString;
                            x1 = keySymbol;
                        }
                    }
                }

                for (int keyString = 0; keyString < key.Count; keyString++)
                {
                    if (key[keyString].Contains(key[y0][x0]) && key[keyString].Contains(key[y1][x1]))
                    {
                        if (x0 == 0) x0 = 7;
                        else x0--;

                        if (x1 == 0) x1 = 7;
                        else x1--;
                    }

                }

                (y0, y1) = (y1, y0);
                Program.OutputText += key[y0][x0].ToString() + key[y1][x1].ToString();
            }
        }
    }
}
