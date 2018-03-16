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
    public partial class Booking : Form
    {
        public int Amount;
        public int ID;
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void btnPayIn_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbAmount.Text, out Amount);
            Int32.TryParse(tbCustomerNumber.Text, out ID);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPayOut_Click(object sender, EventArgs e)
        {
            int i;
            Int32.TryParse(tbAmount.Text, out i);
            Amount = 0-i; // make negertiv value
            Int32.TryParse(tbCustomerNumber.Text, out ID);
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
