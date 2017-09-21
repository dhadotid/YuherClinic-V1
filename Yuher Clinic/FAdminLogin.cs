using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Yuher_Clinic
{
    public partial class FAdminLogin : Form
    {
        int counter;
        public FAdminLogin()
        {
            InitializeComponent();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            string username, password, user, pass;
            username = txtUser.Text;
            password = txtPass.Text;

            using (StreamReader sr = new StreamReader(File.Open("Data\\adminlogin.txt", FileMode.Open)))
            {
                user = sr.ReadLine();
                pass = sr.ReadLine();
                sr.Close();
            }
            if (username == user && password == pass)
            {
                MessageBox.Show("Welcome, " + username + ". Have a nice day :)", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FAdminMenu fam = new FAdminMenu();
                fam.Show();
                this.Hide();
            }
            else
            {
                counter += 1;
                if (counter < 3)
                {
                    lblError.Visible = true;
                    txtUser.Focus();
                    txtUser.Clear();
                    txtPass.Clear();
                }
                else
                {
                    MessageBox.Show("Unauthorized Access. Aborting...");
                    this.Close();
                }
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FMenu fm = new FMenu();
            fm.Show();
            this.Hide();
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Focus();
                lblColumnPass.Visible = true;
            }
            else
            {
                lblColumnPass.Visible = false;
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Focus();
                lblColumnUser.Visible = true;
            }
            else
            {
                lblColumnUser.Visible = false;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbLogin_Click(this, new EventArgs());
        }
    }
}
