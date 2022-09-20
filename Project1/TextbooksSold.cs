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
    public partial class TextbooksSoldTxb : Form
    {
        public int textbookSold { get; set; }
        public string studentNo { get; set; }
        public string Date { get; set; }
        
        public TextbooksSoldTxb()
        {
            InitializeComponent();
        }

        private void TextbooksSold_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'circleDataSet.Textbooks_sold' table. You can move, or remove it, as needed.
            this.textbooks_soldTableAdapter.Fill(this.circleDataSet.Textbooks_sold);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextbookSoldTxb_Click(object sender, EventArgs e)
        {
            this.textbooks_soldTableAdapter.InsertQuery(Convert.ToInt32(TextbookSldTxb.Text), Convert.ToInt32(TextbookNoTxb.Text), StudNoTxb.Text, DateTxb.Text);

        }

        private void TextbookSldTxb_TextChanged(object sender, EventArgs e)
        {
            textbookSold = Convert.ToInt32(TextbookSldTxb.Text);
        }

        private void StudNoTxb_TextChanged(object sender, EventArgs e)
        {
            studentNo = StudNoTxb.Text;
        }

        private void TextbookNoTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTxb_TextChanged(object sender, EventArgs e)
        {
            Date = DateTxb.Text;   
        }
    }
}
