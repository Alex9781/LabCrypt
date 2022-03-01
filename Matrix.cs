namespace LabCrypt
{
    internal class Matrix
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int[,] Data { get; private set; }
        public bool IsSquare { get => this.Rows == this.Columns; }
        public int Dimension { get => IsSquare ? this.Rows : 0; }

        public Matrix(int i, int j)
        {
            Data = new int[i, j];
            Rows = i;
            Columns = j;
        }

        public Matrix(int[,] arr)
        {
            Data = arr;
            Rows = arr.GetLength(0);
            Columns = arr.GetLength(1);
        }

        public void Fill(string str)
        {
            string[] strArr = str.Split(" ");
            int[] intArr = new int[strArr.Length];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = Int32.Parse(strArr[i]);
            }

            int k = 0;
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    this.Data[i, j] = intArr[k];
                    k++;
                }
            }
        }

        public static Matrix Multiply(Matrix m1, Matrix m2)
        {
            Matrix res = new(m1.Rows, m2.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    float temp = 0;
                    for (int k = 0; k < m1.Rows; k++)
                    {
                        temp += m1.Data[i, k] * m2.Data[k, j];
                    }
                    res.Data[i, j] = (int)temp;
                }
            }

            return res;
        }

        public static Matrix Multiply(Matrix m1, Matrix m2, int devide)
        {
            devide = Math.Abs(devide);
            Matrix res = new(m1.Rows, m2.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    float temp = 0;
                    for (int k = 0; k < m1.Rows;    k++)
                    {                    
                        temp += m1.Data[i, k] / (float)devide * m2.Data[k, j];
                    }
                    res.Data[i, j] = (int)Math.Round(temp);
                }
            }

            return res;
        }

        public double Determinant()
        {
            if (!this.IsSquare)
            {
                throw new InvalidOperationException(
                    "determinant can be calculated only for square matrix");
            }
            if (this.Columns == 2)
            {
                return this.Data[0, 0] * this.Data[1, 1] - this.Data[0, 1] * this.Data[1, 0];
            }
            double result = 0;
            for (var j = 0; j < this.Columns; j++)
            {
                result += (j % 2 == 1 ? 1 : -1) * this.Data[1, j] *
                    this.CreateMatrixWithoutColumn(j).
                    CreateMatrixWithoutRow(1).Determinant();
            }
            return result;
        }

        public Matrix AdditionalMatrix()
        {
            Matrix res = new(this.Rows, this.Columns);

            for (var i = 0; i < this.Rows; i++)
            {
                for (var j = 0; j < this.Columns; j++)
                {
                    res.Data[i, j] = (int)Math.Pow((-1), (i + j)) * (int)this.CreateMatrixWithoutRow(i).CreateMatrixWithoutColumn(j).Determinant();
                }
            }

            return res;
        }

        public Matrix Transpose()
        {
            Matrix res = new(this.Rows, this.Columns);

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    res.Data[i, j] = this.Data[j, i];
                    res.Data[j, i] = this.Data[i, j];
                }
            }

            return res;
        }

        public Matrix Reverse()
        {
            Matrix res = new(this.Rows, this.Columns);

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    res.Data[i, j] = -this.Data[i, j];
                }
            }

            return res;
        }

        private Matrix CreateMatrixWithoutRow(int row)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new ArgumentException("invalid row index");
            }
            var result = new Matrix(this.Rows - 1, this.Columns);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    result.Data[i, j] = i < row ? this.Data[i, j] : this.Data[i + 1, j];
                }
            }
            return result;

        }

        private Matrix CreateMatrixWithoutColumn(int column)
        {
            if (column < 0 || column >= this.Columns)
            {
                throw new ArgumentException("invalid column index");
            }
            var result = new Matrix(this.Rows, this.Columns - 1);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    result.Data[i, j] = j < column ? this.Data[i, j] : this.Data[i, j + 1];
                }
            }

            return result;
        }
    }
}
