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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Yuher_Clinic
{
    public partial class FCashierPayment : Form
    {
        string str, newcode, kode, iddoctor, fare, recipe, specialist, idpatient, patientname, doctorname, diagnose, datetreat, idrecipe;
        string namaobat, dosis, drugqty, subdrug, iddrug;
        int code = 0, totalobat, kembalian;
        public FCashierPayment()
        {
            InitializeComponent();
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            kembalian = Convert.ToInt32(txtMoney.Text) - Convert.ToInt32(txtTotalPayment.Text);
            txtChange.Text = Convert.ToString(kembalian);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FCashierMenu fcm = new FCashierMenu();
            fcm.Show();
            this.Hide();
        }

        private void txtMoney_Validating(object sender, CancelEventArgs e)
        {
            if (txtMoney.Text == "" || Regex.IsMatch(txtMoney.Text, @"^\d+$") == false || Convert.ToInt32(txtMoney.Text) < Convert.ToInt32(txtTotalPayment.Text)) //kalo bisa sih gk usah diconvert.
            {
                txtMoney.Focus();
                lblNullMoney.Visible = true;
            }
            else
            {
                lblNullMoney.Visible = false;
                /*
                kembalian = Convert.ToInt32(txtMoney.Text) - Convert.ToInt32(txtTotalPayment.Text);
                txtChange.Text = Convert.ToString(kembalian);
                */
            }
        }
        public string payment()
        {
            FileStream fs = new FileStream("Data\\payment.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                string lastline = File.ReadLines("Data\\payment.txt").Last();
                if (lastline != null)
                {
                    string[] isi = lastline.Split('#');
                    code = Convert.ToInt32(isi[0].Substring(3, 5));
                    code = code + 1;
                    if (code < 10)
                    {
                        newcode = "PAY0000" + code;
                    }
                    else if (code >= 10 && code < 99)
                    {
                        newcode = "PAY000" + code;
                    }
                    else if (code >= 100 && code < 999)
                    {
                        newcode = "PAY00" + code;
                    }
                    else if (code >= 1000 && code < 9999)
                    {
                        newcode = "PAY0" + code;
                    }
                    else if (code >= 10000 && code < 99999)
                    {
                        newcode = "PAY" + code;
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
            newcode = "PAY00001";
            sr.Close();
            fs.Close();
            return newcode;
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
                    kode = isi[0];
                    idpatient = isi[1];
                    iddoctor = isi[2];
                    recipe = isi[3];
                    diagnose = isi[4];
                    datetreat = isi[5];
                }
            }
            sr.Close();
            fs.Close();
            return kode;
        }
        public string ceknamepatient()
        {
            FileStream fs = new FileStream("Data\\patient.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while((str = sr.ReadLine()) != null)
            {
                if (str.Contains(idpatient))
                {
                    string[] isi = str.Split('#');
                    patientname = isi[1];
                }
            }
            sr.Close();
            fs.Close();
            return patientname;
        }
        public string cekspecialist()
        {
            FileStream fs = new FileStream("Data\\doctor.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                if (str.Contains(iddoctor))
                {
                    string[] isi = str.Split('#');
                    doctorname = isi[1];
                    specialist = isi[6];
                }
            }
            sr.Close();
            fs.Close();
            return specialist;

        }
        public string getfare()
        {
            FileStream fs = new FileStream("Data\\specialist.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while((str = sr.ReadLine()) != null)
            {
                if (str.Contains(specialist))
                {
                    string[] isi = str.Split('#');
                    fare = isi[2];
                }
            }
            sr.Close();
            fs.Close();
            return fare;
        }
        public int paymentdrug()
        {
            FileStream fs = new FileStream("Data\\recipedetail.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                if (str.Contains(recipe))
                {
                    string[] isi = str.Split('#');
                    string total1 = isi[5];
                    iddrug = isi[2];
                    dosis = isi[3];
                    drugqty = isi[4];
                    subdrug = isi[5];
                    //idrecipe = isi[1];
                    totalobat = totalobat + int.Parse(total1);
                }
            }
            sr.Close();
            fs.Close();
            return totalobat;
        }
        private void FCashierPayment_Load(object sender, EventArgs e)
        {
            txtIdPayment.Text = payment();
            txtIdTreatment.Text = agtreatment();
            txtPatientName.Text = ceknamepatient();
            cekspecialist();
            txtDoctorName.Text = doctorname;
            txtDiagnose.Text = diagnose;
            txtDateTreatment.Text = datetreat;
            txtPaymentDoctor.Text = getfare();
            txtPaymentDrug.Text = Convert.ToString(paymentdrug());
            int total = Convert.ToInt32(txtPaymentDoctor.Text) + Convert.ToInt32(txtPaymentDrug.Text);
            txtTotalPayment.Text = Convert.ToString(total);
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if (txtIdTreatment.Text == "" || txtChange.Text == "")
            {
                MessageBox.Show("Please fill in the data");
            }
            else
            {
                if (Convert.ToInt32(txtMoney.Text) < Convert.ToInt32(txtTotalPayment.Text))
                {
                    //uang kurang
                    MessageBox.Show("less money");
                }
                else
                {
                    FileStream fs = new FileStream("Data\\payment.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    DialogResult result = MessageBox.Show("Are you sure want save the data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        sw.WriteLine(txtIdPayment.Text + "#" + txtIdTreatment.Text + "#" + txtPatientName.Text + "#" + txtDoctorName.Text + "#" + txtDiagnose.Text + "#" + txtDateTreatment.Text + "#" + txtPaymentDoctor.Text + "#" + txtPaymentDrug.Text + "#" + txtTotalPayment.Text + "#");

                        sw.Flush();
                        sw.Close();
                        fs.Close();

                        DialogResult dr = MessageBox.Show("Data has been saved, Print the data?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            
                            /*ileStream fs2 = new FileStream("Data\\recipedetail.txt", FileMode.Open, FileAccess.Read);
                            StreamReader sr2 = new StreamReader(fs2);
                            while((str = sr2.ReadLine()) != null)
                            {
                                if (str.Contains(recipe))
                                {
                                    string[] isi = str.Split('#');
                                    //idrecipe = isi[1];
                                    dosis = isi[3];
                                    drugqty = isi[4];
                                    subdrug = isi[5];
                                }
                            }
                            sr2.Close();
                            fs2.Close();*/
                            //MessageBox.Show("Printernya belum jadi:p");
                            FCashierReciptPayment fcrp = new FCashierReciptPayment();
                            CRReciptPayment crrp = new CRReciptPayment();
                            TextObject to = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["IdPayment"];
                            to.Text = txtIdPayment.Text;
                            TextObject totreatment = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["IdTreatment"];
                            totreatment.Text = txtIdTreatment.Text;
                            TextObject topatientname = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["PatientName"];
                            topatientname.Text = txtPatientName.Text;
                            TextObject todoctorname = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["DoctorName"];
                            todoctorname.Text = txtDoctorName.Text;
                            TextObject toidrecipe = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["IdRecipe"];
                            toidrecipe.Text = recipe;
                            TextObject todiagnose = (TextObject)crrp.ReportDefinition.Sections["Section2"].ReportObjects["Diagnose"];
                            todiagnose.Text = txtDiagnose.Text;
                            //details drug
                            TextObject topaydrug = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["PaymentDrug"];
                            topaydrug.Text = txtPaymentDrug.Text;
                            TextObject topaydoc = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["PaymentDoctor"];
                            topaydoc.Text = txtPaymentDoctor.Text;
                            TextObject totalpay = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["TotalPayment"];
                            totalpay.Text = txtTotalPayment.Text;
                            TextObject tomoney = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["Moneyy"];
                            tomoney.Text = txtMoney.Text;
                            TextObject tochange = (TextObject)crrp.ReportDefinition.Sections["Section4"].ReportObjects["Changee"];
                            tochange.Text = txtChange.Text;
                            /*
                            FileStream fs1 = new FileStream("Data\\drug.txt", FileMode.Open, FileAccess.Read);
                            StreamReader sr1 = new StreamReader(fs1);
                            while ((str = sr1.ReadLine()) != null)
                            {
                                if (str.Contains(iddrug))
                                {
                                    string[] isi = str.Split('#');
                                    //namaobat = isi[1];
                                    //crrp.SetParameterValue("?DrugName", new string[] { isi[1] });
                                }
                            }
                            sr1.Close();
                            fs1.Close();
                            */
                            //crrp.SetParameterValue("?DrugName", new string[] {"test1" , "test2"});
                            //crrp.SetParameterValue("pDose1", dosis);
                            //crrp.SetParameterValue("pQty1", drugqty);
                            //crrp.SetParameterValue("pSub1", subdrug);
                            fcrp.crystalReportViewer1.ReportSource = crrp;
                            fcrp.crystalReportViewer1.Refresh();
                            fcrp.Show();
                            this.Hide();
                        }

                        txtTotalPayment.Clear();
                        txtPaymentDrug.Clear();
                        txtPaymentDoctor.Clear();
                        txtIdTreatment.Clear();
                        txtIdPayment.Clear();
                        txtPatientName.Clear();
                        txtDoctorName.Clear();
                        txtDiagnose.Clear();
                        txtDateTreatment.Clear();
                        txtMoney.Focus();

                        txtIdPayment.Text = payment();
                    }
                }
            }
        }
    }
}
