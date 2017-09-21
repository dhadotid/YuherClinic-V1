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
    public partial class FCashierTreatment : Form
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        string str, newcode, kodebaru;
        int code = 0, kode = 0;
        public FCashierTreatment()
        {
            InitializeComponent();
        }
        public void datagridview()
        {
            string line = "";
            int row = 0;
            dgvDoctor.ColumnCount = 8;
            dgvDoctor.Columns[0].Name = "Id Doctor";
            dgvDoctor.Columns[1].Name = "Doctor Name";
            dgvDoctor.Columns[2].Name = "Date of Birth";
            dgvDoctor.Columns[3].Name = "Gender";
            dgvDoctor.Columns[4].Name = "Phone Number";
            dgvDoctor.Columns[5].Name = "Address";
            dgvDoctor.Columns[6].Name = "Specialist";
            dgvDoctor.Columns[7].Name = "Fare";
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
        public string agtreatment()
        {
            FileStream fs = new FileStream("Data\\treatment.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\treatment.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(1, 5));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "T0000" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "T000" + code;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        newcode = "T00" + code;
                    }
                    else if (code >= 1000 && code < 9999)
                    {
                        newcode = "T0" + code;
                    }
                    else if (code >= 10000 && code < 99999)
                    {
                        newcode = "T" + code;
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
            newcode = "T00001";
            sr.Close();
            fs.Close();
            return newcode;
        }
        public string agrecipe()
        {
            FileStream fs = new FileStream("Data\\treatment.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\treatment.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    kode = Convert.ToInt32(isi[3].Substring(1, 5));
                    kode = kode + 1;
                    if (code < 10)
                    {
                        kodebaru = "R0000" + kode;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        kodebaru = "R000" + kode;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        kodebaru = "R00" + kode;
                    }
                    else if (code >= 1000 && code < 9999)
                    {
                        kodebaru = "R0" + kode;
                    }
                    else if (code >= 10000 && code < 99999)
                    {
                        kodebaru = "R" + kode;
                    }
                    else
                    {
                        kodebaru = "full";
                    }
                    sr.Close();
                    fs.Close();
                    return kodebaru;
                }
            }
            kodebaru = "R00001";
            sr.Close();
            fs.Close();
            return kodebaru;
        }
        private void FCashierTreatment_Load(object sender, EventArgs e)
        {
            datagridview();
            txtIdTreatment.Text = agtreatment();
            txtRecipe.Text = agrecipe();
            txtDateTreatment.Text = date;
        }
        private void txtIdPatient_Validating(object sender, CancelEventArgs e)
        {
            if (txtIdPatient.Text == "" || Regex.IsMatch(txtIdPatient.Text, @"^P[0-9]{1,5}$") == false)
            {
                txtIdPatient.Focus();
                lblNullPatient.Visible = true;
            }
            else
            {
                lblNullPatient.Visible = false;
            }
        }
        
        public int validasidokter()
        {
            int flag = 0;
            if (txtIdDoctor.Text == "")
            {
                lblNullDoctor.Visible = true;
                flag = 1;
            }
            return flag;
        }
        private void txtDiagnose_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiagnose.Text == "")
            {
                lblNullDiagnose.Visible = true;
            }
            else
            {
                lblNullDiagnose.Visible = false;
            }
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

        private void dgvDoctor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdDoctor.Text = dgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if (txtIdPatient.Text == "" || txtDiagnose.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                if (txtIdTreatment.Text == "full")
                {
                    MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FCashierMenu fcm = new FCashierMenu();
                    fcm.Show();
                    this.Hide();
                }
                else
                {
                    if (validasidokter() == 0)
                    {
                        DialogResult result = MessageBox.Show("Do you want to save record " + txtIdTreatment.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            FileStream fs = new FileStream("Data\\treatment.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);

                            sw.WriteLine(txtIdTreatment.Text + "#" + txtIdPatient.Text + "#" + txtIdDoctor.Text + "#" + txtRecipe.Text + "#" + txtDiagnose.Text + "#" + txtDateTreatment.Text + "#");
                            sw.Flush();
                            sw.Close();
                            MessageBox.Show("Data saved");
                            txtDateTreatment.Clear();
                            txtDiagnose.Clear();
                            txtRecipe.Clear();
                            txtIdDoctor.Clear();
                            txtIdTreatment.Clear();
                            txtIdPatient.Clear();
                            txtIdPatient.Focus();

                            datagridview();
                            txtIdTreatment.Text = agtreatment();
                            txtRecipe.Text = agrecipe();
                            txtDateTreatment.Text = date;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correct Error(s)");
                    }
                }
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
    }
}
