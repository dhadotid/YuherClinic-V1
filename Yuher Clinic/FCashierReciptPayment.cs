using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Yuher_Clinic
{
    public partial class FCashierReciptPayment : Form
    {
        public FCashierReciptPayment()
        {
            InitializeComponent();
        }
        private void FCashierReciptPayment_Load(object sender, EventArgs e)
        {

            this.crystalReportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
            File.WriteAllText(@"Data\\temprecipe.txt", string.Empty);
        }
    }
}
