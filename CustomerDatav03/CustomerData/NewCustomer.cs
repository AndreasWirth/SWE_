using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData
{
    public partial class NewCustomer : Form
    {
        public Customer newCustomer { get; set; }
        public ResXResourceSet resxLanguage { get; set; }

        public NewCustomer()
        {
            InitializeComponent();
           
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            btnCancle.Text = resxLanguage.GetString("cancel");
            btAddCustomer.Text = resxLanguage.GetString("add");
            lableFirstName.Text = resxLanguage.GetString("firstName");
            labelLastName.Text = resxLanguage.GetString("lastName");
            labelBallance.Text = resxLanguage.GetString("ballance");
            labelCustomNumber.Text = resxLanguage.GetString("customerNumber");
            labelEMail.Text = resxLanguage.GetString("email");

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
