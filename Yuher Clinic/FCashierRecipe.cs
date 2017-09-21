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
    public partial class FCashierRecipe : Form
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        string str, newcode, kode, harga, expdate, strqty, strdrugname, strdurgdtype;
        int code = 0;
        int harga1 = 0, sub = 0, qty = 0, newstock = 0;
        public FCashierRecipe()
        {
            InitializeComponent();
        }
        public string agrecipedetail()
        {
            FileStream fs = new FileStream("Data\\recipedetail.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\recipedetail.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(2, 5));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "RD0000" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "RD000" + code;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        newcode = "RD00" + code;
                    }
                    else if (code >= 1000 && code < 9999)
                    {
                        newcode = "RD0" + code;
                    }
                    else if (code >= 10000 && code < 99999)
                    {
                        newcode = "RD" + code;
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
            newcode = "RD00001";
            sr.Close();
            fs.Close();
            return newcode;
        }
        public string cekidrecipe()
        {
            FileStream fs = new FileStream("Data\\treatment.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\treatment.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    kode = isi[3];
                }
            }
            sr.Close();
            fs.Close();
            return kode;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
        }
        /*
        private void txtQty_TextChanged(object sender, EventArgs e)
        {

            harga1 = Convert.ToInt32(harga);
            //int qty = Convert.ToInt32(txtQty.Text);
            sub = Convert.ToInt32(txtQty.Text) * harga1;
            txtSubtotal.Text = Convert.ToString(sub);
        }
        */
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
                string[] data = line.Split('#');
                dgvDrug.Rows.Add();
                for (int i = 0; i < data.Length - 1; i++)
                {
                    dgvDrug[i, row].Value = data[i];
                }
                row++;
            }
            sr.Close();
            fs.Close();
        }
        private void dgvDrug_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDrug.Text = dgvDrug.Rows[e.RowIndex].Cells[0].Value.ToString();
            strdrugname = dgvDrug.Rows[e.RowIndex].Cells[1].Value.ToString();
            strdurgdtype = dgvDrug.Rows[e.RowIndex].Cells[2].Value.ToString();
            strqty = dgvDrug.Rows[e.RowIndex].Cells[3].Value.ToString();
            expdate = dgvDrug.Rows[e.RowIndex].Cells[4].Value.ToString();
            harga = dgvDrug.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (Convert.ToInt32(strqty) < 20)
            {
                MessageBox.Show("The remaining drug " + strqty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(strqty) < 0)
            {
                MessageBox.Show("drug stocks have been exhausted");
            }
        }
        private void txtDrug_Validating(object sender, CancelEventArgs e)
        {
            if (txtDrug.Text == "")
            {
                txtDrug.Focus();
                lblNullDrug.Visible = true;
            }
            else
            {
                lblNullDrug.Visible = false;
            }
        }
        private void txtQty_Validating(object sender, CancelEventArgs e)
        {
            if (txtQty.Text == "" || Regex.IsMatch(txtQty.Text, @"^\d+$") == false)
            {
                txtQty.Focus();
                lblQty.Visible = true;
            }
            else
            {
                lblQty.Visible = false;
                
                harga1 = Convert.ToInt32(harga);
                int qty = Convert.ToInt32(txtQty.Text);
                sub = qty * harga1;
                txtSubtotal.Text = Convert.ToString(sub);
                
            }
        }

        private void txtDose_Validating(object sender, CancelEventArgs e)
        {
            if (txtDose.Text == "" || Regex.IsMatch(txtDose.Text, @"^[0-9]{1,1}[X,x][0-9]{1,1}$") == false)
            {
                txtDose.Focus();
                lblNullDose.Visible = true;
            }
            else
            {
                lblNullDose.Visible = false;
            }
        }
        private int validasidrug()
        {
            int flag = 0;
            if (txtDrug.Text == "")
            {
                lblNullDrug.Visible = true;
                flag = 1;
            }
            return flag;
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if (txtDose.Text == "" || txtSubtotal.Text == "")
            {
                MessageBox.Show("Please fill the data");
            }
            else
            {
                if (txtRD.Text == "full")
                {
                    MessageBox.Show("Data already meets maximum limit", "Can not store data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FCashierMenu fcm = new FCashierMenu();
                    fcm.Show();
                    this.Hide();
                }
                else
                {
                    if (validasidrug() == 0)
                    {
                        if (Convert.ToInt32(strqty) < Convert.ToInt32(txtQty.Text))
                        {
                            //obat kurang
                            MessageBox.Show("less drug");
                        }
                        else
                        {
                            if (expdate == date)
                            {
                                MessageBox.Show("Can not save record because drug has been expired");
                                txtDrug.Clear();
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Do you want to save record " + txtRD.Text + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    string[] strarray = new string[7];
                                    int pos;
                                    string alltext = "";
                                    string txtsimpan = "";
                                    string line;

                                    FileStream fs = new FileStream("Data\\recipedetail.txt", FileMode.Append, FileAccess.Write);
                                    StreamWriter sw = new StreamWriter(fs);
                                    sw.WriteLine(txtRD.Text + "#" + txtIdRecipe.Text + "#" + txtDrug.Text + "#" + txtDose.Text + "#" + txtQty.Text + "#" + txtSubtotal.Text + "#");
                                    sw.Flush();
                                    sw.Close();
                                    
                                    /*Temp File*/
                                    FileStream fstemp = new FileStream("Data\\temprecipe.txt", FileMode.Append, FileAccess.Write);
                                    StreamWriter swtemp = new StreamWriter(fstemp);
                                    swtemp.WriteLine(txtRD.Text + "#" + strdrugname + "#" + txtDose.Text + "#" + txtQty.Text + "#" + txtSubtotal.Text + "#");
                                    swtemp.Flush();
                                    swtemp.Close();

                                    newstock = (Convert.ToInt32(strqty) - Convert.ToInt32(txtQty.Text));
                                    FileStream fs1 = new FileStream("Data\\drug.txt", FileMode.Open, FileAccess.Read);
                                    StreamReader sr = new StreamReader(fs1);
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        pos = line.IndexOf("#");
                                        string chkstr = line.Substring(0, pos);
                                        if ((txtDrug.Text.CompareTo(chkstr) == 0))
                                        {
                                            txtsimpan = txtDrug.Text + "#" + strdrugname + "#" + strdurgdtype + "#" + newstock + "#" + expdate + "#" + harga + "#" + "\n";
                                            alltext += txtsimpan;
                                        }
                                        else
                                        {
                                            alltext = alltext + line + "\n";
                                        }
                                    }
                                    sr.Close();
                                    fs1.Close();
                                    File.WriteAllText("Data\\drug.txt", alltext);

                                    
                                    //sub = 0;
                                    txtSubtotal.Clear();
                                    txtQty.Clear();
                                    txtDose.Clear();
                                    txtDrug.Clear();
                                    txtRD.Clear();
                                    txtIdRecipe.Clear();
                                    txtDose.Focus();

                                    datagridview();
                                    txtRD.Text = agrecipedetail();
                                    txtIdRecipe.Text = cekidrecipe();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correct The Error(s)");
                    }
                }
            }
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
        private void FCashierRecipe_Load(object sender, EventArgs e)
        {
            datagridview();
            txtRD.Text = agrecipedetail();
            txtIdRecipe.Text = cekidrecipe();
        }
    }
}
