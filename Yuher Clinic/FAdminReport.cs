using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuher_Clinic
{
    public partial class FAdminReport : Form
    {
        public FAdminReport()
        {
            InitializeComponent();
        }

        private void pbPayment_Click(object sender, EventArgs e)
        {
            FAdminReportPayment farp = new FAdminReportPayment();
            farp.Show();
            this.Hide();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }

        private void pbDrug_Click(object sender, EventArgs e)
        {
            FAdminReportDrug fard = new FAdminReportDrug();
            fard.Show();
            this.Hide();
        }

        private void pbPatient_Click(object sender, EventArgs e)
        {
            FAdminReportPatient farp = new FAdminReportPatient();
            farp.Show();
            this.Hide();
        }
    }
}
