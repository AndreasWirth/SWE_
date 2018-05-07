using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CustomerData
{
    /// <summary>
    /// Main Class for the CustomerHandler Application
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// Company which collects and contains the Customers
        /// </summary>
        private Company SWECompany;
        /// <summary>
        /// Copy of the Data from the Company, used for displaying an checking
        /// MVC based
        /// </summary>
        private Dictionary<int, Customer> CustomerDict = new Dictionary<int, Customer>();
        /// <summary>
        /// Saves the order of the Customer keys to represent them correct in the GUI
        /// </summary>
        private int[] KeyArray= new int[0];
        /// <summary>
        /// REprecents the order on which the Customers should be displayed in the GUI
        /// </summary>
        private int Sort =0;

        #region GUI Elements / GUI Evetns
        /// <summary>
        /// Entry point for the Main Window
        /// </summary>
        public Main()
        {
            InitializeComponent();
            SWECompany = new Company();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Text = "Customer Handler";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rbID.Checked)
            {
                rbName.Checked = false;
            }
            if (rbName.Checked)
            {
                rbID.Checked = false;
            }
        }

        /// <summary>
        /// if changed in the Group Box, changes Sort algorithem to Last Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbName.Checked)
            {
                Sort = 1;
                ShowCustomer();
            }
        }
        /// <summary>
        /// if changed in the Group Box, changes Sort algorithem to ID 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbID.Checked)
            {
                Sort = 0;
                ShowCustomer();
            }
        }
        private void tbFilterby_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 2)
            {
                ShowCustomer();
            }
        }

        #region Buttons
        /// <summary>
        /// Opens the Widow to add a new Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOpenAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer form = new NewCustomer(SWECompany);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (SWECompany.CheckIfEMailUnique(form.AddCustomer.EMail))
                {
                    try
                    {
                        SWECompany.AddCustomer(form.AddCustomer);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ID already used. Customer not added.");
                    }
                }
                else
                {
                    MessageBox.Show("Email already exists. Customer not added.");
                } 
            }

            CustomerDict = SWECompany.GetCustomers();
            ShowCustomer();
        }

        /// <summary>
        /// Adds test customers to the Dictionary, and displays them in the ListBox
        /// Not necessary for the Application.
        /// Addet to simplify the testing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            // Generating Data
            SWECompany.AddCustomer(new Customer("Andi", "Andi", "hallo@test.at", 0, 100));
            SWECompany.AddCustomer(new Customer("Zuerst", "Zuerst", "hallo100@test.at", 0, 0));
            for (int i = 1; i < 30; i++)
            {
                string vorname = "test" + i;
                string nachname = "nachtest" + i;
                string email = "hallo"+i+"@test.at";
                decimal amount = i * 10;
                int id = i + 5;
                SWECompany.AddCustomer(new Customer(vorname, nachname, email, amount, id));
            }
            CustomerDict = SWECompany.GetCustomers();
            // make data visible
            ShowCustomer();
        }
        /// <summary>
        /// Opens the Window for a Transition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenBooking_Click(object sender, EventArgs e)
        {
            Booking forms = new Booking();
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    SWECompany.DoATransition(forms.Amount, forms.ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Customer Id not found. Booking Canceled.");
                }
                
            }
            ShowCustomer();
        }
        /// <summary>
        /// Opens the Window to change the Data of a Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenChangeCustomer_Click(object sender, EventArgs e)
        {
            ChangeCustomer forms = new ChangeCustomer(SWECompany);
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                try
                {
                    SWECompany.ChangeCustomer(forms.AktCustomer.ID, forms.AktCustomer);
                }
                catch (Exception)
                {
                    MessageBox.Show("Customer couldn't changed");
                }
                   

            }
            ShowCustomer();
        }
        /// <summary>
        /// Saved the Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                SWECompany.StoreData();
            }
            catch (Exception)
            {
                MessageBox.Show("Empty Database! No Customers found. Storeing data canceled");
            }
        }
        /// <summary>
        /// Loads the Data from the safed file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            checkPassword forms = new checkPassword();
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (SWECompany.CheckPassword(forms.Password))
                {
                    //TODO catch exeption from load data for display in GUI
                    try
                    {
                        SWECompany.GetData();
                        CustomerDict = SWECompany.GetCustomers();
                        KeyArray = SWECompany.GetSortedCustomer(0);
                        ShowCustomer();
                    }
                    catch (ArgumentNullException argnull)
                    {
                        //"No stored Data Found"
                        MessageBox.Show(argnull.Message);
                    }
                    catch (FileNotFoundException argfile)
                    {
                        //"File was empty! No Customer added."
                        MessageBox.Show(argfile.Message);
                    }  
                }
                else
                {
                    MessageBox.Show("Password was not correct");
                }
            }
        }
        #endregion

        #endregion

        #region Methodes

        /// <summary>
        /// Prints the Data in the Listtextbox on the Main Window
        /// Handles Filter and sorting internaly
        /// </summary>
        private void ShowCustomer()
        {
            KeyArray = SWECompany.GetSortedCustomer(Sort);
            if (KeyArray.Length > 0)
            {
                try
                {
                    lbCustomer.Items.Clear();
                    Customer aktCustomer = CustomerDict.First().Value;
                    string aktFilter = tbFilterby.Text; // copy filter, to prefent an chaning filter while printing
                    foreach (var key in KeyArray)
                    {
                        aktCustomer = CustomerDict[key];
                        // filtering the ouput
                        if (tbFilterby.Text.Length > 2)
                        {
                            if (CheckFilter(aktCustomer, aktFilter))
                            {
                                lbCustomer.Items.Add(CustomerDict[key].ToString());
                            }
                        }
                        else // length <2 is handelt as no filter
                        {
                            lbCustomer.Items.Add(CustomerDict[key].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            
        }
        /// <summary>
        /// Checks if customer first or last name contains the Filter sting
        /// </summary>
        /// <param name="aktCustomer">customer to check</param>
        /// <param name="Filter">filter tex which has to be inside</param>
        /// <returns>true if the text maches in First or Last NAme</returns>
        public bool CheckFilter(Customer aktCustomer, string Filter)
        {
            // ToLower will cost speed, but it is more robust
            if (aktCustomer.FirstName.ToLower().Contains(Filter.ToLower()) || aktCustomer.LastName.ToLower().Contains(Filter.ToLower()))
            {
                return true;
            }
            return false;
        }


        #endregion
    }
}
