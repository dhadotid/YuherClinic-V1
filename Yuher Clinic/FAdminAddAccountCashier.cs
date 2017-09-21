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
using System.Text.RegularExpressions;

namespace Yuher_Clinic
{
    public partial class FAdminAddAccountCashier : Form
    {
        string str, newcode;
        int code = 0;
        string cek;
        public FAdminAddAccountCashier()
        {
            InitializeComponent();
        }
        public string agcashier()
        {
            FileStream fs = new FileStream("Data\\cashierlogin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\cashierlogin.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(1, 3));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "C00" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "C0" + code;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        newcode = "C" + code;
                    }
                    else
                    {
                        newcode = "full";
                    }
                    sr.Close();
                    fs.Close();
                    return newcode;
                }
            }
            newcode = "C001";
            sr.Close();
            fs.Close();
            return newcode;
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtUser.Text == "" || Regex.IsMatch(txtUser.Text, @"^[a-zA-Z0-9]+$") == false)
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
            if (txtPass.Text == "" || Regex.IsMatch(txtPass.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                txtPass.Focus();
                lblPass.Visible = true;
            }
            else
            {
                lblPass.Visible = false;
            }
        }

        private void txtCoPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtCoPass.Text == "")
            {
                txtCoPass.Focus();
                lblCoPass.Visible = true;
            }
            else
            {
                lblCoPass.Visible = false;
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
            this.Hide();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtCoPass.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                if (txtIdCashier.Text == "full")
                {
                    MessageBox.Show("account cashier has been full");
                    FAdminCashier fac = new FAdminCashier();
                    fac.Show();
                    this.Hide();
                }
                else
                {
                    if (txtPass.Text == txtCoPass.Text)
                    {
                        if (txtUser.Text.Length < 5)
                        {
                            MessageBox.Show("Please enter username more than 5");
                        }
                        else if (txtUser.Text.Length > 15)
                        {
                            MessageBox.Show("username is too long, a maximum 15 characters");
                        }
                        else if (txtPass.Text.Length < 5)
                        {
                            MessageBox.Show("Please enter password more than 5");
                        }
                        else if (txtPass.Text.Length > 15)
                        {
                            MessageBox.Show("Password is too long, a maximum 15 characters");
                        }
                        else
                        {
                            string lgnkasr = txtIdCashier.Text + "#" + txtUser.Text + "#" + txtPass.Text + "#";
                            StreamWriter sw = new StreamWriter(@"Data\\cashierlogin.txt", true);
                            sw.WriteLine(lgnkasr);
                            sw.Close();
                            MessageBox.Show("account cashier has been added");
                            txtIdCashier.Clear();
                            txtPass.Clear();
                            txtCoPass.Clear();
                            txtUser.Clear();
                            txtUser.Focus();
                            txtIdCashier.Text = agcashier();
                        }
                    }
                    else
                    {
                        MessageBox.Show("your password dosen't matched!");
                        txtCoPass.Clear();
                    }
                }
            }
        }

        private void FAdminAddAccountCashier_Load(object sender, EventArgs e)
        {
            txtIdCashier.Text = agcashier();
        }
    }
}
