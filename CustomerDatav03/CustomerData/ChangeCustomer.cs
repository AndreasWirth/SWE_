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
    public partial class ChangeCustomer : Form
    {
        public Customer AktCustomer { get; set; }
        private Dictionary<int, Customer> Customers;
        public ChangeCustomer(Dictionary<int, Customer> Customers)
        {
            InitializeComponent();
            this.Customers = Customers;
        }

        private void ChangeCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            int i;
            Int32.TryParse(tbID.Text, out i);
            AktCustomer = Customers[i];
            tbBallance.Text = AktCustomer.Balance.ToString();
            tbEMail.Text = AktCustomer.EMail;
            tbFirstName.Text = AktCustomer.FirstName;
            tbLastName.Text = AktCustomer.LastName;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            AktCustomer.FirstName = tbFirstName.Text;
            AktCustomer.LastName = tbLastName.Text;
            AktCustomer.EMail = tbEMail.Text;
            int i;
            Int32.TryParse(tbBallance.Text, out i);
            AktCustomer.Balance = i;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
