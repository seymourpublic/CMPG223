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
    public partial class frmReturned : Form
    {
        public frmReturned()
        {
            InitializeComponent();
        }

        private void Returned_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'circleDataSet.Returned' table. You can move, or remove it, as needed.
            this.returnedTableAdapter.Fill(this.circleDataSet.Returned);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Textbook textbook = new Textbook(); 
            textbook.ShowDialog();
            this.Close();
        }
    }
}
