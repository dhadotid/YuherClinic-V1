﻿namespace Yuher_Clinic
{
    partial class FCashierRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCashierRecipe));
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.dgvDrug = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblNullDose = new System.Windows.Forms.Label();
            this.lblNullDrug = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.txtDrug = new System.Windows.Forms.TextBox();
            this.txtIdRecipe = new System.Windows.Forms.TextBox();
            this.txtRD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(887, 10);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 49);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 53;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 26);
            this.label9.TabIndex = 52;
            this.label9.Text = "Save";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(768, 92);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(53, 43);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 51;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(320, 351);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(100, 93);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 50;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // dgvDrug
            // 
            this.dgvDrug.AllowUserToAddRows = false;
            this.dgvDrug.AllowUserToDeleteRows = false;
            this.dgvDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrug.Location = new System.Drawing.Point(426, 137);
            this.dgvDrug.Name = "dgvDrug";
            this.dgvDrug.ReadOnly = true;
            this.dgvDrug.Size = new System.Drawing.Size(520, 330);
            this.dgvDrug.TabIndex = 49;
            this.dgvDrug.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDrug_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(579, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 30);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 26);
            this.label8.TabIndex = 47;
            this.label8.Text = "Search";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Red;
            this.lblQty.Location = new System.Drawing.Point(208, 290);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(150, 22);
            this.lblQty.TabIndex = 46;
            this.lblQty.Text = "*Please fill in the data";
            this.lblQty.Visible = false;
            // 
            // lblNullDose
            // 
            this.lblNullDose.AutoSize = true;
            this.lblNullDose.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullDose.ForeColor = System.Drawing.Color.Red;
            this.lblNullDose.Location = new System.Drawing.Point(81, 232);
            this.lblNullDose.Name = "lblNullDose";
            this.lblNullDose.Size = new System.Drawing.Size(339, 22);
            this.lblNullDose.TabIndex = 45;
            this.lblNullDose.Text = "*Please fill in the data or inccorect format. Ex: 3X1";
            this.lblNullDose.Visible = false;
            // 
            // lblNullDrug
            // 
            this.lblNullDrug.AutoSize = true;
            this.lblNullDrug.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullDrug.ForeColor = System.Drawing.Color.Red;
            this.lblNullDrug.Location = new System.Drawing.Point(208, 174);
            this.lblNullDrug.Name = "lblNullDrug";
            this.lblNullDrug.Size = new System.Drawing.Size(135, 22);
            this.lblNullDrug.TabIndex = 44;
            this.lblNullDrug.Text = "*Please Select Drug";
            this.lblNullDrug.Visible = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(212, 315);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(208, 30);
            this.txtSubtotal.TabIndex = 43;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(212, 257);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(208, 30);
            this.txtQty.TabIndex = 42;
            //this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.Validating += new System.ComponentModel.CancelEventHandler(this.txtQty_Validating);
            // 
            // txtDose
            // 
            this.txtDose.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDose.Location = new System.Drawing.Point(212, 199);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(208, 30);
            this.txtDose.TabIndex = 41;
            this.txtDose.Validating += new System.ComponentModel.CancelEventHandler(this.txtDose_Validating);
            // 
            // txtDrug
            // 
            this.txtDrug.Enabled = false;
            this.txtDrug.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrug.Location = new System.Drawing.Point(212, 141);
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.Size = new System.Drawing.Size(208, 30);
            this.txtDrug.TabIndex = 40;
            this.txtDrug.Validating += new System.ComponentModel.CancelEventHandler(this.txtDrug_Validating);
            // 
            // txtIdRecipe
            // 
            this.txtIdRecipe.Enabled = false;
            this.txtIdRecipe.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRecipe.Location = new System.Drawing.Point(212, 105);
            this.txtIdRecipe.Name = "txtIdRecipe";
            this.txtIdRecipe.Size = new System.Drawing.Size(208, 30);
            this.txtIdRecipe.TabIndex = 39;
            // 
            // txtRD
            // 
            this.txtRD.Enabled = false;
            this.txtRD.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRD.Location = new System.Drawing.Point(212, 69);
            this.txtRD.Name = "txtRD";
            this.txtRD.Size = new System.Drawing.Size(208, 30);
            this.txtRD.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 26);
            this.label7.TabIndex = 37;
            this.label7.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "Dose";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Id Drug";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "Id Recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id Recipe Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "Recipe";
            // 
            // FCashierRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(958, 481);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.dgvDrug);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblNullDose);
            this.Controls.Add(this.lblNullDrug);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.txtDrug);
            this.Controls.Add(this.txtIdRecipe);
            this.Controls.Add(this.txtRD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCashierRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCashierRecipe";
            this.Load += new System.EventHandler(this.FCashierRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridView dgvDrug;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblNullDose;
        private System.Windows.Forms.Label lblNullDrug;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.TextBox txtDrug;
        private System.Windows.Forms.TextBox txtIdRecipe;
        private System.Windows.Forms.TextBox txtRD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}