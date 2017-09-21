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
    public partial class FAdminPaymentHistory : Form
    {
        public FAdminPaymentHistory()
        {
            InitializeComponent();
        }
        public void datagridview()
        {
            string line = "";
            int row = 0;
            dgvPay.ColumnCount = 9;
            dgvPay.Columns[0].Name = "Id Payment";
            dgvPay.Columns[1].Name = "Id Treatment";
            dgvPay.Columns[2].Name = "Patient Name";
            dgvPay.Columns[3].Name = "Doctor Name";
            dgvPay.Columns[4].Name = "Diagnose";
            dgvPay.Columns[5].Name = "Date Treatment";
            dgvPay.Columns[6].Name = "Payment Doctor";
            dgvPay.Columns[7].Name = "Payment Drug";
            dgvPay.Columns[8].Name = "Total Payment";
            FileStream fs = new FileStream("Data\\payment.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split('#');
                dgvPay.Rows.Add();
                for (int i = 0; i < data.Length - 1; i++)
                {
                    dgvPay[i, row].Value = data[i];
                }
                row++;
            }
            sr.Close();
            fs.Close();
        }
        private void FAdminPaymentHistory_Load(object sender, EventArgs e)
        {
            datagridview();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string line = "";
            bool find = false;
            int row = 0;
            FileStream fs = new FileStream("Data\\payment.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(txtSearch.Text))
                {
                    find = true;
                    MessageBox.Show("Data found");
                    string[] data = line.Split('#');
                    dgvPay.Rows.Clear();
                    dgvPay.Rows.Add();

                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        dgvPay[i, row].Value = data[i];
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
            FAdminSearch fas = new FAdminSearch();
            fas.Show();
            this.Hide();
        }
    }
}
