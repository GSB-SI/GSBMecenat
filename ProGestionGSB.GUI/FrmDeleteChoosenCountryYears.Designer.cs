namespace ProGestionGSB.GUI
{
    partial class FrmDeleteChoosenCountryYears
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.txtPlafond = new System.Windows.Forms.TextBox();
            this.lblPlafond = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.cboContrats = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(592, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(592, 142);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(177, 57);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.txtPlafond);
            this.grpUpdate.Controls.Add(this.lblPlafond);
            this.grpUpdate.Controls.Add(this.txtYear);
            this.grpUpdate.Controls.Add(this.lblYear);
            this.grpUpdate.Controls.Add(this.cboCountry);
            this.grpUpdate.Controls.Add(this.lblCountry);
            this.grpUpdate.Controls.Add(this.lblPays);
            this.grpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpUpdate.Location = new System.Drawing.Point(56, 107);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(530, 249);
            this.grpUpdate.TabIndex = 20;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Formulaire de suppression";
            // 
            // txtPlafond
            // 
            this.txtPlafond.BackColor = System.Drawing.Color.White;
            this.txtPlafond.Enabled = false;
            this.txtPlafond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlafond.Location = new System.Drawing.Point(276, 76);
            this.txtPlafond.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtPlafond.Name = "txtPlafond";
            this.txtPlafond.Size = new System.Drawing.Size(239, 26);
            this.txtPlafond.TabIndex = 20;
            // 
            // lblPlafond
            // 
            this.lblPlafond.AutoSize = true;
            this.lblPlafond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlafond.Location = new System.Drawing.Point(272, 53);
            this.lblPlafond.Name = "lblPlafond";
            this.lblPlafond.Size = new System.Drawing.Size(63, 20);
            this.lblPlafond.TabIndex = 19;
            this.lblPlafond.Text = "Plafond";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Enabled = false;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(19, 167);
            this.txtYear.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(239, 26);
            this.txtYear.TabIndex = 18;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(15, 144);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 20);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "Année";
            // 
            // cboCountry
            // 
            this.cboCountry.Enabled = false;
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(19, 76);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(239, 28);
            this.cboCountry.TabIndex = 16;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(272, 53);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 20);
            this.lblCountry.TabIndex = 15;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPays.Location = new System.Drawing.Point(15, 53);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(43, 20);
            this.lblPays.TabIndex = 14;
            this.lblPays.Text = "Pays";
            // 
            // cboContrats
            // 
            this.cboContrats.FormattingEnabled = true;
            this.cboContrats.Location = new System.Drawing.Point(592, 116);
            this.cboContrats.Name = "cboContrats";
            this.cboContrats.Size = new System.Drawing.Size(177, 21);
            this.cboContrats.TabIndex = 19;
            this.cboContrats.SelectionChangeCommitted += new System.EventHandler(this.cboContrats_SelectionChangeCommitted);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(278, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 29);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Supprimer les contrats";
            // 
            // FrmDeleteChoosenCountryYears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.cboContrats);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmDeleteChoosenCountryYears";
            this.Text = "Supprimer les contrats";
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox txtPlafond;
        private System.Windows.Forms.Label lblPlafond;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.ComboBox cboContrats;
        private System.Windows.Forms.Label lblTitle;
    }
}