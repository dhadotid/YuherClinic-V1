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
    public partial class FAdminDoctor : Form
    {
        string date = DateTime.Now.AddYears(-20).ToString("dd/MM/yyyy");
        string str, newcode;
        int code = 0;
        public FAdminDoctor()
        {
            InitializeComponent();
        }

        public string agdoctor()
        {
            FileStream fs = new FileStream("Data\\doctor.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\doctor.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(1, 3));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "D00" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "D0" + code;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        newcode = "D" + code;
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
            newcode = "D001";
            sr.Close();
            fs.Close();
            return newcode;
        }

        public void datagridview()
        {
            string line = "";
            int row = 0;
            dgvDoctor.ColumnCount = 7;
            dgvDoctor.Columns[0].Name = "Id Doctor";
            dgvDoctor.Columns[1].Name = "Doctor Name";
            dgvDoctor.Columns[2].Name = "Date of Birth";
            dgvDoctor.Columns[3].Name = "Gender";
            dgvDoctor.Columns[4].Name = "Phone Number";
            dgvDoctor.Columns[5].Name = "Address";
            dgvDoctor.Columns[6].Name = "Specialist";
            FileStream fs = new FileStream("Data\\doctor.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split('#');
                dgvDoctor.Rows.Add();
                for (int i = 0; i < data.Length - 1; i++)
                {
                    dgvDoctor[i, row].Value = data[i];
                }
                row++;
            }
            sr.Close();
            fs.Close();
        }

        private void dgvDoctor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdDoctor.Text = dgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDoctorName.Text = dgvDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDOB.Text = dgvDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
            string gender = dgvDoctor.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (gender.Equals("Male"))
            {
                rbMale.Checked = true;
            }
            else if (gender.Equals("Female"))
            {
                rbFemale.Checked = true;
            }
            txtPhoneNumber.Text = dgvDoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbSpecialist.Text = dgvDoctor.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        public void isicombo()
        {
            cbSpecialist.Items.Clear();
            string line;
            FileStream fs = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split('#');
                cbSpecialist.Items.Add(data[1]);
            }
            sr.Close();
            fs.Close();
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

        private void txtDoctorName_Validating(object sender, CancelEventArgs e)
        {
            if (txtDoctorName.Text == "" || Regex.IsMatch(txtDoctorName.Text, @"^[a-zA-Z0-9\s]+$") == false)
            {
                txtDoctorName.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }

        private void txtDOB_Validating(object sender, CancelEventArgs e)
        {
            //date1 = date.ToString("dd/MM/yyyy");
            if (txtDOB.Text == "" || Regex.IsMatch(txtDOB.Text, @"^\d{1,2}\/\d{1,2}\/\d{4}$") == false || DateTime.Parse(txtDOB.Text) > DateTime.Parse(date))
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

        private void cbSpecialist_Validating(object sender, CancelEventArgs e)
        {
            if (cbSpecialist.SelectedIndex == -1)
            {
                cbSpecialist.Focus();
                lblNullSpecialist.Visible = true;
            }
            else
            {
                lblNullSpecialist.Visible = false;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "" || cbSpecialist.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                if (txtIdDoctor.Text == "full")
                {
                    MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FAdminMenu fam = new FAdminMenu();
                    fam.Show();
                    this.Hide();
                }
                else
                {
                    string gender = "";
                    if (rbMale.Checked)
                    {
                        gender = rbMale.Text;
                    }
                    else if (rbFemale.Checked)
                    {
                        gender = rbFemale.Text;
                    }
                    if (validategender() == 0)
                    {
                        DialogResult result = MessageBox.Show("Do you want to save record " + txtIdDoctor.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            FileStream fs = new FileStream("Data\\doctor.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);


                            string specialist = cbSpecialist.SelectedItem.ToString();
                            sw.WriteLine(txtIdDoctor.Text + "#" + txtDoctorName.Text + "#" + txtDOB.Text + "#" + gender + "#" + txtPhoneNumber.Text + "#" + txtAddress.Text + "#" + specialist + "#");
                            sw.Flush();
                            sw.Close();
                            MessageBox.Show("Data saved");
                            txtDoctorName.Clear();
                            txtDOB.Clear();
                            rbMale.Checked = false;
                            rbFemale.Checked = false;
                            txtPhoneNumber.Clear();
                            txtAddress.Clear();
                            cbSpecialist.SelectedIndex = -1;
                            txtIdDoctor.Clear();
                            txtDoctorName.Focus();

                            datagridview();
                            txtIdDoctor.Text = agdoctor();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correct The Error(s)");
                    }
                }
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "" || cbSpecialist.SelectedIndex == -1)
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

                FileStream fs = new FileStream("Data\\doctor.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                DialogResult dialogResult = MessageBox.Show("Do You Want To Update the Data ?", "Update", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    while ((Str = sr.ReadLine()) != null)
                    {
                        Pos = Str.IndexOf("#");
                        String Chkstr2 = Str.Substring(0, Pos);
                        string Specialist = cbSpecialist.SelectedItem.ToString();
                        string gender = "";
                        if (rbMale.Checked)
                        {
                            gender = rbMale.Text;
                        }
                        else if (rbFemale.Checked)
                        {
                            gender = rbFemale.Text;
                        }
                        if ((txtIdDoctor.Text.CompareTo(Chkstr2) == 0))
                        {
                            txtSimpan = txtIdDoctor.Text + "#" + txtDoctorName.Text + "#" + txtDOB.Text + "#" + gender + "#" + txtPhoneNumber.Text + "#" + txtAddress.Text + "#" + Specialist + "#" + "\n";
                            alltext += txtSimpan;
                            MessageBox.Show("Data Has Been Succesfully Updated!");

                            txtDoctorName.Text = "";
                            txtDOB.Text = "";
                            gender = "";
                            txtAddress.Text = "";
                            txtPhoneNumber.Text = "";
                            Specialist = "";
                            txtIdDoctor.Text = "";
                            cbSpecialist.SelectedIndex = -1;
                            datagridview();
                            txtDoctorName.Focus();
                        }
                        else
                        {
                            alltext = alltext + Str + "\n";
                        }
                    }
                }
                sr.Close();
                fs.Close();
                File.WriteAllText("Data\\doctor.txt", alltext);
                datagridview();
                txtIdDoctor.Text = agdoctor();
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "" || cbSpecialist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete data doctor " + txtIdDoctor.Text + " Doctor Name: " + txtDoctorName.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string path = "Data\\doctor.txt";
                    var oldline = File.ReadAllLines(path);
                    var newline = oldline.Where(line => !line.Contains(txtIdDoctor.Text + "#"));
                    File.WriteAllLines(path, newline);

                    MessageBox.Show("Delete data doctor " + txtIdDoctor.Text + " successfully");
                    datagridview();
                    txtSearch.Clear();
                    txtDoctorName.Clear();
                    txtDOB.Clear();
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                    txtPhoneNumber.Clear();
                    txtAddress.Clear();
                    cbSpecialist.SelectedIndex = -1;
                    txtIdDoctor.Clear();
                    txtDoctorName.Focus();

                    txtIdDoctor.Text = agdoctor();
                }
                datagridview();
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string line = "";
            bool find = false;
            int row = 0;
            FileStream fs = new FileStream("Data\\doctor.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(txtSearch.Text))
                {
                    find = true;
                    MessageBox.Show("Data found");
                    string[] data = line.Split('#');
                    dgvDoctor.Rows.Clear();
                    dgvDoctor.Rows.Add();

                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        dgvDoctor[i, row].Value = data[i];
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminMenu fam = new FAdminMenu();
            fam.Show();
            this.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbSearch_Click(this, new EventArgs());
        }

        private void FAdminDoctor_Load(object sender, EventArgs e)
        {
            isicombo();
            datagridview();
            txtIdDoctor.Text = agdoctor();
        }
    }
}
