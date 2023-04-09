using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS
{
    public partial class BugAndFix_Version : Form
    {
        public BugAndFix_Version()
        {
            InitializeComponent();
        }

        private void BugVer_Button_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(false);
            loginForm.Show();
        }

        private void FixVer_Button_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(true);
            loginForm.Show();
        }
    }
}
