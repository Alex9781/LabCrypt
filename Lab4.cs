using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace LabCrypt
{
    public partial class Lab4 : Form, IMyForm
    {
        private enum EncMethod
        {
            Vertical,
            Cardan,
            Feistel
        }

        private EncMethod encMethod = EncMethod.Vertical;
        private readonly DES DESalg;
        private byte[] encText = Array.Empty<byte>();

        //private readonly string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя—,?.\n\r ";
        private readonly string alph = "абвгдежзиклмнопрстуфхцчшщьыэюя";

        public Lab4()
        {
            this.WindowState = FormWindowState.Maximized;
            Program.Forms.Add(this);

            InitializeComponent();

            UpdateForm();

            this.FormClosing += new FormClosingEventHandler(Program.ApplicationExit);

            DESalg = DES.Create();
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

        private void Vertical_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Vertical;
            this.Vertical_btn.BackColor = Color.Turquoise;
            this.Cardan_btn.BackColor = Color.Transparent;
            this.Feistel_btn.BackColor = Color.Transparent;
        }

        private void Cardan_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Cardan;
            this.Vertical_btn.BackColor = Color.Transparent;
            this.Cardan_btn.BackColor = Color.Turquoise;
            this.Feistel_btn.BackColor = Color.Transparent;
        }

        private void Feistel_btn_Click(object sender, EventArgs e)
        {
            encMethod = EncMethod.Feistel;
            this.Vertical_btn.BackColor = Color.Transparent;
            this.Cardan_btn.BackColor = Color.Transparent;
            this.Feistel_btn.BackColor = Color.Turquoise;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Vertical:
                    VerticalEncrypt();
                    break;
                case EncMethod.Cardan:
                    CardanEncrypt();
                    break;
                case EncMethod.Feistel:
                    FeistelEncrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }


        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";

            switch (encMethod)
            {
                case EncMethod.Vertical:
                    VerticalDecrypt();
                    break;
                case EncMethod.Cardan:
                    CardanDecrypt();
                    break;
                case EncMethod.Feistel:
                    FeistelDecrypt();
                    break;
            }

            this.OutputTextBox.Text = Program.OutputText;
        }

        //private void VerticalEncrypt()
        //{
        //    string key = this.keyBox.Text;

        //    List<char> sortedKey = key.ToList<char>();
        //    sortedKey.Sort();

        //    string input = Program.InputText.ToLower();
        //    int cols = key.Length, rows = (int)Math.Ceiling(input.Length / (float)cols);

        //    List<char[]> matr = new();
        //    List<char[]> outputMatr = new();
        //    for (int i = 0; i < cols; i++)
        //    {
        //        matr.Add(new char[rows]);
        //        outputMatr.Add(new char[rows]);
        //    }
        //    int[] arrKey = new int[cols];

        //    for (int i = 0; i < arrKey.Length; i++)
        //    {
        //        arrKey[i] = sortedKey.IndexOf(key[i]);
        //        sortedKey[sortedKey.IndexOf(key[i])] = ' ';
        //    }

        //    int k = 0;
        //    for (int j = 0; j < matr[0].Length; j++)
        //    {
        //        for (int i = 0; i < matr.Count; i++)
        //        {
        //            if (k == input.Length) break;
        //            matr[i][j] = input[k];
        //            k++;
        //        }
        //    }

        //    for (int i = 0; i < matr.Count; i++)
        //    {
        //        outputMatr[i] = matr[arrKey[i]];
        //    }

        //    for (int j = 0; j < outputMatr[0].Length; j++)
        //    {
        //        for (int i = 0; i < matr.Count; i++)
        //        {
        //            if (outputMatr[i][j] == '\0') continue;
        //            Program.OutputText += outputMatr[i][j];
        //        }
        //    }
        //}

        //private void CardanEncrypt()
        //{
        //    string input = Program.InputText.ToLower();
        //    while (input.Length % 60 != 0) input += alph[new Random().Next(alph.Length)];
        //    string[] chunks = new string[input.Length / 60];
        //    for (int i = 0; i < chunks.Length; i++)
        //        chunks[i] = input.Substring(i * 60, 60);
        //    char[,] key = new char[6, 10];
        //    int k = 0;
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            key[i, j] = this.keyBox.Text[k];
        //            k++;
        //        }
        //    }
        //    for (int o = 0; o < chunks.Length; o++)
        //    {
        //        int axis = 1, prev = 0;
        //        char[,] output = new char[6, 10];

        //        for (int y = 0; y < 4; y++)
        //        {
        //            for (int i = 0; i < key.GetLength(0); i++)
        //            {
        //                for (int j = 0; j < key.GetLength(1); j++)
        //                {
        //                    if (key[i, j] == '1')
        //                    {
        //                        if (prev >= chunks[o].Length)
        //                        {
        //                            output[i, j] = alph[new Random().Next(alph.Length)];
        //                        }
        //                        else
        //                        {
        //                            output[i, j] = chunks[o][prev];
        //                            prev++;
        //                        }
        //                    }
        //                }
        //            }

        //            if (axis == 1) key = ReverseArray(key);
        //            else key = ReverseColumnArray(key);
        //            axis = (axis + 1) % 2;

        //        }

        //        foreach (char c in output)
        //        { 
        //            Program.OutputText += c;
        //        }
        //    }
        //}

        private void VerticalEncrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/vertical.py " +
                $"{this.keyBox.Text} " +
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

        private void CardanEncrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/cardano.py " +
                $"{this.keyBox.Text} " +
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

        private void FeistelEncrypt()
        {
            string input = Program.InputText;
            string strKey = this.keyBox.Text;
            byte[] key = Encoding.Unicode.GetBytes(strKey);

            DESalg.Key = key;

            MemoryStream mStream = new();
            CryptoStream cStream = new(
                mStream,
                DESalg.CreateEncryptor(DESalg.Key, DESalg.IV),
                CryptoStreamMode.Write);
            byte[] toEncrypt = new UnicodeEncoding().GetBytes(input);
            cStream.Write(toEncrypt, 0, toEncrypt.Length);
            cStream.FlushFinalBlock();
            byte[] ret = mStream.ToArray();
            encText = ret;
            cStream.Close();
            mStream.Close();

            Program.OutputText = Encoding.Unicode.GetString(ret);
        }

        //private void VerticalDecrypt()
        //{
        //    string key = this.keyBox.Text;

        //    List<char> sortedKey = key.ToList<char>();
        //    sortedKey.Sort();

        //    string input = Program.InputText.ToLower();
        //    int cols = key.Length, rows = (int)Math.Ceiling(input.Length / (float)cols);

        //    List<char[]> matr = new();
        //    List<char[]> outputMatr = new();
        //    List<char[]> tempMatr;
        //    for (int i = 0; i < cols; i++)
        //    {
        //        matr.Add(new char[rows]);
        //        outputMatr.Add(new char[rows]);
        //    }
        //    int[] arrKey = new int[cols];

        //    for (int i = 0; i < arrKey.Length; i++)
        //    {
        //        arrKey[i] = sortedKey.IndexOf(key[i]);
        //        sortedKey[sortedKey.IndexOf(key[i])] = ' ';
        //    }

        //    tempMatr = matr;
        //    string tempStr = input;
        //    for (int y = 0; y < (key.Length % 2 != 0 ? key.Length : key.Length - 1); y++)
        //    {
        //        int k = 0;
        //        for (int j = 0; j < matr[0].Length; j++)
        //        {
        //            for (int i = 0; i < matr.Count; i++)
        //            {
        //                if (k == input.Length) break;
        //                tempMatr[i][j] = tempStr[k];
        //                k++;
        //            }
        //        }

        //        for (int i = 0; i < matr.Count; i++)
        //        {
        //            outputMatr[i] = tempMatr[arrKey[i]];
        //        }

        //        tempStr = "";
        //        for (int j = 0; j < outputMatr[0].Length; j++)
        //        {
        //            for (int i = 0; i < matr.Count; i++)
        //            {
        //                if (outputMatr[i][j] == '\0') continue;
        //                tempStr += outputMatr[i][j];
        //            }
        //        }
        //    }
        //    Program.OutputText = tempStr;
        //}

        //private void CardanDecrypt()
        //{
        //    string input = Program.InputText.ToLower();
        //    char[,] key = new char[6, 10];
        //    string[] chunks = new string[input.Length / 60];
        //    for (int i = 0; i < chunks.Length; i++)
        //        chunks[i] = input.Substring(i * 60, 60);

        //    int k = 0;
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            key[i, j] = this.keyBox.Text[k];
        //            k++;
        //        }
        //    }

        //    foreach (string chunk in chunks)
        //    {

        //        int axis = 1;
        //        for (int y = 0; y < 4; y++)
        //        {
        //            for (int i = 0; i < key.GetLength(0); i++)
        //            {
        //                for (int j = 0; j < key.GetLength(1); j++)
        //                {
        //                    if (key[i, j] == '1')
        //                    {
        //                        Program.OutputText += chunk[i * key.GetLength(1) + j];
        //                    }
        //                }
        //            }

        //            if (axis == 1) key = ReverseArray(key);
        //            else key = ReverseColumnArray(key);
        //            axis = (axis + 1) % 2;
        //        }
        //    }
        //}

        private void VerticalDecrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/vertical.py " +
                $"{this.keyBox.Text} " +
                "0 " +
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

        private void CardanDecrypt()
        {
            string input = Program.InputText.ToLower();
            string formatedInput = "";

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r') continue;
                formatedInput += c;
            }

            string strCommandParameters =
                $"-u C:/Users/alexz/Desktop/Univer/2.2/Крипта/LabCrypt/Py/cardano.py " +
                $"{this.keyBox.Text} " +
                "0 " +
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

        private void FeistelDecrypt()
        {
            string input = Program.InputText;
            string strKey = this.keyBox.Text.ToLower();
            byte[] key = Encoding.Unicode.GetBytes(strKey);

            DESalg.Key = key;

            MemoryStream msDecrypt = new(encText);
            CryptoStream csDecrypt = new(
                msDecrypt,
                DESalg.CreateDecryptor(DESalg.Key, DESalg.IV),
                CryptoStreamMode.Read);
            byte[] fromEncrypt = new byte[Encoding.Unicode.GetBytes(input).Length];
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
            Program.OutputText = new UnicodeEncoding().GetString(fromEncrypt);
        }

        static char[,] ReverseArray(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int start = 0;
                int end = arr.GetLength(1) - 1;

                while (start < end)
                {
                    (arr[i, end], arr[i, start]) = (arr[i, start], arr[i, end]);

                    start++;
                    end--;
                }
            }

            return arr;
        }

        static char[,] ReverseColumnArray(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int start = 0;
                int end = arr.GetLength(0) - 1;

                while (start < end)
                {
                    arr = Swap(arr, start, i, end, i);

                    start++;
                    end--;
                }
            }

            return arr;
        }

        private static char[,] Swap(char[,] arr, int start, int i, int end, int j)
        {
            (arr[end, j], arr[start, i]) = (arr[start, i], arr[end, j]);
            return arr;
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Program.OutputText += e.Data;
        }
    }
}
