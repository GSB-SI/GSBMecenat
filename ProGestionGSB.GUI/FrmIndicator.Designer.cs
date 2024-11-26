namespace ProGestionGSB.GUI
{
    partial class FrmIndicator
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvNbAssociationByCountry = new System.Windows.Forms.DataGridView();
            this.dgvNbPartnershipsByActionByYear = new System.Windows.Forms.DataGridView();
            this.lblNbAssociationByCountry = new System.Windows.Forms.Label();
            this.lblNbPartnershipsByActionByYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNbAssociationByCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNbPartnershipsByActionByYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Indicateurs";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(301, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvNbAssociationByCountry
            // 
            this.dgvNbAssociationByCountry.AllowUserToAddRows = false;
            this.dgvNbAssociationByCountry.AllowUserToDeleteRows = false;
            this.dgvNbAssociationByCountry.AllowUserToResizeColumns = false;
            this.dgvNbAssociationByCountry.AllowUserToResizeRows = false;
            this.dgvNbAssociationByCountry.BackgroundColor = System.Drawing.Color.White;
            this.dgvNbAssociationByCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNbAssociationByCountry.Location = new System.Drawing.Point(12, 118);
            this.dgvNbAssociationByCountry.Name = "dgvNbAssociationByCountry";
            this.dgvNbAssociationByCountry.ReadOnly = true;
            this.dgvNbAssociationByCountry.Size = new System.Drawing.Size(379, 246);
            this.dgvNbAssociationByCountry.TabIndex = 6;
            // 
            // dgvNbPartnershipsByActionByYear
            // 
            this.dgvNbPartnershipsByActionByYear.AllowUserToAddRows = false;
            this.dgvNbPartnershipsByActionByYear.AllowUserToDeleteRows = false;
            this.dgvNbPartnershipsByActionByYear.AllowUserToResizeColumns = false;
            this.dgvNbPartnershipsByActionByYear.AllowUserToResizeRows = false;
            this.dgvNbPartnershipsByActionByYear.BackgroundColor = System.Drawing.Color.White;
            this.dgvNbPartnershipsByActionByYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNbPartnershipsByActionByYear.Location = new System.Drawing.Point(409, 118);
            this.dgvNbPartnershipsByActionByYear.Name = "dgvNbPartnershipsByActionByYear";
            this.dgvNbPartnershipsByActionByYear.ReadOnly = true;
            this.dgvNbPartnershipsByActionByYear.Size = new System.Drawing.Size(379, 246);
            this.dgvNbPartnershipsByActionByYear.TabIndex = 12;
            // 
            // lblNbAssociationByCountry
            // 
            this.lblNbAssociationByCountry.AutoSize = true;
            this.lblNbAssociationByCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbAssociationByCountry.Location = new System.Drawing.Point(8, 95);
            this.lblNbAssociationByCountry.Name = "lblNbAssociationByCountry";
            this.lblNbAssociationByCountry.Size = new System.Drawing.Size(225, 20);
            this.lblNbAssociationByCountry.TabIndex = 13;
            this.lblNbAssociationByCountry.Text = "Nombre d\'association par pays";
            // 
            // lblNbPartnershipsByActionByYear
            // 
            this.lblNbPartnershipsByActionByYear.AutoSize = true;
            this.lblNbPartnershipsByActionByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPartnershipsByActionByYear.Location = new System.Drawing.Point(572, 75);
            this.lblNbPartnershipsByActionByYear.Name = "lblNbPartnershipsByActionByYear";
            this.lblNbPartnershipsByActionByYear.Size = new System.Drawing.Size(216, 40);
            this.lblNbPartnershipsByActionByYear.TabIndex = 14;
            this.lblNbPartnershipsByActionByYear.Text = "Nombre de partenariat par \r\naction de mécénat par année";
            // 
            // FrmIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNbPartnershipsByActionByYear);
            this.Controls.Add(this.lblNbAssociationByCountry);
            this.Controls.Add(this.dgvNbPartnershipsByActionByYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvNbAssociationByCountry);
            this.Name = "FrmIndicator";
            this.Text = "Indicateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNbAssociationByCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNbPartnershipsByActionByYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvNbAssociationByCountry;
        private System.Windows.Forms.DataGridView dgvNbPartnershipsByActionByYear;
        private System.Windows.Forms.Label lblNbAssociationByCountry;
        private System.Windows.Forms.Label lblNbPartnershipsByActionByYear;
    }
}