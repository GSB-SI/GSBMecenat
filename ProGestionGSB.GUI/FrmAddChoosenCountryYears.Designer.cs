namespace ProGestionGSB.GUI
{
    partial class FrmAddChoosenCountryYears
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPlafond = new System.Windows.Forms.TextBox();
            this.lblPlafond = new System.Windows.Forms.Label();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(592, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(592, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 57);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.txtPlafond);
            this.grpAdd.Controls.Add(this.lblPlafond);
            this.grpAdd.Controls.Add(this.txtYear);
            this.grpAdd.Controls.Add(this.lblYear);
            this.grpAdd.Controls.Add(this.cboCountry);
            this.grpAdd.Controls.Add(this.lblCountry);
            this.grpAdd.Controls.Add(this.lblPays);
            this.grpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpAdd.Location = new System.Drawing.Point(56, 107);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(530, 249);
            this.grpAdd.TabIndex = 10;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Formulaire d\'ajout";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(10, 164);
            this.txtYear.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(239, 26);
            this.txtYear.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(6, 141);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 20);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Année";
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(10, 73);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(239, 28);
            this.cboCountry.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(263, 50);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 20);
            this.lblCountry.TabIndex = 5;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPays.Location = new System.Drawing.Point(6, 50);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(43, 20);
            this.lblPays.TabIndex = 2;
            this.lblPays.Text = "Pays";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(278, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 29);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Ajouter un contrat";
            // 
            // txtPlafond
            // 
            this.txtPlafond.BackColor = System.Drawing.Color.White;
            this.txtPlafond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlafond.Location = new System.Drawing.Point(267, 73);
            this.txtPlafond.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtPlafond.Name = "txtPlafond";
            this.txtPlafond.Size = new System.Drawing.Size(239, 28);
            this.txtPlafond.TabIndex = 13;
            // 
            // lblPlafond
            // 
            this.lblPlafond.AutoSize = true;
            this.lblPlafond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlafond.Location = new System.Drawing.Point(263, 50);
            this.lblPlafond.Name = "lblPlafond";
            this.lblPlafond.Size = new System.Drawing.Size(63, 20);
            this.lblPlafond.TabIndex = 12;
            this.lblPlafond.Text = "Plafond";
            // 
            // FrmAddChoosenCountryYears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmAddChoosenCountryYears";
            this.Text = "Ajouter un contrat";
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPlafond;
        private System.Windows.Forms.Label lblPlafond;
    }
}