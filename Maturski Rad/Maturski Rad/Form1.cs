using System;
using System.Windows.Forms;

namespace Maturski_Rad
{
    public partial class Form1 : Form
    {

        Matrix firstMatrix, secondMatrix;
        DataGridSettings firstMatrixSettings, secondMatrixSettings, resultMatrixSettings;

        #region Functions
        void Operation(Func<Matrix,Matrix> operation, Matrix matrix)
        {
            matrix = operation(matrix);

            resultMatrixSettings = new DataGridSettings(result, matrix.Rows, matrix.Columns);
            resultMatrixSettings.ConvertToDataGrid(matrix);
        }
        #endregion

        #region DataGridEvents
        private void first_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            firstMatrix.Values[row, column] = firstMatrixSettings.GetValue(row, column);
        }

        private void second_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            secondMatrix.Values[row, column] = secondMatrixSettings.GetValue(row, column);
        }
        #endregion

        #region Transpose, Determinant, Inverse, Adjugate
        private void firstTranspose_Click(object sender, EventArgs e)
        {
            Operation(MatrixOperation.Transpose, firstMatrix);
        }

        private void secondTranspose_Click(object sender, EventArgs e)
        {
            Operation(MatrixOperation.Transpose, secondMatrix);
        }

        private void firstAdjugate_Click(object sender, EventArgs e)
        {
            Operation(MatrixOperation.Adjugate, firstMatrix);
        }

        private void secondAdjugate_Click(object sender, EventArgs e)
        {
            Operation(MatrixOperation.Adjugate, secondMatrix);
        }

        private void firstInverse_Click(object sender, EventArgs e)
        {
            Operation(MatrixOperation.Inverse, firstMatrix);
        }

        private void secondInverse_Click(object sender, EventArgs e)
        {
            Operation(MatrixOperation.Inverse, secondMatrix);
        }

        private void firstDeterminant_Click(object sender, EventArgs e)
        {
            resultMatrixSettings = new DataGridSettings(result, 1, 1);
            resultMatrixSettings.SetValue(0, 0, MatrixOperation.Determinant(firstMatrix, firstMatrix.Rows));
        }

        private void secondDeterminant_Click(object sender, EventArgs e)
        {
            resultMatrixSettings = new DataGridSettings(result, 1, 1);
            resultMatrixSettings.SetValue(0, 0, MatrixOperation.Determinant(secondMatrix, secondMatrix.Rows));  
        }
        #endregion

        #region Addition,Product
        private void addition_Click(object sender, EventArgs e)
        {
            Matrix resultMatrix = firstMatrix + secondMatrix;

            resultMatrixSettings = new DataGridSettings(result, firstMatrix.Rows, firstMatrix.Columns);
            resultMatrixSettings.ConvertToDataGrid(resultMatrix);
        }

        private void firstProduct_Click(object sender, EventArgs e)
        {
            Matrix resultMatrix = firstMatrix * secondMatrix;

            resultMatrixSettings = new DataGridSettings(result, firstMatrix.Rows, secondMatrix.Columns);
            resultMatrixSettings.ConvertToDataGrid(resultMatrix);
        }

        private void secondProduct_Click(object sender, EventArgs e)
        {
            Matrix resultMatrix = secondMatrix * firstMatrix;

            resultMatrixSettings = new DataGridSettings(result, secondMatrix.Rows, firstMatrix.Columns);
            resultMatrixSettings.ConvertToDataGrid(resultMatrix);
        }

        private void firstRank_Click(object sender, EventArgs e)
        {
            int rank = MatrixOperation.Rank(firstMatrix);
            double[,] solution = { { Convert.ToDouble(rank) } };
            Matrix resultMatrix = new Matrix(1, 1, solution);

            resultMatrixSettings = new DataGridSettings(result, 1,1);
            resultMatrixSettings.ConvertToDataGrid(resultMatrix);

        }

        private void secondRank_Click(object sender, EventArgs e)
        {
            int rank = MatrixOperation.Rank(secondMatrix);
            double[,] solution = { { Convert.ToDouble(rank) } };
            Matrix resultMatrix = new Matrix(1, 1, solution);

            resultMatrixSettings = new DataGridSettings(result, 1, 1);
            resultMatrixSettings.ConvertToDataGrid(resultMatrix);
        }
        #endregion

        #region ChangeColumn, ChangeRow
        private void firstChangeColumn_Click(object sender, EventArgs e)
        {
            int firstColumn = (firstColumn1.Text == "") ? 0 : Convert.ToInt32(firstColumn1.Text);
            int secondColumn = (firstColumn2.Text == "") ? 0 : Convert.ToInt32(firstColumn2.Text);

            MatrixOperation.ChangeColumn(firstColumn, secondColumn, firstMatrix);
            firstMatrixSettings.ConvertToDataGrid(firstMatrix);
        }

        private void firstChangeRow_Click(object sender, EventArgs e)
        {
            int firstRow = (firstRow1.Text == "") ? 0 : Convert.ToInt32(firstRow1.Text);
            int secondRow = (firstRow2.Text == "") ? 0 : Convert.ToInt32(firstRow2.Text);

            MatrixOperation.ChangeRow(firstRow, secondRow, firstMatrix);
            firstMatrixSettings.ConvertToDataGrid(firstMatrix);
        }
        private void secondChangeColumn_Click(object sender, EventArgs e)
        {
            int firstColumn = (secondColumn1.Text == "") ? 0 : Convert.ToInt32(secondColumn1.Text);
            int secondColumn = (secondColumn2.Text == "") ? 0 : Convert.ToInt32(secondColumn2.Text);

            MatrixOperation.ChangeColumn(firstColumn, secondColumn, secondMatrix);
            secondMatrixSettings.ConvertToDataGrid(secondMatrix);
        }

        private void secondChangeRow_Click(object sender, EventArgs e)
        {
            int firstRow = (secondRow1.Text == "") ? 0 : Convert.ToInt32(secondRow1.Text);
            int secondRow = (secondRow2.Text == "") ? 0 : Convert.ToInt32(secondRow2.Text);

            MatrixOperation.ChangeRow(firstRow, secondRow, secondMatrix);
            secondMatrixSettings.ConvertToDataGrid(secondMatrix);
        }

        #endregion

        #region Buttons
        private void apply_Click(object sender, EventArgs e)
        {
            int firstRowsCount = (firstRows.Text == "") ? 0 : Convert.ToInt32(firstRows.Text);
            int firstColumnsCount = (firstColumns.Text == "") ? 0 : Convert.ToInt32(firstColumns.Text);

            int secondRowsCount = (secondRows.Text == "") ? 0 : Convert.ToInt32(secondRows.Text);
            int secondColumnsCount = (secondColumns.Text == "") ? 0 : Convert.ToInt32(secondColumns.Text);

            firstMatrixSettings.ChangeSize(firstRowsCount, firstColumnsCount);
            secondMatrixSettings.ChangeSize(secondRowsCount, secondColumnsCount);

            if(firstRowsCount != 0 && firstColumnsCount != 0)
            {
                if (firstRowsCount == firstColumnsCount)
                {
                    firstDeterminant.Enabled = true;
                    firstAdjugate.Enabled = true;
                    firstInverse.Enabled = true;
                }
     
                firstChangeColumn.Enabled = true;
                firstChangeRow.Enabled = true;
                firstTranspose.Enabled = true;

                firstColumn1.Enabled = true;
                firstColumn2.Enabled = true;
                firstRow1.Enabled = true;
                firstRow2.Enabled = true;

                firstRank.Enabled = true;

                firstMatrix = MatrixOperation.Zero(firstRowsCount, firstColumnsCount);
            }

            if(secondRowsCount != 0 && secondColumnsCount != 0)
            {
                if (secondRowsCount == secondColumnsCount)
                {
                    secondDeterminant.Enabled = true;
                    secondAdjugate.Enabled = true;
                    secondInverse.Enabled = true;
                }

                secondChangeColumn.Enabled = true;
                secondChangeRow.Enabled = true;
                secondTranspose.Enabled = true;

                secondColumn1.Enabled = true;
                secondColumn2.Enabled = true;
                secondRow1.Enabled = true;
                secondRow2.Enabled = true;

                secondRank.Enabled = true;

                secondMatrix = MatrixOperation.Zero(secondRowsCount, secondColumnsCount);
            }

            apply.Enabled = false;
            reset.Enabled = true;

            if (firstColumnsCount == 0 || secondColumnsCount == 0 || firstRowsCount == 0 || secondRowsCount == 0) return;


            if(firstColumnsCount == secondColumnsCount && firstRowsCount == secondRowsCount)
            {
                addition.Enabled = true;
            }

            if(firstColumnsCount == secondRowsCount)
            {
                firstProduct.Enabled = true;
            }

            if (secondColumnsCount == firstRowsCount)
            {
                secondProduct.Enabled = true;
            }

        }

        private void equations_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();  
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (firstMatrixSettings != null) firstMatrixSettings.Clear();
            if (secondMatrixSettings != null) secondMatrixSettings.Clear();
            if (resultMatrixSettings != null) resultMatrixSettings.Clear();

            firstMatrix = null;

            firstDeterminant.Enabled = false;
            firstAdjugate.Enabled = false;
            firstChangeColumn.Enabled = false;
            firstChangeRow.Enabled = false;
            firstInverse.Enabled = false;
            firstTranspose.Enabled = false;

            firstColumn1.Enabled = false;
            firstColumn2.Enabled = false;
            firstRow1.Enabled = false;
            firstRow2.Enabled = false;

            firstRank.Enabled = false;

            secondMatrix = null;

            secondDeterminant.Enabled = false;
            secondAdjugate.Enabled = false;
            secondChangeColumn.Enabled = false;
            secondChangeRow.Enabled = false;
            secondInverse.Enabled = false;
            secondTranspose.Enabled = false;

            secondColumn1.Enabled = false;
            secondColumn2.Enabled = false;
            secondRow1.Enabled = false;
            secondRow2.Enabled = false;

            firstProduct.Enabled = false;
            secondProduct.Enabled = false;
            addition.Enabled = false;

            secondRank.Enabled = false;

            apply.Enabled = true;
            reset.Enabled = false;

        }
        #endregion

        #region FormLoad
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstMatrixSettings = new DataGridSettings(first);
            secondMatrixSettings = new DataGridSettings(second);
        }
        #endregion

    }

}
