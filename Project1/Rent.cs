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
    public partial class frmRent : UserControl
    {
        public frmRent()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.ShowDialog();
        }
    }
}
