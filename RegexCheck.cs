using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class RegexCheck : Form
    {
        public RegexCheck()
        {
            InitializeComponent();
            lbl_error.Visible = false;
        }

        private void Regex_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void Regex_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            switch (cbx_options.Text)
            {
                case "Email":
                    if (ValidateEmail(txt_data.Text))
                    {
                        lbl_error.Visible = true;
                        lbl_error.ForeColor = Color.YellowGreen;
                        lbl_error.Text = "Valid email address";
                    }
                    else
                    {
                        lbl_error.Visible = true;
                        lbl_error.ForeColor = Color.IndianRed;
                        lbl_error.Text = "Invalid email address";
                    }
                    break;
                case "Date":
                    if (ValidateDate(txt_data.Text))
                    {
                        lbl_error.Visible = true;
                        lbl_error.ForeColor = Color.YellowGreen;
                        lbl_error.Text = "Valid date";
                    }
                    else
                    {
                        lbl_error.Visible = true;
                        lbl_error.ForeColor = Color.IndianRed;
                        lbl_error.Text = "Invalid date";
                    }
                    break;
                case "Identification":
                    if (ValidateIdentification(txt_data.Text))
                    {
                        lbl_error.Visible = true;
                        lbl_error.ForeColor = Color.YellowGreen;
                        lbl_error.Text = "Valid identification";
                    }
                    else
                    {
                        lbl_error.Visible = true;
                        lbl_error.ForeColor = Color.IndianRed;
                        lbl_error.Text = "Invalid identification";
                    }
                    break;
                default:
                    break;
            }
        }

        private bool ValidateEmail(string value)
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = Regex.IsMatch(value, regex, RegexOptions.IgnoreCase);
            return isValid;
        }

        private bool ValidateDate(string value)
        {
            var regex = @"^([0]?[0-9]|[1][0-2])[.\/-]([0]?[1-9]|[1|2][0-9]|[3][0|1])[.\/-]([0-9]{4}|[0-9]{2})$";
            bool isValid = Regex.IsMatch(value, regex, RegexOptions.IgnoreCase);
            return isValid;
        }

        private bool ValidateIdentification(string value)
        {
            var regex = "^([0-9]{9})|([0-9]{15})$";
            bool isValid = Regex.IsMatch(value, regex, RegexOptions.IgnoreCase);
            return isValid;
        }
    }
}
