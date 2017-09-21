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
    public partial class FAdminReportPayment : Form
    {
        public FAdminReportPayment()
        {
            InitializeComponent();
        }

        private void FAdminReportPayment_Load(object sender, EventArgs e)
        {

            this.crystalReportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FAdminReport far = new FAdminReport();
            far.Show();
            this.Hide();
        }
    }
}
