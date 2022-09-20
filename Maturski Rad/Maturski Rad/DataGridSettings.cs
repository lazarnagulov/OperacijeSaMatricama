using System;
using System.Windows.Forms;

namespace Maturski_Rad
{
    class DataGridSettings
    {
 
        public DataGridView instance;


        #region Constructors
        public DataGridSettings(DataGridView dataGridView)
        {
            instance = dataGridView;
        }

        public DataGridSettings(DataGridView dataGridView, int rows, int columns)
        {
            instance = dataGridView;
            ChangeSize(rows, columns);
        }
        #endregion

        #region Methods
        public void ChangeSize(int rows, int columns)
        {
            instance.RowCount = rows;
            instance.ColumnCount = columns;
        }

        public double GetValue(int row, int column)
        {
            return Convert.ToDouble(instance.Rows[row].Cells[column].Value);
        }

        public void SetValue(int row, int column, double value)
        {
            instance[column, row].Value = value;
        }

        public void Clear()
        {
            instance.DataSource = null;
            instance.Columns.Clear();
            instance.Rows.Clear();
        }

        public Matrix CovertToMatrix(Matrix matrix)
        {
            for(int i=0; i<instance.RowCount; i++)
            {
                for(int j=0; j<instance.ColumnCount; i++)
                {
                    matrix.Values[i, j] = GetValue(i, j);
                }
            }
            return matrix;
        }

        public void ConvertToDataGrid(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {            
                    SetValue(i, j, matrix.Values[i,j]);
                }
            }
        }
        #endregion
    }
}
