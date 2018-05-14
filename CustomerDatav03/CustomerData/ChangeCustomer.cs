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
    public partial class ChangeCustomer : Form
    {
        public Customer AktCustomer { get; set; }
        private Dictionary<int, Customer> Customers;
        private Company Company;

        ErrorProvider ErrLastName = new ErrorProvider();
        ErrorProvider ErrFirstName = new ErrorProvider();

        public ResXResourceSet resxLanguage { get; set; }

        public ChangeCustomer(Company company)
        {
            InitializeComponent();

            this.Company = company;
            this.Customers = company.GetCustomers();
        }

        private void ChangeCustomer_Load(object sender, EventArgs e)
        {
            btnCancle.Text = resxLanguage.GetString("cancel");
            btChangeCustomer.Text = resxLanguage.GetString("add");

            labelFirstName.Text = resxLanguage.GetString("firstName");
            labelLastName.Text = resxLanguage.GetString("lastName");
            labelBallance.Text = resxLanguage.GetString("ballance");
            labelCustomerNumber.Text = resxLanguage.GetString("customerNumber");
            labelEMail.Text = resxLanguage.GetString("email");
            btnGetCustomer.Text = resxLanguage.GetString("getCustomData");
        }
        /// <summary>
        /// putts the actuall Data of the choosen Custome in the Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            int i;
            Int32.TryParse(tbID.Text, out i);
            if (Customers.ContainsKey(i))
            {
                AktCustomer = Customers[i];
                tbEMail.Text = AktCustomer.EMail;
                tbFirstName.Text = AktCustomer.FirstName;
                tbLastName.Text = AktCustomer.LastName;
                tbBallance.Text = Customers[i].Balance.ToString();
            }
            else
            {
                MessageBox.Show("Customer ID not found.");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
        /// <summary>
        /// Setting the Parameters and for the changed customer and give it back to the main Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            int ii;
            Int32.TryParse(tbID.Text, out ii);
            if (!Customers.ContainsKey(ii))
            {
                MessageBox.Show("Customer ID not found. Change not possible.");
            }
            else if (tbEMail.Text != Customers[ii].EMail && !Company.CheckIfEMailUnique(tbEMail.Text))
            {
                MessageBox.Show("Email already exists.");
            }
            else if (!Customer.CheckEmail(tbEMail.Text))
            {
                MessageBox.Show("Email Adress not valid!");
            }
            else
            {
                if (Customer.CheckEmail(tbEMail.Text))
                {
                    if (tbFirstName.Text.Length > 2 && tbLastName.Text.Length > 2 && tbEMail.Text.Length > 5)
                    {
                        AktCustomer.EMail = tbEMail.Text;
                        AktCustomer.FirstName = tbFirstName.Text;
                        AktCustomer.LastName = tbLastName.Text;
                        AktCustomer.Balance = Customers[ii].Balance;
                        //AktCustomer.LastChange = DateTime.Now;  //chainged in changeCustomer() in Company
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
        }
    }
}
