
namespace Maturski_Rad
{
    partial class Form2
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
            this.coefficients = new System.Windows.Forms.DataGridView();
            this.results = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solutions = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.numberOfEquations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coefficients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutions)).BeginInit();
            this.SuspendLayout();
            // 
            // coefficients
            // 
            this.coefficients.AllowUserToAddRows = false;
            this.coefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coefficients.Location = new System.Drawing.Point(12, 40);
            this.coefficients.Name = "coefficients";
            this.coefficients.Size = new System.Drawing.Size(414, 370);
            this.coefficients.TabIndex = 0;
            this.coefficients.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.coefficients_CellValueChanged);
            // 
            // results
            // 
            this.results.AllowUserToAddRows = false;
            this.results.AllowUserToDeleteRows = false;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Location = new System.Drawing.Point(433, 40);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(154, 372);
            this.results.TabIndex = 1;
            this.results.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.results_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coefficients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right side";
            // 
            // solutions
            // 
            this.solutions.AllowUserToAddRows = false;
            this.solutions.AllowUserToDeleteRows = false;
            this.solutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solutions.Location = new System.Drawing.Point(633, 40);
            this.solutions.Name = "solutions";
            this.solutions.ReadOnly = true;
            this.solutions.Size = new System.Drawing.Size(155, 370);
            this.solutions.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Solutions";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(12, 416);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(97, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Enabled = false;
            this.solve.Location = new System.Drawing.Point(115, 416);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(189, 23);
            this.solve.TabIndex = 7;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(310, 416);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(116, 23);
            this.apply.TabIndex = 8;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // numberOfEquations
            // 
            this.numberOfEquations.Location = new System.Drawing.Point(556, 419);
            this.numberOfEquations.Name = "numberOfEquations";
            this.numberOfEquations.Size = new System.Drawing.Size(20, 20);
            this.numberOfEquations.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of equations";
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.Location = new System.Drawing.Point(665, 419);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(97, 23);
            this.check.TabIndex = 11;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberOfEquations);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solutions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.coefficients);
            this.Name = "Form2";
            this.Text = "Sistem linearnih jednačina";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coefficients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coefficients;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView solutions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.TextBox numberOfEquations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button check;
    }
}