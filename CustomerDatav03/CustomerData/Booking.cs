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
    public partial class Booking : Form
    {
        public int Amount { get; set; }
        public int ID { get; set; }
        public ResXResourceSet resxLanguage { get; set; }
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            btnPayIn.Text = resxLanguage.GetString("payIn");
            btnPayOut.Text = resxLanguage.GetString("payOut");
            btnCancel.Text = resxLanguage.GetString("cancel");

            labelCustomerNumber.Text = resxLanguage.GetString("customerNumber");
            labelAmount.Text = resxLanguage.GetString("amount");
        }
        /// <summary>
        /// Gives the main Window the amount to pay in for the choosen Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayIn_Click(object sender, EventArgs e)
        {
            int ii1;
            int ii2;
            Int32.TryParse(tbAmount.Text, out ii1);
            Amount = ii1;
            Int32.TryParse(tbCustomerNumber.Text, out ii2);
            ID = ii2;
            DialogResult = DialogResult.OK;
            Close();
        }
        /// <summary>
        /// Gives the main Window the amount to pay out for the choosen Customer
        /// (uses the textbox and makes the value negertiv)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayOut_Click(object sender, EventArgs e)
        {
            int ii1;
            int ii2;
            Int32.TryParse(tbAmount.Text, out ii1);
            Amount = 0-ii1; // make negertiv value
            Int32.TryParse(tbCustomerNumber.Text, out ii2);
            ID = ii2;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
