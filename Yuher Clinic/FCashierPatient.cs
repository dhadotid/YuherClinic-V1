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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Text.RegularExpressions;

namespace Yuher_Clinic
{
    public partial class FCashierPatient : Form
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        string str, newcode;
        int code = 0;
        public FCashierPatient()
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
        public string agpatient()
        {
            FileStream fs = new FileStream("Data\\patient.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\patient.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(1, 5));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "P0000" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "P000" + code;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        newcode = "P00" + code;
                    }
                    else if (code >= 1000 && code < 9999)
                    {
                        newcode = "P0" + code;
                    }
                    else if (code >= 10000 && code < 99999)
                    {
                        newcode = "P" + code;
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
            newcode = "P00001";
            sr.Close();
            fs.Close();
            return newcode;
        }

        private void txtDOB_Validating(object sender, CancelEventArgs e)
        {
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
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
        }

        private void FCashierPatient_Load(object sender, EventArgs e)
        {
            datagridview();
            txtIdPatient.Text = agpatient();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                if (txtIdPatient.Text == "full")
                {
                    MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FCashierMenu fcm = new FCashierMenu();
                    fcm.Show();
                    this.Hide();
                }
                else
                {
                    string gender = "";
                    bool ischecked = rbMale.Checked;
                    if (ischecked)
                    {
                        gender = rbMale.Text;
                    }
                    else
                    {
                        gender = rbFemale.Text;
                    }
                    if (validategender() == 0)
                    {
                        DialogResult result = MessageBox.Show("Do you want to save record " + txtIdPatient.Text + " with name " + txtName.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            FileStream fs = new FileStream("Data\\patient.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);


                            sw.WriteLine(txtIdPatient.Text + "#" + txtName.Text + "#" + txtDOB.Text + "#" + txtPhoneNumber.Text + "#" + gender + "#" + txtAddress.Text + "#");
                            sw.Flush();
                            sw.Close();
                            MessageBox.Show("Data saved.\nPrint Data");

                            FCashierCardPatient fccp = new FCashierCardPatient();
                            CRCardPatient crcp = new CRCardPatient();
                            TextObject toidpatient = (TextObject)crcp.ReportDefinition.Sections["Section3"].ReportObjects["IdPatient"];
                            toidpatient.Text = txtIdPatient.Text;
                            TextObject topatientname = (TextObject)crcp.ReportDefinition.Sections["Section3"].ReportObjects["PatientName"];
                            topatientname.Text = txtName.Text;
                            TextObject tophonenumber = (TextObject)crcp.ReportDefinition.Sections["Section3"].ReportObjects["PhoneNumber"];
                            tophonenumber.Text = txtPhoneNumber.Text;
                            TextObject toaddress = (TextObject)crcp.ReportDefinition.Sections["Section3"].ReportObjects["Address"];
                            toaddress.Text = txtAddress.Text;
                            fccp.crystalReportViewer1.ReportSource = crcp;
                            fccp.crystalReportViewer1.Refresh();
                            fccp.Show();
                            this.Hide();

                            txtName.Clear();
                            txtDOB.Clear();
                            txtPhoneNumber.Clear();
                            rbMale.Checked = false;
                            rbFemale.Checked = false;
                            txtAddress.Clear();
                            txtIdPatient.Clear();
                            txtName.Focus();

                            datagridview();
                            txtIdPatient.Text = agpatient();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correct The Error(s)");
                    }
                }
            }
        }
        
    }
}
