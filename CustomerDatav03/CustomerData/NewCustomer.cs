using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData
{
    public partial class NewCustomer : Form
    {
        public Customer newCustomer { get; set; }

        public NewCustomer()
        {
            InitializeComponent();
           
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// gives the main window the Data for the new Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            int i;
            Int32.TryParse(tbBallance.Text, out i);
            int u;
            Int32.TryParse(tbCustomerNumber.Text, out u);
            newCustomer= new Customer(tbFirstName.Text,tbLastName.Text,tbEMail.Text,i,u);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
