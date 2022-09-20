using System;
using System.Windows.Forms;


namespace Maturski_Rad
{
    static class MatrixOperation
    {
        #region Debug, Error
        public static void DebugPrintMatrix(Matrix matrix)
        {
            string text = " ";
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    text += matrix.Values[i, j].ToString("0.##") + " ";
                }
                text += '\n';
            }
            MessageBox.Show(text);
        } 

        #endregion

        #region Identity, Zero
        public static Matrix Identity(int size)
        {
            Matrix identity = Zero(size);
            for (int i = 0; i < size; i++)
            {
                identity.Values[i, i] = 1;
            }
            return identity;
        }

        public static Matrix Zero(int size)
        {
            return new Matrix(size, size, new double[size, size]);
        }

        public static Matrix Zero(int rows, int columns)
        {
            return new Matrix(rows, columns, new double[rows, columns]);
        }
        #endregion

        #region Rank

        static void CopyMatrix(Matrix matrix, Matrix copy)
        {
            for(int i=0; i<matrix.Rows; i++)
            {
                for(int j=0; j<matrix.Columns; j++)
                {
                    copy.Values[i, j] = matrix.Values[i, j];
                }
            }
        }

        public static int Rank(Matrix matrix)
        {
            const double EPS = 1e-9;
            Matrix temporary = Zero(matrix.Rows, matrix.Columns);
            CopyMatrix(matrix, temporary);

            int rows = matrix.Rows;
            int columns = matrix.Columns;

            int result = 0;
            bool[] selected = new bool[rows];


            for (int i = 0; i < columns; i++)
            {
                int j;
                for (j = 0; j < rows; j++)
                {
                    if (!selected[j] && Math.Abs(temporary.Values[j,i]) > EPS)
                        break;
                }

                if (j != rows)
                {
                    result++;
                    selected[j] = true;
                    for (int p = i + 1; p < columns; p++)
                        temporary.Values[j,p] /= temporary.Values[j,i];

                    for (int k = 0; k < rows; k++)
                    {
                        if (k != j && Math.Abs(temporary.Values[k,i]) > EPS)
                        {
                            for (int p = i + 1; p < columns; p++)
                            {
                                temporary.Values[k, p] -= temporary.Values[j, p] * temporary.Values[k, i];
                            }
                        }
                    }
                }
            }
            return result;
        }
        #endregion

        #region Determinant

        public static Matrix GetMinorMatrix(Matrix matrix, int x, int y)
        {
            int size = matrix.Columns;
            Matrix result = Zero(size-1);
            int u = 0, w = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i != x && j != y)
                    {
                        result.Values[u, w] = matrix.Values[i, j];
                        w++;

                        if (w == size - 1)
                        {
                            w = 0;
                            u++;
                        }
                    }
                }
            }

            return result;

        }

        static void GetCofactor(Matrix matrix, Matrix result, int x, int y, int size)
        {
            int u = 0, w = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(i != x && j != y)
                    {
                        result.Values[u, w] = matrix.Values[i, j];
                        w++;

                        if(w == size - 1)
                        {
                            w = 0;
                            u++;
                        }
                    }
                }
            }

        }

        public static double Determinant(Matrix matrix, int size)
        {
            double result = 0;

            int sign = 1;
            Matrix cofactors = Zero(size);

            if(size == 1)
            {
                return matrix.Values[0, 0];
            }

            for(int i=0; i<size; i++)
            {
                GetCofactor(matrix, cofactors, 0, i, size);
                result += sign * matrix.Values[0, i] * Determinant(cofactors, size-1);
                sign = -sign;
            }
            return result;
 
        }
        #endregion

        #region Transpose
        public static Matrix Transpose(Matrix matrix)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            Matrix transpose = Zero(columns, rows);

            for(int i=0; i<columns; i++)
            {
                for(int j=0; j<rows; j++)
                {
                    transpose.Values[i, j] = matrix.Values[j, i];
                }
            }

            return transpose;
        }

        #endregion

        #region Adjugate
        public static Matrix Adjugate(Matrix matrix)
        {
            int size = matrix.Rows;

            Matrix result = Zero(size);
            Matrix cofactors = Zero(size);
       
            int sign = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sign = (((i + j) & 1) == 1) ? -1 : 1;
                    GetCofactor(matrix, cofactors, i, j, size);
                    result.Values[i, j] = sign * Determinant(cofactors, size - 1);
                }
            }

            return Transpose(result);
 
        }
        #endregion

        #region Inverse
        public static Matrix Inverse(Matrix matrix)
        {
           Matrix adjugate = Adjugate(matrix);
           double determinant = Determinant(matrix, matrix.Columns);

            if (determinant == 0) return Zero(1); 
           return adjugate / determinant;
        }
        #endregion

        #region Change Columns, Rows
        public static void ChangeColumn(int column1, int column2, Matrix matrix)
        {
            int rows = matrix.Rows;
            Matrix temporary = Zero(rows,2);

            try
            {

                for (int i = 0; i < rows; i++)
                {
                    temporary.Values[i, 0] = matrix.Values[i, column1];
                    temporary.Values[i, 1] = matrix.Values[i, column2];

                    matrix.Values[i, column1] = temporary.Values[i, 1];
                    matrix.Values[i, column2] = temporary.Values[i, 0];
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }

        }

        public static void ChangeRow(int row1, int row2, Matrix matrix)
        {
            int columns = matrix.Columns;
            Matrix temprorary = Zero(2, columns);
            try
            {

                for (int i = 0; i < columns; i++)
                {
                    temprorary.Values[0, i] = matrix.Values[row1, i];
                    temprorary.Values[1, i] = matrix.Values[row2, i];

                    matrix.Values[row1, i] = temprorary.Values[1, i];
                    matrix.Values[row2, i] = temprorary.Values[0, i];
                }
            }
            catch 
            {
                MessageBox.Show("Error!");
            }
        }
        #endregion

    }
}
