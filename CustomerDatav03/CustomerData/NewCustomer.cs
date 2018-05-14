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
    /// <summary>
    /// Forms for collecting the necessary Data to greate a new Customer
    /// </summary>
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
            btnGenerateID.Text = resxLanguage.GetString("btnGenerateID");

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
                        //MessageBox.Show("No ID inserted");
                        MessageBox.Show(resxLanguage.GetString("erNoID"));
                    }

                }
                else
                {
                    //MessageBox.Show("To less Input.");
                    MessageBox.Show(resxLanguage.GetString("erLessInput"));
                }
            }
            else
            {
                //MessageBox.Show("Email Adress not valid!");
                MessageBox.Show(resxLanguage.GetString("erEmialNotValid"));
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
                errProvEmail.SetError(tbEMail, resxLanguage.GetString("textInvalidEmail"));
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

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Length <=2)
            {
                ErrFirstName.SetError(tbFirstName, resxLanguage.GetString("tesxtNameToshort"));
            }
            else
            {
                ErrFirstName.Clear();
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (tbLastName.Text.Length <= 2)
            {
                ErrLastName.SetError(tbLastName, resxLanguage.GetString("tesxtNameToshort"));
            }
            else
            {
                ErrLastName.Clear();
            }
        }
    }
}
