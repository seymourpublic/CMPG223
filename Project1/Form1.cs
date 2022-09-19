/*******************************************************************************************
Naledi Sandamela 31816339
Ntjie Magongwa 32374697
Ofentse Dibetso 31855016

*******************************************************************************************/







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace Project1
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        int size = 0;
        int[] prices = new int[800];
        string[] titles = new string[800];

        public void mail(string type, string email, string name, int[] prices, string[] titles)
        {
            try
            {
                //string emailto = "";
               // string name = "";
                int i = 0;
               /** if (txbName.Text != "") {
                    name = txbName.Text;
                }
                if (txbEmail.Text != "")
                {
                    emailto = txbEmail.Text;
                }*/
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("naledisandamela@gmail.com");
                msg.To.Add(email);
                msg.Subject = name + " Purchase Order";
                string message = type+"\t \n";
                message += "Good Day " + name + "\n" + "Thank you for taking interest in the Golden Circle store" 
                    + "\n" + "Please find the quote for your selected Textbooks below. " +
                    "When you are ready to make a purchase show this quote to any of our assistants and they will help you make your purchase";

                while (i <= size)
                {
                    message += "\n" +titles[i] + "\t R" + prices[i] + "\n";
                    i++;
                }
                message += "\n" + "Kind Regards" + "\n" + "Golden Circle";
                msg.Body = message;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "naledisandamela@gmail.com";
                ntcd.Password = "upgebfojdlloivcw";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Quotation sent succesfully");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnChild_Click(object sender, EventArgs e)
        {
            titles[size] = "Child and Adoloscent development";
            prices[size] = 305;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Rental rent = new Rental();
            rent.ShowDialog();
            this.Close();
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            titles[size] = "Abnormal Psychology";
            prices[size] = 802;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnPhys_Click(object sender, EventArgs e)
        {


            titles[size] = "Physical Geography";
            prices[size] = 500;
            size = size+1;
            MessageBox.Show("Item succesfully loaded to cart");


        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            titles[size] = "Elementary statistical methods";
            prices[size] = 450;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            titles[size] = "Insolvency Law casebook";
            prices[size] = 690;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void btnEco_Click(object sender, EventArgs e)
        {
            titles[size] = "Economics for south african students";
            prices[size] = 240;
            size = size + 1;
            MessageBox.Show("Item succesfully loaded to cart");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string type = " Purchase";
            string emailto = "";
            string name = "";
            if (txbName.Text != "") {
                 name = txbName.Text;
             }else{
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
            mail(type,emailto,name,prices,titles);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLog log = new AdminLog();
            log.ShowDialog();
            this.Close();
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
