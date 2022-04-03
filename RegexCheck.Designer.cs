namespace Proyecto
{
    partial class RegexCheck
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
            this.lbl_options = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.cbx_options = new System.Windows.Forms.ComboBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_options
            // 
            this.lbl_options.AutoSize = true;
            this.lbl_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_options.ForeColor = System.Drawing.Color.Snow;
            this.lbl_options.Location = new System.Drawing.Point(74, 49);
            this.lbl_options.Name = "lbl_options";
            this.lbl_options.Size = new System.Drawing.Size(60, 16);
            this.lbl_options.TabIndex = 1;
            this.lbl_options.Text = "Options";
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_data.ForeColor = System.Drawing.Color.Snow;
            this.txt_data.Location = new System.Drawing.Point(74, 131);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(250, 15);
            this.txt_data.TabIndex = 2;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_data.ForeColor = System.Drawing.Color.Snow;
            this.lbl_data.Location = new System.Drawing.Point(74, 108);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(40, 16);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Text = "Data";
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_check.ForeColor = System.Drawing.Color.Snow;
            this.btn_check.Location = new System.Drawing.Point(162, 180);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 30);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // cbx_options
            // 
            this.cbx_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.cbx_options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbx_options.ForeColor = System.Drawing.Color.Snow;
            this.cbx_options.FormattingEnabled = true;
            this.cbx_options.Items.AddRange(new object[] {
            "Email",
            "Date",
            "Identification"});
            this.cbx_options.Location = new System.Drawing.Point(74, 68);
            this.cbx_options.Name = "cbx_options";
            this.cbx_options.Size = new System.Drawing.Size(250, 24);
            this.cbx_options.TabIndex = 5;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_error.Location = new System.Drawing.Point(76, 149);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(47, 15);
            this.lbl_error.TabIndex = 6;
            this.lbl_error.Text = "label1";
            // 
            // RegexCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(401, 231);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.cbx_options);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.lbl_options);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 270);
            this.MinimumSize = new System.Drawing.Size(417, 270);
            this.Name = "RegexCheck";
            this.Text = "Regex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Regex_FormClosing);
            this.Load += new System.EventHandler(this.Regex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_options;
        private TextBox txt_data;
        private Label lbl_data;
        private Button btn_check;
        private ComboBox cbx_options;
        private Label lbl_error;
    }
}