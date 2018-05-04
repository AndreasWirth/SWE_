using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using CustomerData.Properties;

namespace CustomerData
{
    public partial class Main : Form
    {
        private Company SWECompany;
        private Dictionary<int, Customer> CustomerDict = new Dictionary<int, Customer>();
        private int[] KeyArray= new int[0];
        private int sort =0;
        private string resxFilePrivateSettings = @".\PrivateSettings.resx";
        private ResXResourceSet resxPrivateSettings;
        private string resxFileLanguag;
        private ResXResourceSet resxLanguage;

        public Main()
        {
            InitializeComponent();
            SWECompany = new Company();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            /*
            CultureInfo ci = new CultureInfo("de-DE");
            
            //CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            */

            resxFilePrivateSettings = @".\PrivateSettings.resx";
            resxPrivateSettings = new ResXResourceSet(resxFilePrivateSettings);

            if (resxPrivateSettings.GetString("Language")=="1")
            {
                resxFileLanguag = @".\English.resx";
            }
            else
            {
                resxFileLanguag = @".\German.resx";
            }

            // setting ResousrceSet
            resxLanguage = new ResXResourceSet(resxFileLanguag);

            /*
            //Nachschlagewerk
            using (ResXResourceSet resxSet = new ResXResourceSet(resxFileLanguag))
            {
                var test = resxSet.GetString("test");
                var test2 = resxSet.GetString("test2");

            }
            using (ResXResourceSet resxSet = new ResXResourceSet(resxFileLanguag))
            {
                var test = resxSet.GetString("test");
                var test2 = resxSet.GetString("test2");
            }
            using (ResXResourceWriter resxSet = new ResXResourceWriter(resxFileLanguag))
            {
                resxSet.AddResource("test", "test");
            }
            */
        }

        private void btnStorelanguage_Click(object sender, EventArgs e)
        {
            FillLanguageDAtaset forms = new FillLanguageDAtaset();
            forms.Show();
        }

        #region GUI Elements / GUI Evetns


        #region Buttons
        /// <summary>
        /// opens the Widow to add a new Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOpenAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer form = new NewCustomer();
            form.resxLanguage = resxLanguage;
            form.Text = resxLanguage.GetString("titleAdd");
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
                        //MessageBox.Show("ID already used. Customer not added.");
                        MessageBox.Show(resxLanguage.GetString("idUsed"));
                    }
                }
                else
                {
                    //MessageBox.Show("Email already exists. Customer not added.");
                    MessageBox.Show(resxLanguage.GetString("emailExists"));
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
            for (int i = 1; i < 30; i++)
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
            forms.resxLanguage = resxLanguage;
            forms.Text = resxLanguage.GetString("titleBooking");
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
            forms.resxLanguage = resxLanguage;
            forms.Text = resxLanguage.GetString("titleChange");
            var result = forms.ShowDialog();
            if (result == DialogResult.OK)
            {
                SWECompany.ChangeCustomer(forms.AktCustomer.ID, forms.AktCustomer); 
            }
            showCustomer();
        }
        /// <summary>
        /// Saved the Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SWECompany.StoreData();
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
                if (SWECompany.checkPassword(forms.password))
                {
                    SWECompany.GetData();
                    CustomerDict = SWECompany.GetCustomers();
                    KeyArray = SWECompany.GetSortedCustomer(0);
                    showCustomer();
                }
                else
                {
                    //MessageBox.Show("Password was not correct");
                    MessageBox.Show(resxLanguage.GetString("passwordWrong"));
                }
            }
        }
        #endregion

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
        /// changes sort algorithem to Last Name if changed in the Group Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            sort = 1;
            showCustomer();
        }
        /// <summary>
        /// changes sort algorithem to ID if changed in the Group Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            sort = 0;
            showCustomer();
        }
        private void tbFilterby_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 2)
            {
                showCustomer();
            }
        }
        #endregion
        #region Methodes

        /// <summary>
        /// Prints the Data in the Listtextbox on the Main Window
        /// Handles Filter and sorting internaly
        /// </summary>
        private void showCustomer()
        {
            KeyArray = SWECompany.GetSortedCustomer(sort);
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
                            if (checkFilter(aktCustomer, aktFilter))
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
                    //TODO: generate Message
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
        public bool checkFilter(Customer aktCustomer, string Filter)
        {
            // ToLower will cost speed, but it is more robust
            if (aktCustomer.FirstName.ToLower().Contains(Filter.ToLower()) || aktCustomer.LastName.ToLower().Contains(Filter.ToLower()))
            {
                return true;
            }
            return false;
        }


        #endregion

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            
            ChangeLanguage();
            // Setting GUI Element names
            btOpenAddCustomer.Text = resxLanguage.GetString("addCustomer");
            btnOpenChangeCustomer.Text = resxLanguage.GetString("changeCustomer");
            btnOpenBooking.Text = resxLanguage.GetString("makeBooking");
            btnChangeLanguage.Text = resxLanguage.GetString("changeLanguage");
            gbSortby.Text = resxLanguage.GetString("sortby");
            rbName.Text = resxLanguage.GetString("lastName");
            gBFilterBy.Text = resxLanguage.GetString("filterby");
            btnSaveData.Text = resxLanguage.GetString("saveData");
            btnLoadData.Text = resxLanguage.GetString("loadData");
        }
        private void ChangeLanguage()
        {
            resxPrivateSettings = new ResXResourceSet(resxFilePrivateSettings);
            if (resxPrivateSettings.GetString("Language") == "1")
            {
                using (ResXResourceWriter resxSet = new ResXResourceWriter(resxFilePrivateSettings))
                {
                    resxSet.AddResource("Language", "0");
                    resxSet.Generate();
                    resxSet.Close();
                }
                resxFileLanguag = @".\German.resx";
            }
            else
            {
                using (ResXResourceWriter resxSet = new ResXResourceWriter(resxFilePrivateSettings))
                {
                    resxSet.AddResource("Language", "1");
                    resxSet.Generate();
                    resxSet.Close();
                }
                resxFileLanguag = @".\English.resx";
            }

            // setting ResousrceSet
            resxLanguage = new ResXResourceSet(resxFileLanguag);
        }
    }
}
