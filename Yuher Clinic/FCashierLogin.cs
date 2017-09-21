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
    public partial class FCashierLogin : Form
    {
        bool cek = false;
        int counter;
        public FCashierLogin()
        {
            InitializeComponent();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtUser.Text;
            password = txtPass.Text;
            FileStream fs = new FileStream("Data\\cashierlogin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            int flag = 0;
            while (line != null)
            {
                if (line.Contains(username))
                {
                    string[] isi = line.Split('#');
                    if (isi[1] == username && isi[2] == password)
                    {
                        flag = 1;
                    }
                    break;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

            if (flag == 1)
            {
                MessageBox.Show("Welcome, " + username + ". Have a nice day :)", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FCashierMenu fcm = new FCashierMenu();
                fcm.Show();
                this.Hide();
                counter = 0;
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

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Focus();
                lblNullUser.Visible = true;
            }
            else
            {
                lblNullUser.Visible = false;
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Focus();
                lblNullPass.Visible = true;
            }
            else
            {
                lblNullPass.Visible = false;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbLogin_Click(this, new EventArgs());
        }
    }
}
