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
    /// <summary>
    /// Forms for collecting the necessary Data to greate a new Customer
    /// </summary>
    public partial class NewCustomer : Form
    {
        public Customer AddCustomer { get; set; }
        private Company Company;
        private Dictionary<int, Customer> Customers;

        public NewCustomer(Company company)
        {
            InitializeComponent();
            this.Company = company;
            this.Customers = Company.GetCustomers();
        }
        
        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Generates the new Customer, and closes the Window
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
                    AddCustomer = new Customer(tbFirstName.Text, tbLastName.Text, tbEMail.Text, i, u);
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

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            bool stop = false;
            int ii = 0;
            if (Customers.Count == 0)
            {
                tbCustomerNumber.Text = ii.ToString();
            }
            else
            {
                do
                {
                    if (!Customers.ContainsKey(ii))
                    {
                        tbCustomerNumber.Text = ii.ToString();
                        stop = true;
                    }
                    if (ii > Customers.Keys.Max())
                    {
                        stop = true;
                        tbCustomerNumber.Text = (Customers.Keys.Max() + 1).ToString();
                    }
                    ii++;
                } while (stop == false);
            } 
        }
    }
}
