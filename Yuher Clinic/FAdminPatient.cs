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
    public partial class FAdminPatient : Form
    {
        public FAdminPatient()
        {
            InitializeComponent();
        }

        public void datagridview()
        {
            string line = "";
            int row = 0;
            dgvPatient.ColumnCount = 6;
            dgvPatient.Columns[0].Name = "IdPatient";
            dgvPatient.Columns[1].Name = "PatientName";
            dgvPatient.Columns[2].Name = "DateofBirth";
            dgvPatient.Columns[3].Name = "PhoneNumber";
            dgvPatient.Columns[4].Name = "PatientGender";
            dgvPatient.Columns[5].Name = "Address";
            FileStream fs = new FileStream("Data\\patient.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dgvPatient.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dgvPatient[i, row].Value = elemen[i];
                }
                row++;
            }
            sr.Close();
            fs.Close();
        }

        private void dgvPatient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdPatient.Text = dgvPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDOB.Text = dgvPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
            string gender = dgvPatient.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (gender.Equals("Male"))
            {
                rbMale.Checked = true;
            }
            else if (gender.Equals("Female"))
            {
                rbFemale.Checked = true;
            }
            txtAddress.Text = dgvPatient.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void FAdminPatient_Load(object sender, EventArgs e)
        {
            datagridview();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == "" || Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9\s]+$") == false)
            {
                txtName.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }

        private void txtDOB_Validating(object sender, CancelEventArgs e)
        {
            if (txtDOB.Text == "" || Regex.IsMatch(txtDOB.Text, @"^\d{1,2}\/\d{1,2}\/\d{4}$") == false)
            {
                txtDOB.Focus();
                lblNullDOB.Visible = true;
            }
            else
            {
                lblNullDOB.Visible = false;
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhoneNumber.Text == "" || Regex.IsMatch(txtPhoneNumber.Text, @"^62[0-9]{9,11}$") == false)
            {
                txtPhoneNumber.Focus();
                lblPhoneNumber.Visible = true;
            }
            else
            {
                lblPhoneNumber.Visible = false;
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                lblNullAddress.Visible = true;
            }
            else
            {
                lblNullAddress.Visible = false;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private int validategender()
        {
            int flag = 0;
            string gender = "";
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
            if (gender == "")
            {
                lblNullGender.Visible = true;
                flag = 1;
            }
            return flag;
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdPatient.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                string[] strArray = new string[7];
                int Pos;
                String alltext = "";
                String txtSimpan = "";
                string Str;

                FileStream fs = new FileStream("Data\\patient.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                if (validategender() == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Do You Want To Update the Data ?", "Update", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        while ((Str = sr.ReadLine()) != null)
                        {
                            Pos = Str.IndexOf("#");
                            String Chkstr2 = Str.Substring(0, Pos);
                            string gender = "";
                            if (rbMale.Checked)
                            {
                                gender = rbMale.Text;
                            }
                            else if (rbFemale.Checked)
                            {
                                gender = rbFemale.Text;
                            }
                            if ((txtIdPatient.Text.CompareTo(Chkstr2) == 0))
                            {
                                txtSimpan = txtIdPatient.Text + "#" + txtName.Text + "#" + txtDOB.Text + "#" + txtPhoneNumber.Text + "#" + gender + "#" + txtAddress.Text + "#" + "\n";
                                alltext += txtSimpan;
                                MessageBox.Show("Data Has Been Succesfully Updated!");
                                txtAddress.Clear();
                                txtName.Clear();
                                txtDOB.Clear();
                                rbMale.Checked = false;
                                rbFemale.Checked = false;
                                txtPhoneNumber.Clear();
                                txtName.Focus();

                                txtIdPatient.Clear();
                                datagridview();
                            }
                            else
                            {
                                alltext = alltext + Str + "\n";
                            }
                        }
                    }
                    sr.Close();
                    fs.Close();
                    File.WriteAllText("Data\\patient.txt", alltext);
                    datagridview();
                }
                else
                {
                    MessageBox.Show("Correct the Error(s)");
                }
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete data patient " + txtIdPatient.Text + " Patient Name " + txtName.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string path = "Data\\patient.txt";
                    var oldline = File.ReadAllLines(path);
                    var newline = oldline.Where(line => !line.Contains(txtIdPatient.Text + "#"));
                    File.WriteAllLines(path, newline);

                    MessageBox.Show("Delete data doctor " + txtIdPatient.Text + " successfully");
                    datagridview();
                    txtSearch.Clear();
                    txtName.Clear();
                    txtDOB.Clear();
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                    txtPhoneNumber.Clear();
                    txtAddress.Clear();
                    txtIdPatient.Clear();
                    txtName.Focus();
                }
                datagridview();
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string line = "";
            bool find = false;
            int row = 0;
            FileStream fs = new FileStream("Data\\patient.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(txtSearch.Text))
                {
                    find = true;
                    MessageBox.Show("Data found");
                    string[] data = line.Split('#');
                    dgvPatient.Rows.Clear();
                    dgvPatient.Rows.Add();

                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        dgvPatient[i, row].Value = data[i];
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbSearch_Click(this, new EventArgs());
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }
    }
}
