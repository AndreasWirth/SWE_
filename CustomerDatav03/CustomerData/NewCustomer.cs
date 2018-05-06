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

            if (Customer.CheckEmail(tbEMail.Text))
            {
                if (tbFirstName.Text.Length > 2 && tbLastName.Text.Length > 2 && tbEMail.Text.Length > 5)
                {
                    int i;
                    Int32.TryParse(tbBallance.Text, out i);
                    int u;
                    Int32.TryParse(tbCustomerNumber.Text, out u);
                    newCustomer = new Customer(tbFirstName.Text, tbLastName.Text, tbEMail.Text, i, u);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("To less Input.");
                }
            }
            else
            {
                MessageBox.Show("Email Adress not valid!");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbEMail_TextChanged(object sender, EventArgs e)
        {
            if (!Customer.CheckEmail(tbEMail.Text))
            {
                errProvEmail.SetError(tbEMail,"Invalid Email");
            }
            else
            {
                errProvEmail.Clear();
            }
        }
    }
}
