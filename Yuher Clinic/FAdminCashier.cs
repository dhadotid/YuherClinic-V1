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
    public partial class FAdminCashier : Form
    {
        public FAdminCashier()
        {
            InitializeComponent();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            FAdminAddAccountCashier faac = new FAdminAddAccountCashier();
            faac.Show();
            this.Hide();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            FAdminAddAccountCashier faac = new FAdminAddAccountCashier();
            faac.Show();
            this.Hide();
        }

        private void pbChange_Click(object sender, EventArgs e)
        {
            FAdminChangePasswordCashier facpc = new FAdminChangePasswordCashier();
            facpc.Show();
            this.Hide();
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            FAdminChangePasswordCashier facpc = new FAdminChangePasswordCashier();
            facpc.Show();
            this.Hide();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            FAdminDeleteAccountCashier facd = new FAdminDeleteAccountCashier();
            facd.Show();
            this.Hide();
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            FAdminDeleteAccountCashier facd = new FAdminDeleteAccountCashier();
            facd.Show();
            this.Hide();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }
    }
}
