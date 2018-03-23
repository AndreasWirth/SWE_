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
    public partial class checkPassword : Form
    {

        public string password { get; set; }
        public checkPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.password = tbPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
