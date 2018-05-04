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
    public partial class FillLanguageDAtaset : Form
    {
        public FillLanguageDAtaset()
        {
            InitializeComponent();
        }

        private void btnStorelanguage_Click(object sender, EventArgs e)
        {
            ResourceWriter ren = new ResourceWriter(Application.StartupPath + "/resource.en-US.resources");
            ResourceWriter rde = new ResourceWriter(Application.StartupPath + "/resource.de-DE.resources");
            foreach (MyData.speachRow row in myData.speach.Rows)
            {
                ren.AddResource(row.key, row.English);
                rde.AddResource(row.key, row.German);
            }

            ren.Generate();
            ren.Close();
            rde.Generate();
            rde.Close();

            // generieren eines Resource Managers
            /*
            ResourceManager rm = new ResourceManager("de-DE", typeof(Main).Assembly);

            var test = rm.GetString("test");
            var test2 = rm.GetString("test2");
            MessageBox.Show(test + " " + test2);
            */
        }

        private void FillLanguageDAtaset_Load(object sender, EventArgs e)
        {

        }
    }
}
