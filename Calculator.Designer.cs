namespace Proyecto
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.lbl_expression_i = new System.Windows.Forms.Label();
            this.lbl_expression_ii = new System.Windows.Forms.Label();
            this.txt_expression_i = new System.Windows.Forms.TextBox();
            this.txt_expression_ii = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addition
            // 
            this.btn_addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_addition.FlatAppearance.BorderSize = 0;
            this.btn_addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addition.ForeColor = System.Drawing.Color.Snow;
            this.btn_addition.Location = new System.Drawing.Point(12, 218);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(106, 40);
            this.btn_addition.TabIndex = 3;
            this.btn_addition.Text = "Adittion";
            this.btn_addition.UseVisualStyleBackColor = false;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_subtraction.FlatAppearance.BorderSize = 0;
            this.btn_subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subtraction.ForeColor = System.Drawing.Color.Snow;
            this.btn_subtraction.Location = new System.Drawing.Point(124, 218);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(106, 40);
            this.btn_subtraction.TabIndex = 5;
            this.btn_subtraction.Text = "Subtraction";
            this.btn_subtraction.UseVisualStyleBackColor = false;
            this.btn_subtraction.Click += new System.EventHandler(this.btn_subtraction_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_multiplication.FlatAppearance.BorderSize = 0;
            this.btn_multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiplication.ForeColor = System.Drawing.Color.Snow;
            this.btn_multiplication.Location = new System.Drawing.Point(12, 172);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(106, 40);
            this.btn_multiplication.TabIndex = 6;
            this.btn_multiplication.Text = "Multiplication";
            this.btn_multiplication.UseVisualStyleBackColor = false;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_division.FlatAppearance.BorderSize = 0;
            this.btn_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_division.ForeColor = System.Drawing.Color.Snow;
            this.btn_division.Location = new System.Drawing.Point(124, 172);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(106, 40);
            this.btn_division.TabIndex = 8;
            this.btn_division.Text = "Division";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_clear_all.FlatAppearance.BorderSize = 0;
            this.btn_clear_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_all.ForeColor = System.Drawing.Color.Snow;
            this.btn_clear_all.Location = new System.Drawing.Point(12, 126);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(106, 40);
            this.btn_clear_all.TabIndex = 9;
            this.btn_clear_all.Text = "CE";
            this.btn_clear_all.UseVisualStyleBackColor = false;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // btn_result
            // 
            this.btn_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_result.FlatAppearance.BorderSize = 0;
            this.btn_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_result.ForeColor = System.Drawing.Color.Snow;
            this.btn_result.Location = new System.Drawing.Point(12, 264);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(218, 40);
            this.btn_result.TabIndex = 12;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = false;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(124, 126);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 40);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_main
            // 
            this.dgv_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_main.ColumnHeadersHeight = 20;
            this.dgv_main.Location = new System.Drawing.Point(247, 12);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersWidth = 35;
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.Size = new System.Drawing.Size(405, 292);
            this.dgv_main.TabIndex = 17;
            // 
            // lbl_expression_i
            // 
            this.lbl_expression_i.AutoSize = true;
            this.lbl_expression_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_expression_i.ForeColor = System.Drawing.Color.Snow;
            this.lbl_expression_i.Location = new System.Drawing.Point(12, 18);
            this.lbl_expression_i.Name = "lbl_expression_i";
            this.lbl_expression_i.Size = new System.Drawing.Size(90, 15);
            this.lbl_expression_i.TabIndex = 18;
            this.lbl_expression_i.Text = "Expression 1";
            // 
            // lbl_expression_ii
            // 
            this.lbl_expression_ii.AutoSize = true;
            this.lbl_expression_ii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_expression_ii.ForeColor = System.Drawing.Color.Snow;
            this.lbl_expression_ii.Location = new System.Drawing.Point(12, 71);
            this.lbl_expression_ii.Name = "lbl_expression_ii";
            this.lbl_expression_ii.Size = new System.Drawing.Size(90, 15);
            this.lbl_expression_ii.TabIndex = 19;
            this.lbl_expression_ii.Text = "Expression 2";
            // 
            // txt_expression_i
            // 
            this.txt_expression_i.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txt_expression_i.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_expression_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_expression_i.ForeColor = System.Drawing.Color.Snow;
            this.txt_expression_i.Location = new System.Drawing.Point(124, 18);
            this.txt_expression_i.Name = "txt_expression_i";
            this.txt_expression_i.Size = new System.Drawing.Size(106, 19);
            this.txt_expression_i.TabIndex = 20;
            this.txt_expression_i.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_expression_ii
            // 
            this.txt_expression_ii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txt_expression_ii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_expression_ii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_expression_ii.ForeColor = System.Drawing.Color.Snow;
            this.txt_expression_ii.Location = new System.Drawing.Point(124, 68);
            this.txt_expression_ii.Name = "txt_expression_ii";
            this.txt_expression_ii.Size = new System.Drawing.Size(106, 19);
            this.txt_expression_ii.TabIndex = 21;
            this.txt_expression_ii.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(664, 316);
            this.Controls.Add(this.txt_expression_ii);
            this.Controls.Add(this.txt_expression_i);
            this.Controls.Add(this.lbl_expression_ii);
            this.Controls.Add(this.lbl_expression_i);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn_addition);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 355);
            this.MinimumSize = new System.Drawing.Size(680, 355);
            this.Name = "Calculator";
            this.Opacity = 0.98D;
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_Closing);
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_addition;
        private Button btn_subtraction;
        private Button btn_multiplication;
        private Button btn_clear_all;
        private Button btn_result;
        private Button btn_division;
        private Button btn_delete;
        private DataGridView dgv_main;
        private Label lbl_expression_i;
        private Label lbl_expression_ii;
        private TextBox txt_expression_i;
        private TextBox txt_expression_ii;
    }
}