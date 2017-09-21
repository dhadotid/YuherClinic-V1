﻿using System;
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
    public partial class FCashierMenu : Form
    {
        public FCashierMenu()
        {
            InitializeComponent();
        }

        private void pbPatient_Click(object sender, EventArgs e)
        {
            FCashierPatient fcp = new FCashierPatient();
            fcp.Show();
            this.Hide();
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            FCashierPatient fcp = new FCashierPatient();
            fcp.Show();
            this.Hide();
        }

        private void pbTreatment_Click(object sender, EventArgs e)
        {
            FCashierTreatment fat = new FCashierTreatment();
            fat.Show();
            this.Hide();
        }

        private void lblTreatment_Click(object sender, EventArgs e)
        {
            FCashierTreatment fat = new FCashierTreatment();
            fat.Show();
            this.Hide();
        }

        private void pbLD_Click(object sender, EventArgs e)
        {
            FCashierListDoctor fcld = new FCashierListDoctor();
            fcld.Show();
            this.Hide();
        }

        private void lblLD_Click(object sender, EventArgs e)
        {
            FCashierListDoctor fcld = new FCashierListDoctor();
            fcld.Show();
            this.Hide();
        }

        private void pbRecipe_Click(object sender, EventArgs e)
        {
            FCashierRecipe far = new FCashierRecipe();
            far.Show();
            this.Hide();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            FCashierRecipe far = new FCashierRecipe();
            far.Show();
            this.Hide();
        }

        private void pbPayment_Click(object sender, EventArgs e)
        {
            FCashierPayment fcp = new FCashierPayment();
            fcp.Show();
            this.Hide();
        }

        private void lblPayment_Click(object sender, EventArgs e)
        {
            FCashierPayment fcp = new FCashierPayment();
            fcp.Show();
            this.Hide();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Thank's for using this program\nHave a nice day :)");
                Application.Exit();
            }
        }
    }
}
