namespace ProGestionGSB.GUI
{
    partial class FrmUpdateAssociation
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboAssociation = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.cboMission = new System.Windows.Forms.ComboBox();
            this.lblMission = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(278, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Modifier une association";
            // 
            // cboAssociation
            // 
            this.cboAssociation.FormattingEnabled = true;
            this.cboAssociation.Location = new System.Drawing.Point(592, 116);
            this.cboAssociation.Name = "cboAssociation";
            this.cboAssociation.Size = new System.Drawing.Size(177, 21);
            this.cboAssociation.TabIndex = 1;
            this.cboAssociation.SelectionChangeCommitted += new System.EventHandler(this.cboAssociation_SelectionChangeCommitted);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(592, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 7;
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
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.cboMission);
            this.grpUpdate.Controls.Add(this.lblMission);
            this.grpUpdate.Controls.Add(this.cboCountry);
            this.grpUpdate.Controls.Add(this.lblCountry);
            this.grpUpdate.Controls.Add(this.txtResponsable);
            this.grpUpdate.Controls.Add(this.label1);
            this.grpUpdate.Controls.Add(this.lblName);
            this.grpUpdate.Controls.Add(this.txtName);
            this.grpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpUpdate.Location = new System.Drawing.Point(56, 107);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(530, 249);
            this.grpUpdate.TabIndex = 5;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Formulaire de modification";
            // 
            // cboMission
            // 
            this.cboMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMission.FormattingEnabled = true;
            this.cboMission.Location = new System.Drawing.Point(250, 166);
            this.cboMission.Name = "cboMission";
            this.cboMission.Size = new System.Drawing.Size(261, 28);
            this.cboMission.TabIndex = 8;
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(246, 143);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(174, 20);
            this.lblMission.TabIndex = 7;
            this.lblMission.Text = "Mission de l\'association";
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(250, 73);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(261, 28);
            this.cboCountry.TabIndex = 6;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(246, 50);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(218, 20);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Pays d\'origine de l\'association";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(19, 166);
            this.txtResponsable.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(200, 26);
            this.txtResponsable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du responsable";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nom de l\'association";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(19, 73);
            this.txtName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 0;
            // 
            // FrmUpdateAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.cboAssociation);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmUpdateAssociation";
            this.Text = "Modifier une association";
            this.Load += new System.EventHandler(this.FrmUpdateAssociation_Load);
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboAssociation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.ComboBox cboMission;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}