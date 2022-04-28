using System.Diagnostics;

namespace LabCrypt
{
    #region Util
    public interface ICipher
    {
        public struct InputArgs
        {
            public bool isAlphFull;

            public string inputText;
            public string key;

            public string p;
            public string q;
            public string a;
            public string x;
            public string k;
            public string r;
            public string s;
        }

        public string Encrypt(InputArgs inputArgs);
        public string Decrypt(InputArgs inputArgs);
    }

    public interface IDSA
    {
        public struct InputArgs
        {
            public bool isAlphFull;

            public string inputText;
            public string key;

            public string p;
            public string q;
            public string a;
            public string x;
            public string k;
            public string r;
            public string s;
        }

        public string Sign(InputArgs inputArgs);
        public string Check(InputArgs inputArgs);
    }
    #endregion

    #region Lab1
    public class AtbashCipher : ICipher
    {
        private readonly string shortAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }
                output += alph[alph.Length - 1 - alph.IndexOf(c)];
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }

                output += alph[alph.Length - 1 - alph.IndexOf(c)];
            }
            return output;
        }

    }

    public class CaesarCipher : ICipher
    {
        private readonly string shortAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            if (!Int32.TryParse(inputArgs.key, out int key))
            {
                return "Key is not a number";
            }

            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }
                output += alph[(alph.IndexOf(c) + key) % alph.Length];
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            if (!Int32.TryParse(inputArgs.key, out int key))
            {
                return "Key is not a number";
            }

            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }
                output += alph[(alph.IndexOf(c) - key + alph.Length) % alph.Length];
            }

            return output;
        }
    }

    public class PolybiusCipher : ICipher
    {
        private readonly string shortAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            foreach (char c in inputArgs.inputText)
            {
                int letter = alph.IndexOf(c);
                output += (letter / 6 + 1).ToString() + (letter % 6 + 1).ToString() + " ";
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            string[] openCopy = inputArgs.inputText.Split(" ");
            int[] openCopyInt = new int[openCopy.Length];

            for (int i = 0; i < openCopy.Length - 1; i++)
            {
                _ = int.TryParse(openCopy[i], out openCopyInt[i]);
            }

            foreach (int c in openCopyInt)
            {
                if (c == 0) continue;
                if ((c / 10 * 6 - 1) - (6 - (c % 10)) == -1)
                {
                    output += ' ';
                    continue;
                }
                output += alph[(c / 10 * 6 - 1) - (6 - (c % 10))];
            }

            return output;
        }
    }
    #endregion

    #region Lab2
    public class TrithemiumCipher : ICipher
    {
        private readonly string shortAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            int i = 1;
            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }
                output += alph[(alph.IndexOf(c) + i - 1) % alph.Length];
                i++;
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            for (int j = 0; j < alph.Length - 1; j++)
            {
                output = "";
                int i = 1;
                foreach (char c in inputArgs.inputText)
                {
                    if (!alph.Contains(c))
                    {
                        output += c;
                        continue;
                    }
                    output += alph[(alph.IndexOf(c) + i - 1) % alph.Length];
                    i++;
                }
                inputArgs.inputText = output;
            }

            return output;
        }
    }

    public class BelazoCipher : ICipher
    {
        private readonly string shortAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            int i = 0;
            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }
                i %= inputArgs.key.Length;
                output += alph[(alph.IndexOf(c) + alph.IndexOf(inputArgs.key[i])) % alph.Length];
                i++;
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            int i = 0;
            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }
                i %= inputArgs.key.Length;
                output += alph[((alph.IndexOf(c) + alph.IndexOf(inputArgs.key[i]) * -1) + ((inputArgs.inputText.Length / alph.Length) * alph.Length)) % alph.Length];
                i++;
            }

            return output;
        }
    }

    public class VigenereCipher : ICipher
    {
        private readonly string shortAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            char key = inputArgs.key[0];
            int i = 0;
            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    i++;
                    continue;
                }
                output += alph[(alph.IndexOf(key) + alph.IndexOf(c)) % alph.Length];

                key = inputArgs.inputText[i].ToString().ToLower().ToCharArray()[0];
                i++;
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            foreach (char c in inputArgs.inputText)
            {
                if (!alph.Contains(c))
                {
                    output += c;
                    continue;
                }

                output += alph[(alph.IndexOf(c) - alph.IndexOf(inputArgs.key) + alph.Length) % alph.Length];
                inputArgs.key = output.Last().ToString();
            }

            return output;
        }
    }

    public class MagmaCipher : ICipher
    {
        private readonly int[,] sBlocks = {
                {12, 4, 6, 2, 10, 5, 11, 9, 14, 8, 13, 7, 0, 3, 15, 1 },
                {6, 8, 2, 3, 9, 10, 5, 12, 1, 14, 4, 7, 11, 13, 0, 15 },
                {11, 3, 5, 8, 2, 15, 10, 13, 14, 1, 7, 4, 12, 9, 6, 0 },
                {12, 8, 2, 1, 13, 4, 15, 6, 7, 0, 10, 5, 3, 14, 9, 11 },
                {7, 15, 5, 10, 8, 1, 6, 13, 0, 9, 3, 14, 11, 4, 2, 12 },
                {5, 13, 15, 6, 9, 2, 12, 10, 11, 7, 8, 1, 4, 3, 14, 0 },
                {8, 14, 2, 5, 6, 9, 1, 12, 15, 4, 11, 0, 13, 10, 3, 7 },
                {1, 7, 14, 13, 0, 5, 8, 3, 4, 15, 10, 6, 9, 12, 11, 2 } };

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string output = "";

            string[] input = inputArgs.inputText.Split(" ");
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

            foreach (var item in intList)
            {
                output += item + " ";
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            return Encrypt(inputArgs);
        }
    }
    #endregion

    #region Lab3
    public class MatrixCipher : ICipher
    {
        private readonly string shortAlph = "\0абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "\0абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            Matrix key = new(3, 3);
            key.Fill(inputArgs.key);

            int[] input = new int[inputArgs.inputText.Length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = alph.IndexOf(inputArgs.inputText[i].ToString().ToLower());
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
                    output += num.ToString() + " ";
                }
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            Matrix key = new(3, 3);
            key.Fill(inputArgs.key);
            int det = (int)key.Determinant();

            string[] sInput = inputArgs.inputText.Split(" ");
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
                    output += alph[(int)Math.Abs(num)];
                }
            }

            return output;
        }
    }

    public class PlayfairCipher : ICipher
    {
        private readonly string shortAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private readonly string fullAlph = "абвгдежзийклмнопрстуфхцчшщъыьэюя—,?. \n\r";

        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            string open = inputArgs.inputText;
            List<char[]> key = new(5);
            for (int i = 0; i < 5; i++) key.Add(new char[8]);
            List<char> inputKey = new(inputArgs.key);
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
                        if (b >= alphCopy.Count) continue; 
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
                        if (x0 == 7) x0 = 0;
                        else x0++;

                        if (x1 == 7) x1 = 0;
                        else x1++;
                    }

                }

                (y0, y1) = (y1, y0);
                output += key[y0][x0].ToString() + key[y1][x1].ToString();
            }

            return output;
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            string alph = inputArgs.isAlphFull ? fullAlph : shortAlph;
            string output = "";

            string open = inputArgs.inputText;
            List<char[]> key = new(5);
            for (int i = 0; i < 5; i++) key.Add(new char[8]);
            List<char> inputKey = new(inputArgs.key);
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
                output += key[y0][x0].ToString() + key[y1][x1].ToString();
            }

            return output;
        }
    } // Накожен кал, переделать
    #endregion

    #region Lab4
    public class VerticalCipher : ICipher
    {
        public string Encrypt(ICipher.InputArgs inputArgs)
        {
            throw new NotImplementedException();
        }

        public string Decrypt(ICipher.InputArgs inputArgs)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

}