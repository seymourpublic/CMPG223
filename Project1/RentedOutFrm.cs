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
    public partial class RentedOutFrm : Form
    {
        public string studentno { get; set; }
        public string status { get; set; }
        public string rentNo { get; set; }  

        public RentedOutFrm()
        {
            InitializeComponent();
        }

        private void RentedOutFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'circleDataSet.Rented_out' table. You can move, or remove it, as needed.
            this.rented_outTableAdapter.Fill(this.circleDataSet.Rented_out);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.rented_outTableAdapter.InsertQuery(Convert.ToInt32(RentTxb.Text), StudentNoTxb.Text, Convert.ToInt32(TextbookNoTxb.Text), StatusTxb.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {


            /*
            Textbook textbook = new Textbook();
            textbook.ShowDialog();
            this.Close();
            */
        }

        private void StudentNoTxb_TextChanged(object sender, EventArgs e)
        {
            studentno = StudentNoTxb.Text;

        }

        private void StatusTxb_TextChanged(object sender, EventArgs e)
        {
            status = StatusTxb.Text;

        }

        private void RentTxb_TextChanged(object sender, EventArgs e)
        {
            rentNo = RentTxb.Text;
        }
    }
}
