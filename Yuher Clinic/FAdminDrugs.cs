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
    public partial class FAdminDrugs : Form
    {
        string date = DateTime.Now.AddDays(+5).ToString("dd/MM/yyyy");
        string str, newcode;
        int code = 0;
        public FAdminDrugs()
        {
            InitializeComponent();
        }
        public void datagridview()
        {
            string line = "";
            int row = 0;
            dgvDrug.ColumnCount = 6;
            dgvDrug.Columns[0].Name = "Id Drug";
            dgvDrug.Columns[1].Name = "Drug Name";
            dgvDrug.Columns[2].Name = "Drug Type";
            dgvDrug.Columns[3].Name = "Stock";
            dgvDrug.Columns[4].Name = "ExpDate";
            dgvDrug.Columns[5].Name = "Price";
            FileStream fs = new FileStream("Data\\drug.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dgvDrug.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dgvDrug[i, row].Value = elemen[i];
                }
                row++;
            }
            sr.Close();
            fs.Close();
        }
        public string agdrug()
        {
            FileStream fs = new FileStream("Data\\drug.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\drug.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(3, 5));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "DRG0000" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "DRG000" + code;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        newcode = "DRG00" + code;
                    }
                    else if (code >= 1000 && code < 9999)
                    {
                        newcode = "DRG0" + code;
                    }
                    else if (code >= 10000 && code < 99999)
                    {
                        newcode = "DRG" + code;
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
            newcode = "DRG00001";
            sr.Close();
            fs.Close();
            return newcode;
        }
        public void isicombobox()
        {
            cbDrugType.Items.Clear();
            cbDrugType.Items.Add("Capsule");
            cbDrugType.Items.Add("Tablet");
            cbDrugType.Items.Add("Syrup");
            cbDrugType.Items.Add("Cream");
        }

        private void txtDrugName_Validating(object sender, CancelEventArgs e)
        {
            if (txtDrugName.Text == "")
            {
                txtDrugName.Focus();
                lblNullName.Visible = true;
            }
            else
            {
                lblNullName.Visible = false;
            }
        }

        private void cbDrugType_Validating(object sender, CancelEventArgs e)
        {
            if (cbDrugType.SelectedIndex == -1)
            {
                cbDrugType.Focus();
                lblNullType.Visible = true;
            }
            else
            {
                lblNullType.Visible = false;
            }
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            if (txtStock.Text == "" || Regex.IsMatch(txtStock.Text, @"^\d+$") == false)
            {
                txtStock.Focus();
                lblStock.Visible = true;
            }
            else
            {
                lblStock.Visible = false;
            }
        }

        private void txtExpDate_Validating(object sender, CancelEventArgs e)
        {
            if (txtExpDate.Text == "" || Regex.IsMatch(txtExpDate.Text, @"^\d{1,2}\/\d{1,2}\/\d{4}$") == false || DateTime.Parse(txtExpDate.Text) < DateTime.Parse(date))
            {
                txtExpDate.Focus();
                lblNullDOB.Visible = true;
            }
            else
            {
                lblNullDOB.Visible = false;
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrice.Text == "" || Regex.IsMatch(txtPrice.Text, @"^\d+$") == false || txtPrice.Text.Length < 2)
            {
                txtPrice.Focus();
                lblPrice.Visible = true;
            }
            else
            {
                lblPrice.Visible = false;
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (txtDrugName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                if (txtIdDrug.Text == "full")
                {
                    MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FAdminMenu fam = new FAdminMenu();
                    fam.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to save record " + txtIdDrug.Text + " drug name " + txtDrugName.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FileStream fs = new FileStream("Data\\drug.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);

                        string drugtype = cbDrugType.SelectedItem.ToString();
                        sw.WriteLine(txtIdDrug.Text + "#" + txtDrugName.Text + "#" + drugtype + "#" + txtStock.Text + "#" + txtExpDate.Text + "#" + txtPrice.Text + "#");
                        sw.Flush();
                        sw.Close();
                        MessageBox.Show("Data saved");
                        cbDrugType.SelectedIndex = -1;
                        txtStock.Clear();
                        txtExpDate.Clear();
                        txtPrice.Clear();
                        txtIdDrug.Clear();
                        txtDrugName.Clear();
                        txtDrugName.Focus();

                        isicombobox();
                        txtIdDrug.Text = agdrug();
                    }
                }
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (txtDrugName.Text == "" || txtPrice.Text == "")
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

                FileStream fs = new FileStream("Data\\drug.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                DialogResult dialogResult = MessageBox.Show("Do You Want To Update the Data ?", "Update", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    while ((Str = sr.ReadLine()) != null)
                    {
                        Pos = Str.IndexOf("#");
                        String Chkstr2 = Str.Substring(0, Pos);
                        //string drugtype = cbDrugType.SelectedItem.ToString();
                        if ((txtIdDrug.Text.CompareTo(Chkstr2) == 0))
                        {
                            string drugtype = cbDrugType.SelectedItem.ToString();
                            txtSimpan = txtIdDrug.Text + "#" + txtDrugName.Text + "#" + drugtype + "#" + txtStock.Text + "#" + txtExpDate.Text + "#" + txtPrice.Text + "#" + "\n";
                            alltext += txtSimpan;
                            MessageBox.Show("Data Has Been Succesfully Updated!");

                            txtPrice.Clear();
                            txtExpDate.Clear();
                            txtStock.Clear();
                            cbDrugType.SelectedIndex = -1;
                            txtIdDrug.Clear();
                            txtDrugName.Clear();
                            txtDrugName.Focus();
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
                File.WriteAllText("Data\\drug.txt", alltext);
                datagridview();
                txtIdDrug.Text = agdrug();
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (txtDrugName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please select the data");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to delete data drug " + txtIdDrug.Text + " Drug Name: " + txtDrugName.Text + "?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string path = "Data\\drug.txt";
                    var oldline = File.ReadAllLines(path);
                    var newline = oldline.Where(line => !line.Contains(txtIdDrug.Text + "#"));
                    File.WriteAllLines(path, newline);

                    MessageBox.Show("Delete data drug " + txtIdDrug.Text + " successfully");
                    datagridview();
                    txtSearch.Clear();
                    txtPrice.Clear();
                    txtExpDate.Clear();
                    txtStock.Clear();
                    cbDrugType.SelectedIndex = -1;
                    txtIdDrug.Clear();
                    txtDrugName.Clear();
                    txtDrugName.Focus();

                    txtIdDrug.Text = agdrug();
                }
                datagridview();
            }
        }

        private void dgvDrug_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdDrug.Text = dgvDrug.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDrugName.Text = dgvDrug.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbDrugType.Text = dgvDrug.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStock.Text = dgvDrug.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtExpDate.Text = dgvDrug.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPrice.Text = dgvDrug.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string line = "";
            bool find = false;
            int row = 0;
            FileStream fs = new FileStream("Data\\drug.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(txtSearch.Text))
                {
                    find = true;
                    MessageBox.Show("Data found");
                    string[] data = line.Split('#');
                    dgvDrug.Rows.Clear();
                    dgvDrug.Rows.Add();

                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        dgvDrug[i, row].Value = data[i];
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

        private void FAdminDrugs_Load(object sender, EventArgs e)
        {
            datagridview();
            txtIdDrug.Text = agdrug();
            isicombobox();
        }
    }
}
