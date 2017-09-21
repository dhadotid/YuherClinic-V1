namespace Yuher_Clinic
{
    partial class FAdminReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminReport));
            this.label1 = new System.Windows.Forms.Label();
            this.pbPayment = new System.Windows.Forms.PictureBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbDrug = new System.Windows.Forms.PictureBox();
            this.lblDrug = new System.Windows.Forms.Label();
            this.pbPatient = new System.Windows.Forms.PictureBox();
            this.lblPatient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // pbPayment
            // 
            this.pbPayment.Image = ((System.Drawing.Image)(resources.GetObject("pbPayment.Image")));
            this.pbPayment.Location = new System.Drawing.Point(399, 96);
            this.pbPayment.Name = "pbPayment";
            this.pbPayment.Size = new System.Drawing.Size(100, 92);
            this.pbPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPayment.TabIndex = 1;
            this.pbPayment.TabStop = false;
            this.pbPayment.Click += new System.EventHandler(this.pbPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(406, 191);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(80, 26);
            this.lblPayment.TabIndex = 2;
            this.lblPayment.Text = "Payment";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(462, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 69;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbDrug
            // 
            this.pbDrug.Image = ((System.Drawing.Image)(resources.GetObject("pbDrug.Image")));
            this.pbDrug.Location = new System.Drawing.Point(216, 96);
            this.pbDrug.Name = "pbDrug";
            this.pbDrug.Size = new System.Drawing.Size(100, 92);
            this.pbDrug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrug.TabIndex = 70;
            this.pbDrug.TabStop = false;
            this.pbDrug.Click += new System.EventHandler(this.pbDrug_Click);
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrug.Location = new System.Drawing.Point(236, 191);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(52, 26);
            this.lblDrug.TabIndex = 71;
            this.lblDrug.Text = "Drug";
            // 
            // pbPatient
            // 
            this.pbPatient.Image = ((System.Drawing.Image)(resources.GetObject("pbPatient.Image")));
            this.pbPatient.Location = new System.Drawing.Point(28, 96);
            this.pbPatient.Name = "pbPatient";
            this.pbPatient.Size = new System.Drawing.Size(100, 92);
            this.pbPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatient.TabIndex = 72;
            this.pbPatient.TabStop = false;
            this.pbPatient.Click += new System.EventHandler(this.pbPatient_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(43, 191);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(66, 26);
            this.lblPatient.TabIndex = 73;
            this.lblPatient.Text = "Patient";
            // 
            // FAdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(533, 226);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.pbPatient);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.pbDrug);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.pbPayment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminReport";
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbDrug;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.PictureBox pbPatient;
        private System.Windows.Forms.Label lblPatient;
    }
}