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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
            
        }
        int size = 0;
        int[] prices = new int [800];
        string[] titles = new string[800];

        private void btnBuy_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string type = " Rent";
            string emailto = "";
            string name = "";
            if (txbName.Text != "")
            {
                name = txbName.Text;
            }
            else
            {
                MessageBox.Show("Please enter your name");
            }
            if (txbEmail.Text != "")
            {
                emailto = txbEmail.Text;
            }
            else
            {
                MessageBox.Show("Please enter your email");
            }
            
            frmHome home = new frmHome();
            home.mail(type, emailto, name, prices, titles);

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titles[size] = "Biology A Global Approach";
            prices[size] = 50;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            titles[size] = "Statuatory Interpretation";
            prices[size] = 80;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            titles[size] = "Human resource management in south africa";
            prices[size] = 60;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            titles[size] = "Introduction to business management";
            prices[size] = 30;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnFut_Click(object sender, EventArgs e)
        {
            titles[size] = "Business management of the future";
            prices[size] = 20;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            titles[size] = "Database systems";
            prices[size] = 30;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
