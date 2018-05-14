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
        public Customer AddCustomer { get; set; }
        private Company Company;
        private Dictionary<int, Customer> Customers;

        ErrorProvider ErrLastName = new ErrorProvider();
        ErrorProvider ErrFirstName = new ErrorProvider();

        public ResXResourceSet resxLanguage { get; set; }

        public NewCustomer(Company company)
        {
            InitializeComponent();
            this.Company = company;
            this.Customers = Company.GetCustomers();
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
            if (Customer.CheckEmail(tbEMail.Text))
            {
                if (tbFirstName.Text.Length > 2 && tbLastName.Text.Length > 2 && tbEMail.Text.Length > 5)
                {
                    int i;
                    Int32.TryParse(tbBallance.Text, out i);
                    int u;
                    var id = tbCustomerNumber.Text;
                    if (id.Length > 0)
                    {
                        Int32.TryParse(tbCustomerNumber.Text, out u);
                        AddCustomer = new Customer(tbFirstName.Text, tbLastName.Text, tbEMail.Text, i, u);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No ID inserted");
                    }

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
    }
}
