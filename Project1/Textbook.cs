using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Whenever you want to comment something use exclamtion mark
namespace Project1
{
    public partial class Textbook : Form
    {
        public Textbook()
        {
            InitializeComponent();
        }

        private void textbookBindingNavigatorsNavigatorsSaveItem_Click(object sender, EventArgs e)
        { this.Validate();
            this.textbooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.circleDataSet);
        }
        private void Textbook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'circleDataSet1.Textbooks' table. You can move, or remove it, as needed.
            this.textbooksTableAdapter.Fill(this.circleDataSet.Textbooks);
            // TODO: This line of code loads data into the 'circleDataSet.Textbooks' table. You can move, or remove it, as needed.
          //  this.textbooksTableAdapter.Fill(this.circleDataSet.Textbooks);

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }
        //should not sell!!!!!!!!!!
        private void btnSell_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int code = Convert.ToInt32(textbook_NoTextBox.Text);
            int quant = Convert.ToInt32(quantityTextBox.Text);
          
            

            if (quant == 0)
            {
                MessageBox.Show("Textbook Is Sold Out");
            }
            else
            {
                quant--;
                // update database here, reduce the size of the quantity
                this.textbooksTableAdapter.UpdateQuery(nameTextBox.Text,
                module_codeTextBox.Text,
               quant,
                Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(textbook_NoTextBox.Text), nameTextBox.Text,
                module_codeTextBox.Text,
                Convert.ToInt32(quantityTextBox.Text),
                Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(textbook_NoTextBox.Text));
                MessageBox.Show("Textbook Sold succesfully");
            
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int code = Convert.ToInt32(textbook_NoTextBox.Text);
            //int quant = Convert.ToInt32(quantityTextBox.Text);
            //quant--;

            this.textbooksTableAdapter.DeleteQuery(Convert.ToInt32(textbook_NoTextBox.Text), nameTextBox.Text, 
                module_codeTextBox.Text,
                Convert.ToInt32(quantityTextBox.Text),
                Convert.ToInt32(priceTextBox.Text));
            // update database here, reduce the size of the quantity
            MessageBox.Show("Textbook deleted succsesfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.textbooksTableAdapter.SearchDesc(this.circleDataSet.Textbooks, SearchTxb.Text);
               
        }

        private void ShowAllItemsBtn_Click(object sender, EventArgs e)
        {
            this.textbooksTableAdapter.Fill(this.circleDataSet.Textbooks);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.textbooksTableAdapter.InsertQuery(txbAname.Text, txbAcode.Text, Convert.ToInt32(txbAquant.Text), Convert.ToInt32(txbAprice.Text));
           // this.textbooksTableAdapter.Fill(this.circleDataSet.Textbooks);
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsbText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmReturned returned = new frmReturned();   
            returned.ShowDialog();  
            this.Close();   
        }

        private void textbooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmClients clients = new frmClients();
            clients.ShowDialog();   
            this.Close();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RentedOutFrm rent= new RentedOutFrm();
            rent.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextbooksSoldTxb sale = new TextbooksSoldTxb();
            sale.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RentedOutFrm rentedOutFrm = new RentedOutFrm();
            String studentNo;
            String status;

            rentedOutFrm.rented_outTableAdapter.InsertQuery(Convert.ToInt32("rent number"), studentNo, Convert.ToInt32(textbook_NoTextBox.Text), status);
        }
    }
}
