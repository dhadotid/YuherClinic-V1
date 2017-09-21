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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void pbAdmin_Click(object sender, EventArgs e)
        {
            FAdminLogin fal = new FAdminLogin();
            fal.Show();
            this.Hide();
        }

        private void pbCashier_Click(object sender, EventArgs e)
        {
            FCashierLogin fcl = new FCashierLogin();
            fcl.Show();
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

        private void pbLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is developed by:\nHernita Noviyanti\nAnd\nRaden Satria Yudha Purba Jagad", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblYuher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is developed by:\nHernita Noviyanti\nAnd\nRaden Satria Yudha Purba Jagad", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbIg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hrntnvynt\nyudhapurbajagad", "Follow us on Instagram");
        }
    }
}
