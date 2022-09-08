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
    public partial class TextbookRecieved : Form
    {
        public TextbookRecieved()
        {
            InitializeComponent();
        }

        private void TextbookRecieved_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'circleDataSet.Textbook_recieved' table. You can move, or remove it, as needed.
            this.textbook_recievedTableAdapter.Fill(this.circleDataSet.Textbook_recieved);

        }

        private void button1_Click(object sender, EventArgs e)
        {
         this.textbook_recievedTableAdapter.InsertQuery(Convert.ToInt32(TextbookRecievedTxb.Text), Convert.ToInt32(TextbookNoTxb.Text), DateTxb.Text, StatusTxb.Text);
        }
    }
}
