using System;
using System.Windows.Forms;

namespace Maturski_Rad
{
    class Matrix
    {

        int _columns, _rows;
        double[,] _values;


        #region Constructors
        public Matrix(int rows, int columns, double[,] values)
        {
            _columns = columns;
            _values = values;
            _rows = rows;

            _values = new double[rows, columns];
            _values = values;
        }
        #endregion

        #region Properties
        public int Columns
        {
            get { return _columns; }
        }

        public int Rows
        {
            get { return _rows; }
        }

        public double[,] Values
        {
            get { return _values; }
        }
        #endregion

        #region Operators
        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            int firstRows = firstMatrix.Rows;
            int firstColumns = firstMatrix.Columns;

            int secondRows = secondMatrix.Rows;     
            int secondColumns = secondMatrix.Columns;

            Matrix result = MatrixOperation.Zero(firstRows, firstColumns);

          
            for (int i = 0; i < secondRows; i++)
            {
                for (int j = 0; j < secondColumns; j++)
                {
                    result.Values[i, j] = firstMatrix.Values[i, j] + secondMatrix.Values[i, j];
                }
            }
 
            return result; 
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            int firstRows = firstMatrix.Rows;
            int firstColumns = firstMatrix.Columns;

            int secondColumns = secondMatrix.Columns;

            Matrix result = MatrixOperation.Zero(firstRows, secondColumns);
            double temp;

              
            for (int i = 0; i < firstRows; i++)
            {
                for (int j = 0; j < secondColumns; j++)
                {
                    temp = 0;
                    for (int k = 0; k < firstColumns; k++)
                    {
                        temp += firstMatrix.Values[i, k] * secondMatrix.Values[k, j];
                    }
                    result.Values[i, j] = temp;
                }
            }
               
            return result;
        }

        public static Matrix operator *(double scalar, Matrix matrix)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            Matrix result = MatrixOperation.Zero(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result.Values[i, j] = scalar * matrix.Values[i, j];
                }
            }

            return result;
        }

        public static Matrix operator /(Matrix matrix, double scalar)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            Matrix result = MatrixOperation.Zero(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result.Values[i, j] = matrix.Values[i, j] / scalar;
                }
            }

            return result;
        }

        public static Matrix operator +(double scalar, Matrix matrix)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            Matrix result = MatrixOperation.Zero(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result.Values[i, j] = scalar + matrix.Values[i, j];
                }
            }

            return result;
        }
        #endregion
    }
}
