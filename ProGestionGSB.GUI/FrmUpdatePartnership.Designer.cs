namespace ProGestionGSB.GUI
{
    partial class FrmUpdatePartnership
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.cboAssociation = new System.Windows.Forms.ComboBox();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAssociation = new System.Windows.Forms.Label();
            this.cboPartnerships = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(592, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(592, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 57);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.cboAssociation);
            this.grpUpdate.Controls.Add(this.cboAction);
            this.grpUpdate.Controls.Add(this.lblAction);
            this.grpUpdate.Controls.Add(this.cboCountry);
            this.grpUpdate.Controls.Add(this.lblCountry);
            this.grpUpdate.Controls.Add(this.lblAssociation);
            this.grpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpUpdate.Location = new System.Drawing.Point(56, 107);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(530, 249);
            this.grpUpdate.TabIndex = 10;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Formulaire de modification";
            // 
            // cboAssociation
            // 
            this.cboAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAssociation.FormattingEnabled = true;
            this.cboAssociation.Location = new System.Drawing.Point(10, 73);
            this.cboAssociation.Name = "cboAssociation";
            this.cboAssociation.Size = new System.Drawing.Size(239, 28);
            this.cboAssociation.TabIndex = 15;
            // 
            // cboAction
            // 
            this.cboAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Location = new System.Drawing.Point(96, 162);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(261, 28);
            this.cboAction.TabIndex = 14;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(92, 139);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(142, 20);
            this.lblAction.TabIndex = 13;
            this.lblAction.Text = "Action de mécénat";
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(267, 73);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(244, 28);
            this.cboCountry.TabIndex = 12;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(263, 50);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 20);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Pays";
            // 
            // lblAssociation
            // 
            this.lblAssociation.AutoSize = true;
            this.lblAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociation.Location = new System.Drawing.Point(6, 50);
            this.lblAssociation.Name = "lblAssociation";
            this.lblAssociation.Size = new System.Drawing.Size(167, 20);
            this.lblAssociation.TabIndex = 10;
            this.lblAssociation.Text = "Association partenaire";
            // 
            // cboPartnerships
            // 
            this.cboPartnerships.FormattingEnabled = true;
            this.cboPartnerships.Location = new System.Drawing.Point(592, 116);
            this.cboPartnerships.Name = "cboPartnerships";
            this.cboPartnerships.Size = new System.Drawing.Size(177, 21);
            this.cboPartnerships.TabIndex = 9;
            this.cboPartnerships.SelectionChangeCommitted += new System.EventHandler(this.cboPartnerships_SelectionChangeCommitted);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(278, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 29);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Modifier un partenariat";
            // 
            // FrmUpdatePartnership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.cboPartnerships);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmUpdatePartnership";
            this.Text = "Modifier une partenariat";
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.ComboBox cboPartnerships;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboAssociation;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAssociation;
    }
}