using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Yuher_Clinic
{
    public partial class FCashierListDoctor : Form
    {
        public FCashierListDoctor()
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

        private void FCashierListDoctor_Load(object sender, EventArgs e)
        {
            datagridview();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbSearch_Click(this, new EventArgs());
        }
    }
}
