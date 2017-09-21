namespace Yuher_Clinic
{
    partial class FAdminSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.pbPayment = new System.Windows.Forms.PictureBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.pbRecipe = new System.Windows.Forms.PictureBox();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.pbTreatment = new System.Windows.Forms.PictureBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTreatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // pbPayment
            // 
            this.pbPayment.Image = ((System.Drawing.Image)(resources.GetObject("pbPayment.Image")));
            this.pbPayment.Location = new System.Drawing.Point(417, 116);
            this.pbPayment.Name = "pbPayment";
            this.pbPayment.Size = new System.Drawing.Size(100, 87);
            this.pbPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPayment.TabIndex = 1;
            this.pbPayment.TabStop = false;
            this.pbPayment.Click += new System.EventHandler(this.pbPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(428, 206);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(80, 26);
            this.lblPayment.TabIndex = 2;
            this.lblPayment.Text = "Payment";
            // 
            // pbRecipe
            // 
            this.pbRecipe.Image = ((System.Drawing.Image)(resources.GetObject("pbRecipe.Image")));
            this.pbRecipe.Location = new System.Drawing.Point(219, 116);
            this.pbRecipe.Name = "pbRecipe";
            this.pbRecipe.Size = new System.Drawing.Size(100, 87);
            this.pbRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecipe.TabIndex = 3;
            this.pbRecipe.TabStop = false;
            this.pbRecipe.Click += new System.EventHandler(this.pbRecipe_Click);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(237, 206);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(63, 26);
            this.lblRecipe.TabIndex = 4;
            this.lblRecipe.Text = "Recipe";
            // 
            // pbTreatment
            // 
            this.pbTreatment.Image = ((System.Drawing.Image)(resources.GetObject("pbTreatment.Image")));
            this.pbTreatment.Location = new System.Drawing.Point(12, 116);
            this.pbTreatment.Name = "pbTreatment";
            this.pbTreatment.Size = new System.Drawing.Size(100, 87);
            this.pbTreatment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTreatment.TabIndex = 5;
            this.pbTreatment.TabStop = false;
            this.pbTreatment.Click += new System.EventHandler(this.pbTreatment_Click);
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(14, 206);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(91, 26);
            this.lblTreatment.TabIndex = 6;
            this.lblTreatment.Text = "Treatment";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(462, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 7;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // FAdminSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(533, 243);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.pbTreatment);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.pbRecipe);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.pbPayment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAdminSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminSearch";
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTreatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.PictureBox pbRecipe;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.PictureBox pbTreatment;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.PictureBox pbBack;
    }
}