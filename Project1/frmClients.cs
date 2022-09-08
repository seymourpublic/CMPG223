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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }


       private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.circleDataSet);

        }
 
        private void frmClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'circleDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.circleDataSet.Clients);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            this.clientsTableAdapter.InsertQuery(Convert.ToInt32(StudentNoTxb.Text),
                NameTxb.Text, SurnameTxb.Text,
                CourseTxb.Text, Convert.ToInt32(CellNoTxb.Text),
                EmailTxb.Text);
   
        }

        private void CourseTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            this.clientsTableAdapter.DeleteQuery(Convert.ToInt32(StudentNoTxb.Text), 
               NameTxb.Text, SurnameTxb.Text, 
               CourseTxb.Text,
               Convert.ToInt32(CellNoTxb.Text),
               EmailTxb.Text);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                        
            this.clientsTableAdapter.SearchDesc(this.circleDataSet.Clients, Convert.ToInt32(txbSearch.Text));
        }

        private void ShowAllTxb_Click(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.circleDataSet.Clients);
        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
