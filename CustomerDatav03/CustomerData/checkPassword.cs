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
    public partial class checkPassword : Form
    {

        public string Password { get; set; }
        public ResXResourceSet resxLanguage { get; set; }

        public checkPassword()
        {
            InitializeComponent();
            //tbPassword.Text = "YouCantGuessIT";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Password = tbPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkPassword_Load(object sender, EventArgs e)
        {
            Text = "Entry Password";
            Text = resxLanguage.GetString("titlePassword");
            labelEnterPasswort.Text = resxLanguage.GetString("textEnterPassword");
            btnCancel.Text = resxLanguage.GetString("cancel");
            btnConfirm.Text = resxLanguage.GetString("confirm");

        }
    }
}
