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
    public partial class FAdminChangePasswordCashier : Form
    {
        string path;
        public FAdminChangePasswordCashier()
        {
            InitializeComponent();
        }

        public void datagridview()
        {
            string line = "";
            int row = 0;

            dgvCashier.ColumnCount = 3;
            dgvCashier.Columns[0].Name = "Id Cashier";
            dgvCashier.Columns[1].Name = "Cashier";
            dgvCashier.Columns[2].Name = "Password";

            FileStream F = new FileStream("Data\\cashierlogin.txt", FileMode.Open, FileAccess.Read);
            StreamReader R = new StreamReader(F);

            while ((line = R.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dgvCashier.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dgvCashier[i, row].Value = elemen[i];
                }
                row++;
            }
            R.Close();
            F.Close();
        }

        private void FAdminChangePasswordCashier_Load(object sender, EventArgs e)
        {
            datagridview();
        }

        private void txtOldPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtOldPass.Text == "")
            {
                txtOldPass.Focus();
                lblOldPass.Visible = true;
            }
            else
            {
                lblOldPass.Visible = false;
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Focus();
                lblNewPass.Visible = true;
            }
            else
            {
                lblNewPass.Visible = false;
            }
        }

        private void txtCoNewPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtCoNewPass.Text == "")
            {
                txtCoNewPass.Focus();
                lblNullNewCoPas.Visible = true;
            }
            else
            {
                lblNullNewCoPas.Visible = false;
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            string[] strarray = new string[7];
            int pos;
            string alltext = "";
            string txtsimpan = "";
            string str;

            FileStream fs = new FileStream("Data\\cashierlogin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            if (txtIdCashier.Text == "" || txtCoNewPass.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                if (txtNewPass.Text == txtCoNewPass.Text)
                {
                    DialogResult dr = MessageBox.Show("Do you want to save the new data?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        while ((str = sr.ReadLine()) != null)
                        {
                            pos = str.IndexOf("#");
                            string chkstr2 = str.Substring(0, pos);
                            if ((txtIdCashier.Text.CompareTo(chkstr2) == 0))
                            {
                                txtsimpan = txtIdCashier.Text + "#" + txtUser.Text + "#" + txtNewPass.Text + "#" + "\n";
                                alltext += txtsimpan;
                                MessageBox.Show("Successful Update");

                                txtIdCashier.Clear();
                                txtNewPass.Clear();
                                txtOldPass.Clear();
                                txtUser.Clear();
                                txtCoNewPass.Clear();
                                txtNewPass.Focus();
                                datagridview();
                            }
                            else
                            {
                                alltext = alltext + str + "\n";
                            }
                        }
                    }

                    sr.Close();
                    fs.Close();
                    File.WriteAllText("Data\\cashierlogin.txt", alltext);
                    datagridview();
                }
                else
                {
                    MessageBox.Show("Password not match");
                }
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string line = "";
            bool find = false;
            int row = 0;
            FileStream fs = new FileStream("Data\\cashierlogin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(txtSearch.Text))
                {
                    find = true;
                    MessageBox.Show("Data found");
                    string[] data = line.Split('#');
                    dgvCashier.Rows.Clear();
                    dgvCashier.Rows.Add();

                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        dgvCashier[i, row].Value = data[i];
                    }
                    row++;
                }
            }
            if (find == false)
            {
                MessageBox.Show("Data not found");
                datagridview();
            }
            sr.Close();
            fs.Close();
        }

        private void dgvCashier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdCashier.Text = dgvCashier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUser.Text = dgvCashier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOldPass.Text = dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbSearch_Click(this, new EventArgs());
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
            this.Hide();
        }
    }
}
