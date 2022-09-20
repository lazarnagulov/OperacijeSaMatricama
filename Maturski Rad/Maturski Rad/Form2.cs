using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maturski_Rad
{
    public partial class Form2 : Form
    {
        Matrix solutionMatrix, resultMatrix, coefficientMatrix;
        DataGridSettings solutionMatrixSettings, resultMatrixSettings, coefficientMatrixSettings;

        private void coefficients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            coefficientMatrix.Values[row, column] = coefficientMatrixSettings.GetValue(row, column);
        }

        private void results_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            resultMatrix.Values[row, column] = resultMatrixSettings.GetValue(row, column);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (solutionMatrixSettings != null) solutionMatrixSettings.Clear();
            if (resultMatrixSettings != null) resultMatrixSettings.Clear();
            if (coefficientMatrixSettings != null) coefficientMatrixSettings.Clear();

            resultMatrix = null;
            solutionMatrix = null;
            coefficientMatrix = null;

            apply.Enabled = true;
            check.Enabled = false;
            reset.Enabled = false;
        }

        private void check_Click(object sender, EventArgs e)
        {
            int rows = coefficientMatrix.Rows;
            int columns = coefficientMatrix.Columns + 1;

            Matrix extenedMatrix = MatrixOperation.Zero(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for(int j=0; j<columns; j++)
                {
                    if(j == columns - 1)
                    {
                        extenedMatrix.Values[i, j] = resultMatrix.Values[i, 0];
                    }
                    else
                    {
                        extenedMatrix.Values[i, j] = coefficientMatrix.Values[i, j];
                    }
                }
            }

            if (MatrixOperation.Rank(extenedMatrix) == MatrixOperation.Rank(coefficientMatrix))
            {
                MessageBox.Show("Possible");
            }
            else MessageBox.Show("Not possible");

        }

        private void solve_Click(object sender, EventArgs e)
        {
            if (resultMatrix.Rows == 1)
            {
                double[,] result = { { resultMatrix.Values[0, 0] / coefficientMatrix.Values[0, 0] } };
                solutionMatrix = new Matrix(1, 1, result);
            }
            else
            {
                Matrix inverse = MatrixOperation.Inverse(coefficientMatrix);
                solutionMatrix = inverse * resultMatrix;
            }
            solutionMatrixSettings.ChangeSize(solutionMatrix.Rows, 1);
            solutionMatrixSettings.ConvertToDataGrid(solutionMatrix);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (numberOfEquations.Text == "") return;
            int equations = Convert.ToInt32(numberOfEquations.Text);
            
            resultMatrixSettings.ChangeSize(equations, 1);
            coefficientMatrixSettings.ChangeSize(equations, equations);

            resultMatrix = MatrixOperation.Zero(equations, 1);
            solutionMatrix = MatrixOperation.Zero(equations, 1);
            coefficientMatrix = MatrixOperation.Zero(equations);


            apply.Enabled = false;
            check.Enabled = true;
            reset.Enabled = true;
            solve.Enabled = true;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            solutionMatrixSettings = new DataGridSettings(solutions);
            resultMatrixSettings = new DataGridSettings(results);
            coefficientMatrixSettings = new DataGridSettings(coefficients);
        }
    }
}
