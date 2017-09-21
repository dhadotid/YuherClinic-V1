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
    public partial class FAdminSpecialist : Form
    {
        string str, newcode, cekspecialist;
        int code = 0;
        public FAdminSpecialist()
        {
            InitializeComponent();
        }

        private void FAdminSpecialist_Load(object sender, EventArgs e)
        {
            datagridview();
            txtIdSpecialist.Text = agspecialist();
        }

        public void datagridview()
        {
            string line = "";
            int row = 0;
            dgvSpecialist.ColumnCount = 3;
            dgvSpecialist.Columns[0].Name = "IdSpecialist";
            dgvSpecialist.Columns[1].Name = "Specialist";
            dgvSpecialist.Columns[2].Name = "Fare";
            FileStream fs = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dgvSpecialist.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dgvSpecialist[i, row].Value = elemen[i];
                }
                row++;
            }
            sr.Close();
            fs.Close();
        }

        private void dgvSpecialist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdSpecialist.Text = dgvSpecialist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSpecialist.Text = dgvSpecialist.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFare.Text = dgvSpecialist.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtSpecialist_Validating(object sender, CancelEventArgs e)
        {
            if (txtSpecialist.Text == "")
            {
                txtSpecialist.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }

        private void txtFare_Validating(object sender, CancelEventArgs e)
        {
            if (txtFare.Text == "" || Regex.IsMatch(txtFare.Text, @"^\d+$") == false || txtFare.Text.Length < 5)
            {
                txtFare.Focus();
                lblNullFare.Visible = true;
            }
            else
            {
                lblNullFare.Visible = false;
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (txtSpecialist.Text == "" || txtFare.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                FileStream fs1 = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fs1);
                string cek;
                bool test = false;
                while((cek = sr1.ReadLine()) != null)
                {
                    if (cek.Contains(txtSpecialist.Text))
                    {
                        test = true;
                        MessageBox.Show("Specialist already available");
                    }
                }
                sr1.Close();
                fs1.Close();
                if (test == false)
                {
                    //sr1.Close();
                    //fs1.Close();
                    string[] strArray = new string[7];
                    int Pos;
                    String alltext = "";
                    String txtSimpan = "";
                    string Str;

                    FileStream fs = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    DialogResult dialogResult = MessageBox.Show("Do You Want To Update the Data ?", "Update", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        while ((Str = sr.ReadLine()) != null)
                        {
                            Pos = Str.IndexOf("#");
                            String Chkstr2 = Str.Substring(0, Pos);
                            if ((txtIdSpecialist.Text.CompareTo(Chkstr2) == 0))
                            {
                                txtSimpan = txtIdSpecialist.Text + "#" + txtSpecialist.Text + "#" + txtFare.Text + "#" + "\n";
                                alltext += txtSimpan;
                                MessageBox.Show("Data Has Been Succesfully Updated!");

                                txtIdSpecialist.Clear();
                                txtSpecialist.Clear();
                                txtFare.Clear();
                                txtSpecialist.Focus();
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
                    File.WriteAllText("Data\\specialist.txt", alltext);
                    datagridview();
                    txtIdSpecialist.Text = agspecialist();
                }
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (txtSpecialist.Text == "" || txtFare.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete specialist " + txtIdSpecialist.Text + " " + txtSpecialist.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string path = "Data\\specialist.txt";
                    var oldline = File.ReadAllLines(path);
                    var newline = oldline.Where(line => !line.Contains(txtIdSpecialist.Text + "#"));
                    File.WriteAllLines(path, newline);

                    MessageBox.Show("Delete data specialist " + txtIdSpecialist.Text + " successfully");
                    datagridview();
                    txtSearch.Clear();
                    txtSpecialist.Clear();
                    txtFare.Clear();
                    txtSpecialist.Focus();
                    txtIdSpecialist.Text = agspecialist();
                }
                datagridview();
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string line = "";
            bool find = false;
            int row = 0;
            FileStream fs = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(txtSearch.Text))
                {
                    find = true;
                    MessageBox.Show("Data found");
                    string[] data = line.Split('#');
                    dgvSpecialist.Rows.Clear();
                    dgvSpecialist.Rows.Add();

                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        dgvSpecialist[i, row].Value = data[i];
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

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (txtSpecialist.Text == "" || txtFare.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                FileStream fs1 = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fs1);
                string cek;
                bool test = false;
                while((cek = sr1.ReadLine()) != null)
                {
                    if (cek.Contains(txtSpecialist.Text))
                    {
                        test = true;
                        MessageBox.Show("Specialist already available");
                    }
                }
                sr1.Close();
                fs1.Close();
                if (test == false)
                {
                    //sr1.Close();
                    //fs1.Close();
                    if (txtIdSpecialist.Text == "full")
                    {
                        MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FAdminMenu fam = new FAdminMenu();
                        fam.Show();
                        this.Hide();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Do you want to save record " + txtIdSpecialist.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            FileStream fs = new FileStream("Data\\specialist.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(txtIdSpecialist.Text + "#" + txtSpecialist.Text + "#" + txtFare.Text + "#");
                            sw.Flush();
                            sw.Close();
                            MessageBox.Show("Data saved");
                            txtIdSpecialist.Clear();
                            txtFare.Clear();
                            txtSpecialist.Clear();

                            datagridview();
                            txtIdSpecialist.Text = agspecialist();
                            txtSpecialist.Focus();
                        }
                    }
                }
            }
        }

        public string agspecialist()
        {
            FileStream fs = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\specialist.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(3, 2));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "SPC0" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "SPC" + code;
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
            newcode = "SPC01";
            sr.Close();
            fs.Close();
            return newcode;
        }
    }
}
