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
    public partial class FAdminDeleteAccountCashier : Form
    {
        public FAdminDeleteAccountCashier()
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
        private void FAdminDeleteAccountCashier_Load(object sender, EventArgs e)
        {
            datagridview();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (this.dgvCashier.SelectedRows.Count > 0)
            {
                result = MessageBox.Show("Are you sure you want to Delete this account? \n",
                "Please insert new data", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgvCashier.Rows.RemoveAt(this.dgvCashier.SelectedRows[0].Index);

                    string sLine = "";
                    dgvCashier.Refresh();
                    int count = dgvCashier.Rows.Count;
                    File.WriteAllText("Data\\cashierlogin.txt", String.Empty);
                    FileStream fs = new FileStream("Data\\cashierlogin.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    for (int r = 0; r < count - 1; r++)
                    {
                        int colCount = dgvCashier.Rows[r].Cells.Count;
                        for (int c = 0; c < colCount; c++)
                        {
                            sLine = sLine + dgvCashier.Rows[r].Cells[c].Value;
                            if (c != dgvCashier.Columns.Count - 1)
                            {
                                sLine = sLine + "#";
                            }
                        }
                        sLine += "\r\n";
                        sw.Write(sLine);
                        sw.WriteLine("");

                        sLine = "";
                    }
                    fs.Flush();
                    sw.Close();
                    MessageBox.Show("Your data successfully deleted! :)");
                }
            }
            else
                MessageBox.Show("You must select one row!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            FAdminCashier fac = new FAdminCashier();
            fac.Show();
            this.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbSearch_Click(this, new EventArgs());
        }
    }
}
