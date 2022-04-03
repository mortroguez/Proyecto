using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {

            var calculator = new Calculator();
            // I used this on child's constructor to control
            // parent status
            calculator.Show(this);
        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/mortroguez",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}
