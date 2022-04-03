namespace Proyecto
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_Calculator = new System.Windows.Forms.Button();
            this.btn_regex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Calculator
            // 
            this.btn_Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_Calculator.FlatAppearance.BorderSize = 0;
            this.btn_Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculator.ForeColor = System.Drawing.Color.Snow;
            this.btn_Calculator.Location = new System.Drawing.Point(19, 19);
            this.btn_Calculator.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Calculator.Name = "btn_Calculator";
            this.btn_Calculator.Size = new System.Drawing.Size(100, 30);
            this.btn_Calculator.TabIndex = 0;
            this.btn_Calculator.Text = "Calculator";
            this.btn_Calculator.UseVisualStyleBackColor = false;
            this.btn_Calculator.Click += new System.EventHandler(this.btn_Calculator_Click);
            // 
            // btn_regex
            // 
            this.btn_regex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_regex.FlatAppearance.BorderSize = 0;
            this.btn_regex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_regex.ForeColor = System.Drawing.Color.Snow;
            this.btn_regex.Location = new System.Drawing.Point(139, 19);
            this.btn_regex.Margin = new System.Windows.Forms.Padding(10);
            this.btn_regex.Name = "btn_regex";
            this.btn_regex.Size = new System.Drawing.Size(100, 30);
            this.btn_regex.TabIndex = 1;
            this.btn_regex.Text = "Regex";
            this.btn_regex.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(82, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "version 1.0.0";
            // 
            // btn_git
            // 
            this.btn_git.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_git.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_git.BackgroundImage")));
            this.btn_git.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_git.FlatAppearance.BorderSize = 0;
            this.btn_git.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_git.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_git.ForeColor = System.Drawing.Color.Snow;
            this.btn_git.Location = new System.Drawing.Point(108, 85);
            this.btn_git.Margin = new System.Windows.Forms.Padding(10);
            this.btn_git.Name = "btn_git";
            this.btn_git.Size = new System.Drawing.Size(30, 30);
            this.btn_git.TabIndex = 3;
            this.btn_git.UseVisualStyleBackColor = false;
            this.btn_git.Click += new System.EventHandler(this.btn_git_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(257, 151);
            this.Controls.Add(this.btn_git);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculator);
            this.Controls.Add(this.btn_regex);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 190);
            this.MinimumSize = new System.Drawing.Size(273, 190);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Calculator;
        private Button btn_regex;
        private Label label1;
        private Button btn_git;
    }
}