using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CustomerData
{
    public partial class Main : Form
    {
        private Company SWECompany;
        private Dictionary<int, Customer> CustomerDict = new Dictionary<int, Customer>();
        private int[] KeyArra;
        private int sort =0;
        public Main()
        {
            InitializeComponent();
            SWECompany = new Company();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void cLBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btOpenAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer form = new NewCustomer();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (SWECompany.checkIfEMailUnique(form.newCustomer.EMail))
                {
                    try
                    {
                        SWECompany.AddCustomer(form.newCustomer);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ID already used. Customer not added.");
                        //throw;
                    }
                }
                else
                {
                    MessageBox.Show("Email already exists. Customer not added.");
                }
                
               
            }

            CustomerDict = SWECompany.GetCustomers();
            
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            // Generating Data
            SWECompany.AddCustomer(new Customer("Andi", "Andi", "hallo@test.at", 0, 100));
            SWECompany.AddCustomer(new Customer("Zuerst", "Zuerst", "hallo100@test.at", 0, 0));
            for (int i = 1; i < 12; i++)
            {
                string vorname = "test" + i;
                string nachname = "nachtest" + i;
                string email = "hallo"+i+"@test.at";
                int amount = i * 10;
                int id = i + 5;
                SWECompany.AddCustomer(new Customer(vorname, nachname, email, amount, id));
            }
            CustomerDict = SWECompany.GetCustomers();
            // make data visible
            lbCustomer.Items.Clear();
            KeyArra = SWECompany.GetSortedCustomer(sort);
            
            foreach (var key in KeyArra)
            {               
                lbCustomer.Items.Add(CustomerDict[key].ToString());
            }
        }

        private void btnOpenBooking_Click(object sender, EventArgs e)
        {
            Booking forms = new Booking();
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                SWECompany.DoATransition(forms.Amount, forms.ID);
                
            }
            
        }

        private void btnOpenChangeCustomer_Click(object sender, EventArgs e)
        {
            ChangeCustomer forms = new ChangeCustomer(SWECompany.GetCustomers());
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                SWECompany.ChangeCustomer(forms.AktCustomer.ID,forms.AktCustomer);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rbID.Checked)
            {
                rbName.Checked = false;
            }
            if(rbName.Checked)
            {
                rbID.Checked = false;  
            }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: Intager Sort wird nicht merh benötigt
            sort = 1;
            lbCustomer.Items.Clear();
            KeyArra = SWECompany.GetSortedCustomer(sort);
            foreach (var key in KeyArra)
            {
                lbCustomer.Items.Add(CustomerDict[key].ToString());
            }
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: Intager Sort wird nicht merh benötigt
            sort = 0;
            lbCustomer.Items.Clear();
            KeyArra = SWECompany.GetSortedCustomer(sort);
            foreach (var key in KeyArra)
            {
                lbCustomer.Items.Add(CustomerDict[key].ToString());
            }
        }
    }
}
