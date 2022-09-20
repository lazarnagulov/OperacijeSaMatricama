
namespace Maturski_Rad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.first = new System.Windows.Forms.DataGridView();
            this.second = new System.Windows.Forms.DataGridView();
            this.result = new System.Windows.Forms.DataGridView();
            this.firstRows = new System.Windows.Forms.TextBox();
            this.firstColumns = new System.Windows.Forms.TextBox();
            this.secondRows = new System.Windows.Forms.TextBox();
            this.secondColumns = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.firstDeterminant = new System.Windows.Forms.Button();
            this.secondDeterminant = new System.Windows.Forms.Button();
            this.firstTranspose = new System.Windows.Forms.Button();
            this.secondTranspose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstAdjugate = new System.Windows.Forms.Button();
            this.secondAdjugate = new System.Windows.Forms.Button();
            this.firstInverse = new System.Windows.Forms.Button();
            this.secondInverse = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.firstProduct = new System.Windows.Forms.Button();
            this.secondProduct = new System.Windows.Forms.Button();
            this.firstChangeColumn = new System.Windows.Forms.Button();
            this.firstColumn1 = new System.Windows.Forms.TextBox();
            this.firstColumn2 = new System.Windows.Forms.TextBox();
            this.firstChangeRow = new System.Windows.Forms.Button();
            this.firstRow1 = new System.Windows.Forms.TextBox();
            this.firstRow2 = new System.Windows.Forms.TextBox();
            this.secondRow2 = new System.Windows.Forms.TextBox();
            this.secondRow1 = new System.Windows.Forms.TextBox();
            this.secondChangeRow = new System.Windows.Forms.Button();
            this.secondColumn2 = new System.Windows.Forms.TextBox();
            this.secondColumn1 = new System.Windows.Forms.TextBox();
            this.secondChangeColumn = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.equations = new System.Windows.Forms.Button();
            this.firstRank = new System.Windows.Forms.Button();
            this.secondRank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.AllowUserToAddRows = false;
            this.first.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.first.Location = new System.Drawing.Point(15, 25);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(438, 270);
            this.first.TabIndex = 5;
            this.first.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.first_CellValueChanged);
            // 
            // second
            // 
            this.second.AllowUserToAddRows = false;
            this.second.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.second.Location = new System.Drawing.Point(12, 363);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(438, 270);
            this.second.TabIndex = 6;
            this.second.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.second_CellValueChanged);
            // 
            // result
            // 
            this.result.AllowUserToAddRows = false;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.Location = new System.Drawing.Point(987, 90);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(454, 293);
            this.result.TabIndex = 7;
            // 
            // firstRows
            // 
            this.firstRows.Location = new System.Drawing.Point(504, 35);
            this.firstRows.Name = "firstRows";
            this.firstRows.Size = new System.Drawing.Size(23, 20);
            this.firstRows.TabIndex = 8;
            // 
            // firstColumns
            // 
            this.firstColumns.Location = new System.Drawing.Point(504, 61);
            this.firstColumns.Name = "firstColumns";
            this.firstColumns.Size = new System.Drawing.Size(23, 20);
            this.firstColumns.TabIndex = 9;
            // 
            // secondRows
            // 
            this.secondRows.Location = new System.Drawing.Point(504, 363);
            this.secondRows.Name = "secondRows";
            this.secondRows.Size = new System.Drawing.Size(23, 20);
            this.secondRows.TabIndex = 10;
            // 
            // secondColumns
            // 
            this.secondColumns.Location = new System.Drawing.Point(504, 389);
            this.secondColumns.Name = "secondColumns";
            this.secondColumns.Size = new System.Drawing.Size(23, 20);
            this.secondColumns.TabIndex = 11;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(15, 318);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(109, 23);
            this.apply.TabIndex = 12;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // firstDeterminant
            // 
            this.firstDeterminant.Enabled = false;
            this.firstDeterminant.Location = new System.Drawing.Point(504, 87);
            this.firstDeterminant.Name = "firstDeterminant";
            this.firstDeterminant.Size = new System.Drawing.Size(224, 23);
            this.firstDeterminant.TabIndex = 13;
            this.firstDeterminant.Text = "Determinant";
            this.firstDeterminant.UseVisualStyleBackColor = true;
            this.firstDeterminant.Click += new System.EventHandler(this.firstDeterminant_Click);
            // 
            // secondDeterminant
            // 
            this.secondDeterminant.Enabled = false;
            this.secondDeterminant.Location = new System.Drawing.Point(504, 415);
            this.secondDeterminant.Name = "secondDeterminant";
            this.secondDeterminant.Size = new System.Drawing.Size(224, 23);
            this.secondDeterminant.TabIndex = 14;
            this.secondDeterminant.Text = "Determinant";
            this.secondDeterminant.UseVisualStyleBackColor = true;
            this.secondDeterminant.Click += new System.EventHandler(this.secondDeterminant_Click);
            // 
            // firstTranspose
            // 
            this.firstTranspose.Enabled = false;
            this.firstTranspose.Location = new System.Drawing.Point(504, 116);
            this.firstTranspose.Name = "firstTranspose";
            this.firstTranspose.Size = new System.Drawing.Size(224, 23);
            this.firstTranspose.TabIndex = 15;
            this.firstTranspose.Text = "Transpose";
            this.firstTranspose.UseVisualStyleBackColor = true;
            this.firstTranspose.Click += new System.EventHandler(this.firstTranspose_Click);
            // 
            // secondTranspose
            // 
            this.secondTranspose.Enabled = false;
            this.secondTranspose.Location = new System.Drawing.Point(504, 444);
            this.secondTranspose.Name = "secondTranspose";
            this.secondTranspose.Size = new System.Drawing.Size(224, 23);
            this.secondTranspose.TabIndex = 16;
            this.secondTranspose.Text = "Transpose";
            this.secondTranspose.UseVisualStyleBackColor = true;
            this.secondTranspose.Click += new System.EventHandler(this.secondTranspose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Columns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Columns";
            // 
            // firstAdjugate
            // 
            this.firstAdjugate.Enabled = false;
            this.firstAdjugate.Location = new System.Drawing.Point(504, 145);
            this.firstAdjugate.Name = "firstAdjugate";
            this.firstAdjugate.Size = new System.Drawing.Size(224, 23);
            this.firstAdjugate.TabIndex = 21;
            this.firstAdjugate.Text = "Adjugate";
            this.firstAdjugate.UseVisualStyleBackColor = true;
            this.firstAdjugate.Click += new System.EventHandler(this.firstAdjugate_Click);
            // 
            // secondAdjugate
            // 
            this.secondAdjugate.Enabled = false;
            this.secondAdjugate.Location = new System.Drawing.Point(504, 473);
            this.secondAdjugate.Name = "secondAdjugate";
            this.secondAdjugate.Size = new System.Drawing.Size(224, 23);
            this.secondAdjugate.TabIndex = 22;
            this.secondAdjugate.Text = "Adjugate";
            this.secondAdjugate.UseVisualStyleBackColor = true;
            this.secondAdjugate.Click += new System.EventHandler(this.secondAdjugate_Click);
            // 
            // firstInverse
            // 
            this.firstInverse.Enabled = false;
            this.firstInverse.Location = new System.Drawing.Point(504, 174);
            this.firstInverse.Name = "firstInverse";
            this.firstInverse.Size = new System.Drawing.Size(224, 23);
            this.firstInverse.TabIndex = 24;
            this.firstInverse.Text = "Inverse";
            this.firstInverse.UseVisualStyleBackColor = true;
            this.firstInverse.Click += new System.EventHandler(this.firstInverse_Click);
            // 
            // secondInverse
            // 
            this.secondInverse.Enabled = false;
            this.secondInverse.Location = new System.Drawing.Point(504, 502);
            this.secondInverse.Name = "secondInverse";
            this.secondInverse.Size = new System.Drawing.Size(224, 23);
            this.secondInverse.TabIndex = 25;
            this.secondInverse.Text = "Inverse";
            this.secondInverse.UseVisualStyleBackColor = true;
            this.secondInverse.Click += new System.EventHandler(this.secondInverse_Click);
            // 
            // addition
            // 
            this.addition.Enabled = false;
            this.addition.Location = new System.Drawing.Point(987, 54);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(224, 23);
            this.addition.TabIndex = 26;
            this.addition.Text = "A + B";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // firstProduct
            // 
            this.firstProduct.Enabled = false;
            this.firstProduct.Location = new System.Drawing.Point(1088, 25);
            this.firstProduct.Name = "firstProduct";
            this.firstProduct.Size = new System.Drawing.Size(224, 23);
            this.firstProduct.TabIndex = 27;
            this.firstProduct.Text = "A * B";
            this.firstProduct.UseVisualStyleBackColor = true;
            this.firstProduct.Click += new System.EventHandler(this.firstProduct_Click);
            // 
            // secondProduct
            // 
            this.secondProduct.Enabled = false;
            this.secondProduct.Location = new System.Drawing.Point(1217, 54);
            this.secondProduct.Name = "secondProduct";
            this.secondProduct.Size = new System.Drawing.Size(224, 23);
            this.secondProduct.TabIndex = 28;
            this.secondProduct.Text = "B * A";
            this.secondProduct.UseVisualStyleBackColor = true;
            this.secondProduct.Click += new System.EventHandler(this.secondProduct_Click);
            // 
            // firstChangeColumn
            // 
            this.firstChangeColumn.Enabled = false;
            this.firstChangeColumn.Location = new System.Drawing.Point(504, 203);
            this.firstChangeColumn.Name = "firstChangeColumn";
            this.firstChangeColumn.Size = new System.Drawing.Size(224, 23);
            this.firstChangeColumn.TabIndex = 29;
            this.firstChangeColumn.Text = "Change Column";
            this.firstChangeColumn.UseVisualStyleBackColor = true;
            this.firstChangeColumn.Click += new System.EventHandler(this.firstChangeColumn_Click);
            // 
            // firstColumn1
            // 
            this.firstColumn1.Enabled = false;
            this.firstColumn1.Location = new System.Drawing.Point(734, 206);
            this.firstColumn1.Name = "firstColumn1";
            this.firstColumn1.Size = new System.Drawing.Size(23, 20);
            this.firstColumn1.TabIndex = 30;
            // 
            // firstColumn2
            // 
            this.firstColumn2.Enabled = false;
            this.firstColumn2.Location = new System.Drawing.Point(763, 206);
            this.firstColumn2.Name = "firstColumn2";
            this.firstColumn2.Size = new System.Drawing.Size(23, 20);
            this.firstColumn2.TabIndex = 31;
            // 
            // firstChangeRow
            // 
            this.firstChangeRow.Enabled = false;
            this.firstChangeRow.Location = new System.Drawing.Point(504, 232);
            this.firstChangeRow.Name = "firstChangeRow";
            this.firstChangeRow.Size = new System.Drawing.Size(224, 23);
            this.firstChangeRow.TabIndex = 32;
            this.firstChangeRow.Text = "Change Column";
            this.firstChangeRow.UseVisualStyleBackColor = true;
            this.firstChangeRow.Click += new System.EventHandler(this.firstChangeRow_Click);
            // 
            // firstRow1
            // 
            this.firstRow1.Enabled = false;
            this.firstRow1.Location = new System.Drawing.Point(734, 235);
            this.firstRow1.Name = "firstRow1";
            this.firstRow1.Size = new System.Drawing.Size(23, 20);
            this.firstRow1.TabIndex = 33;
            // 
            // firstRow2
            // 
            this.firstRow2.Enabled = false;
            this.firstRow2.Location = new System.Drawing.Point(763, 235);
            this.firstRow2.Name = "firstRow2";
            this.firstRow2.Size = new System.Drawing.Size(23, 20);
            this.firstRow2.TabIndex = 34;
            // 
            // secondRow2
            // 
            this.secondRow2.Enabled = false;
            this.secondRow2.Location = new System.Drawing.Point(763, 563);
            this.secondRow2.Name = "secondRow2";
            this.secondRow2.Size = new System.Drawing.Size(23, 20);
            this.secondRow2.TabIndex = 40;
            // 
            // secondRow1
            // 
            this.secondRow1.Enabled = false;
            this.secondRow1.Location = new System.Drawing.Point(734, 563);
            this.secondRow1.Name = "secondRow1";
            this.secondRow1.Size = new System.Drawing.Size(23, 20);
            this.secondRow1.TabIndex = 39;
            // 
            // secondChangeRow
            // 
            this.secondChangeRow.Enabled = false;
            this.secondChangeRow.Location = new System.Drawing.Point(504, 560);
            this.secondChangeRow.Name = "secondChangeRow";
            this.secondChangeRow.Size = new System.Drawing.Size(224, 23);
            this.secondChangeRow.TabIndex = 38;
            this.secondChangeRow.Text = "Change Row";
            this.secondChangeRow.UseVisualStyleBackColor = true;
            this.secondChangeRow.Click += new System.EventHandler(this.secondChangeRow_Click);
            // 
            // secondColumn2
            // 
            this.secondColumn2.Enabled = false;
            this.secondColumn2.Location = new System.Drawing.Point(763, 534);
            this.secondColumn2.Name = "secondColumn2";
            this.secondColumn2.Size = new System.Drawing.Size(23, 20);
            this.secondColumn2.TabIndex = 37;
            // 
            // secondColumn1
            // 
            this.secondColumn1.Enabled = false;
            this.secondColumn1.Location = new System.Drawing.Point(734, 534);
            this.secondColumn1.Name = "secondColumn1";
            this.secondColumn1.Size = new System.Drawing.Size(23, 20);
            this.secondColumn1.TabIndex = 36;
            // 
            // secondChangeColumn
            // 
            this.secondChangeColumn.Enabled = false;
            this.secondChangeColumn.Location = new System.Drawing.Point(504, 531);
            this.secondChangeColumn.Name = "secondChangeColumn";
            this.secondChangeColumn.Size = new System.Drawing.Size(224, 23);
            this.secondChangeColumn.TabIndex = 35;
            this.secondChangeColumn.Text = "Change Column";
            this.secondChangeColumn.UseVisualStyleBackColor = true;
            this.secondChangeColumn.Click += new System.EventHandler(this.secondChangeColumn_Click);
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(130, 318);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(109, 23);
            this.reset.TabIndex = 41;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // equations
            // 
            this.equations.Location = new System.Drawing.Point(1191, 580);
            this.equations.Name = "equations";
            this.equations.Size = new System.Drawing.Size(254, 53);
            this.equations.TabIndex = 42;
            this.equations.Text = "System of equations";
            this.equations.UseVisualStyleBackColor = true;
            this.equations.Click += new System.EventHandler(this.equations_Click);
            // 
            // firstRank
            // 
            this.firstRank.Enabled = false;
            this.firstRank.Location = new System.Drawing.Point(504, 261);
            this.firstRank.Name = "firstRank";
            this.firstRank.Size = new System.Drawing.Size(224, 23);
            this.firstRank.TabIndex = 43;
            this.firstRank.Text = "Rank";
            this.firstRank.UseVisualStyleBackColor = true;
            this.firstRank.Click += new System.EventHandler(this.firstRank_Click);
            // 
            // secondRank
            // 
            this.secondRank.Enabled = false;
            this.secondRank.Location = new System.Drawing.Point(504, 589);
            this.secondRank.Name = "secondRank";
            this.secondRank.Size = new System.Drawing.Size(224, 23);
            this.secondRank.TabIndex = 44;
            this.secondRank.Text = "Rank";
            this.secondRank.UseVisualStyleBackColor = true;
            this.secondRank.Click += new System.EventHandler(this.secondRank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 645);
            this.Controls.Add(this.secondRank);
            this.Controls.Add(this.firstRank);
            this.Controls.Add(this.equations);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.secondRow2);
            this.Controls.Add(this.secondRow1);
            this.Controls.Add(this.secondChangeRow);
            this.Controls.Add(this.secondColumn2);
            this.Controls.Add(this.secondColumn1);
            this.Controls.Add(this.secondChangeColumn);
            this.Controls.Add(this.firstRow2);
            this.Controls.Add(this.firstRow1);
            this.Controls.Add(this.firstChangeRow);
            this.Controls.Add(this.firstColumn2);
            this.Controls.Add(this.firstColumn1);
            this.Controls.Add(this.firstChangeColumn);
            this.Controls.Add(this.secondProduct);
            this.Controls.Add(this.firstProduct);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.secondInverse);
            this.Controls.Add(this.firstInverse);
            this.Controls.Add(this.secondAdjugate);
            this.Controls.Add(this.firstAdjugate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondTranspose);
            this.Controls.Add(this.firstTranspose);
            this.Controls.Add(this.secondDeterminant);
            this.Controls.Add(this.firstDeterminant);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.secondColumns);
            this.Controls.Add(this.secondRows);
            this.Controls.Add(this.firstColumns);
            this.Controls.Add(this.firstRows);
            this.Controls.Add(this.result);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Name = "Form1";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView first;
        private System.Windows.Forms.DataGridView second;
        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.TextBox firstRows;
        private System.Windows.Forms.TextBox firstColumns;
        private System.Windows.Forms.TextBox secondRows;
        private System.Windows.Forms.TextBox secondColumns;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button firstDeterminant;
        private System.Windows.Forms.Button secondDeterminant;
        private System.Windows.Forms.Button firstTranspose;
        private System.Windows.Forms.Button secondTranspose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button firstAdjugate;
        private System.Windows.Forms.Button secondAdjugate;
        private System.Windows.Forms.Button firstInverse;
        private System.Windows.Forms.Button secondInverse;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button firstProduct;
        private System.Windows.Forms.Button secondProduct;
        private System.Windows.Forms.Button firstChangeColumn;
        private System.Windows.Forms.TextBox firstColumn1;
        private System.Windows.Forms.TextBox firstColumn2;
        private System.Windows.Forms.Button firstChangeRow;
        private System.Windows.Forms.TextBox firstRow1;
        private System.Windows.Forms.TextBox firstRow2;
        private System.Windows.Forms.TextBox secondRow2;
        private System.Windows.Forms.TextBox secondRow1;
        private System.Windows.Forms.Button secondChangeRow;
        private System.Windows.Forms.TextBox secondColumn2;
        private System.Windows.Forms.TextBox secondColumn1;
        private System.Windows.Forms.Button secondChangeColumn;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button equations;
        private System.Windows.Forms.Button firstRank;
        private System.Windows.Forms.Button secondRank;
    }
}

