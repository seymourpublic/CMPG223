using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "admin" && txbPass.Text == "admin")
            {
                Textbook text = new Textbook();
                text.ShowDialog();
                this.Close();
            }

        }
    }
}
