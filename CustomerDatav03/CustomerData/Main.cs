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
        private int[] KeyArray;
        private int[] KeyArray= new int[0];
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
        /// <summary>
        /// opens the Widow to add a new Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            showCustomer();
        }
        /// <summary>
        /// Adds test customers to the Dictionary, and displays them in the ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            showCustomer();
        }
        /// <summary>
        /// opens the Window for a Transition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenBooking_Click(object sender, EventArgs e)
        {
            Booking forms = new Booking();
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                SWECompany.DoATransition(forms.Amount, forms.ID);
                
            }

            showCustomer();
        }
        /// <summary>
        /// opens the Window to change teh Data of a Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenChangeCustomer_Click(object sender, EventArgs e)
        {
            ChangeCustomer forms = new ChangeCustomer(SWECompany.GetCustomers());
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                SWECompany.ChangeCustomer(forms.AktCustomer.ID, forms.AktCustomer); 
            }
            showCustomer();
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
        /// <summary>
        /// changes sort algorithem to Last Name if changed in the Group Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            lbCustomer.Items.Clear();
            KeyArray = SWECompany.GetSortedCustomer(1);
            showCustomer();
        }
        /// <summary>
        /// changes sort algorithem to ID if changed in the Group Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            lbCustomer.Items.Clear();
            KeyArray = SWECompany.GetSortedCustomer(0);
            showCustomer();
        }

        private void showCustomer()
        {
            foreach (var key in KeyArray)
            try
            {
                lbCustomer.Items.Add(CustomerDict[key].ToString());
                lbCustomer.Items.Clear();
                foreach (var key in KeyArray)
                {
                    lbCustomer.Items.Add(CustomerDict[key].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show( e.Message);
            }
            
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SWECompany.StoreData();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            SWECompany.GetData();
            CustomerDict = SWECompany.GetCustomers();
            KeyArray = SWECompany.GetSortedCustomer(0);
            showCustomer();
        }
    }
}
