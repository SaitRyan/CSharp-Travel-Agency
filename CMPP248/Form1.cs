using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPP248
{
    public partial class frmMainTravel : Form
    {
        public frmMainTravel()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            frmPackages frm = new frmPackages();
            frm.Show();
        }
    }
}
