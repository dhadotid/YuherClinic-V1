﻿namespace Yuher_Clinic
{
    partial class FCashierPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCashierPayment));
            this.label10 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblNullMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.txtPaymentDrug = new System.Windows.Forms.TextBox();
            this.txtPaymentDoctor = new System.Windows.Forms.TextBox();
            this.txtIdTreatment = new System.Windows.Forms.TextBox();
            this.txtIdPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiagnose = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDateTreatment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 26);
            this.label10.TabIndex = 48;
            this.label10.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(216, 471);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(206, 30);
            this.txtChange.TabIndex = 47;
            // 
            // lblNullMoney
            // 
            this.lblNullMoney.AutoSize = true;
            this.lblNullMoney.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullMoney.ForeColor = System.Drawing.Color.Red;
            this.lblNullMoney.Location = new System.Drawing.Point(212, 446);
            this.lblNullMoney.Name = "lblNullMoney";
            this.lblNullMoney.Size = new System.Drawing.Size(211, 22);
            this.lblNullMoney.TabIndex = 46;
            this.lblNullMoney.Text = "*Please fill in the data correctly";
            this.lblNullMoney.Visible = false;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(217, 413);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(206, 30);
            this.txtMoney.TabIndex = 45;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoney_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 26);
            this.label9.TabIndex = 44;
            this.label9.Text = "Money";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(363, 9);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 43;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 26);
            this.label7.TabIndex = 42;
            this.label7.Text = "Save && Print";
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(322, 507);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(100, 84);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 41;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Enabled = false;
            this.txtTotalPayment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayment.Location = new System.Drawing.Point(217, 377);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(206, 30);
            this.txtTotalPayment.TabIndex = 40;
            // 
            // txtPaymentDrug
            // 
            this.txtPaymentDrug.Enabled = false;
            this.txtPaymentDrug.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentDrug.Location = new System.Drawing.Point(217, 341);
            this.txtPaymentDrug.Name = "txtPaymentDrug";
            this.txtPaymentDrug.Size = new System.Drawing.Size(206, 30);
            this.txtPaymentDrug.TabIndex = 39;
            // 
            // txtPaymentDoctor
            // 
            this.txtPaymentDoctor.Enabled = false;
            this.txtPaymentDoctor.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentDoctor.Location = new System.Drawing.Point(217, 305);
            this.txtPaymentDoctor.Name = "txtPaymentDoctor";
            this.txtPaymentDoctor.Size = new System.Drawing.Size(206, 30);
            this.txtPaymentDoctor.TabIndex = 38;
            // 
            // txtIdTreatment
            // 
            this.txtIdTreatment.Enabled = false;
            this.txtIdTreatment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTreatment.Location = new System.Drawing.Point(217, 121);
            this.txtIdTreatment.Name = "txtIdTreatment";
            this.txtIdTreatment.Size = new System.Drawing.Size(206, 30);
            this.txtIdTreatment.TabIndex = 37;
            // 
            // txtIdPayment
            // 
            this.txtIdPayment.Enabled = false;
            this.txtIdPayment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPayment.Location = new System.Drawing.Point(217, 85);
            this.txtIdPayment.Name = "txtIdPayment";
            this.txtIdPayment.Size = new System.Drawing.Size(206, 30);
            this.txtIdPayment.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Payment Drug";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Payment Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id Treatment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Payment";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(217, 157);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(206, 30);
            this.txtPatientName.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 26);
            this.label8.TabIndex = 49;
            this.label8.Text = "Patient Name";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(217, 193);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(206, 30);
            this.txtDoctorName.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 26);
            this.label11.TabIndex = 51;
            this.label11.Text = "Doctor Name";
            // 
            // txtDiagnose
            // 
            this.txtDiagnose.Enabled = false;
            this.txtDiagnose.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnose.Location = new System.Drawing.Point(217, 229);
            this.txtDiagnose.Name = "txtDiagnose";
            this.txtDiagnose.Size = new System.Drawing.Size(206, 30);
            this.txtDiagnose.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 26);
            this.label12.TabIndex = 53;
            this.label12.Text = "Diagnose";
            // 
            // txtDateTreatment
            // 
            this.txtDateTreatment.Enabled = false;
            this.txtDateTreatment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTreatment.Location = new System.Drawing.Point(216, 265);
            this.txtDateTreatment.Name = "txtDateTreatment";
            this.txtDateTreatment.Size = new System.Drawing.Size(206, 30);
            this.txtDateTreatment.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 26);
            this.label13.TabIndex = 55;
            this.label13.Text = "Date Treatment";
            // 
            // FCashierPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(437, 628);
            this.Controls.Add(this.txtDateTreatment);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDiagnose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblNullMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.txtPaymentDrug);
            this.Controls.Add(this.txtPaymentDoctor);
            this.Controls.Add(this.txtIdTreatment);
            this.Controls.Add(this.txtIdPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCashierPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCashierPayment";
            this.Load += new System.EventHandler(this.FCashierPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblNullMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.TextBox txtPaymentDrug;
        private System.Windows.Forms.TextBox txtPaymentDoctor;
        private System.Windows.Forms.TextBox txtIdTreatment;
        private System.Windows.Forms.TextBox txtIdPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiagnose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDateTreatment;
        private System.Windows.Forms.Label label13;
    }
}