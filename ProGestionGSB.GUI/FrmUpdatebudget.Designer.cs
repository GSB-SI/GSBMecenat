namespace ProGestionGSB.GUI
{
    partial class FrmUpdatebudget
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
            this.cboPartnerships = new System.Windows.Forms.ComboBox();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.lblForecastBudget = new System.Windows.Forms.Label();
            this.txtForecastBudget = new System.Windows.Forms.TextBox();
            this.lblPlafond = new System.Windows.Forms.Label();
            this.txtPlafond = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRealBudget = new System.Windows.Forms.TextBox();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPartnerships
            // 
            this.cboPartnerships.FormattingEnabled = true;
            this.cboPartnerships.Location = new System.Drawing.Point(592, 116);
            this.cboPartnerships.Name = "cboPartnerships";
            this.cboPartnerships.Size = new System.Drawing.Size(177, 21);
            this.cboPartnerships.TabIndex = 17;
            this.cboPartnerships.SelectionChangeCommitted += new System.EventHandler(this.cboPartnerships_SelectedIndexChanged);
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.label1);
            this.gbForm.Controls.Add(this.txtRealBudget);
            this.gbForm.Controls.Add(this.lblForecastBudget);
            this.gbForm.Controls.Add(this.txtForecastBudget);
            this.gbForm.Controls.Add(this.lblPlafond);
            this.gbForm.Controls.Add(this.txtPlafond);
            this.gbForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbForm.Location = new System.Drawing.Point(56, 107);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(530, 249);
            this.gbForm.TabIndex = 16;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Formulaire de modifications";
            // 
            // lblForecastBudget
            // 
            this.lblForecastBudget.AutoSize = true;
            this.lblForecastBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecastBudget.Location = new System.Drawing.Point(15, 143);
            this.lblForecastBudget.Name = "lblForecastBudget";
            this.lblForecastBudget.Size = new System.Drawing.Size(100, 20);
            this.lblForecastBudget.TabIndex = 9;
            this.lblForecastBudget.Text = "Budget initial";
            // 
            // txtForecastBudget
            // 
            this.txtForecastBudget.BackColor = System.Drawing.Color.White;
            this.txtForecastBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForecastBudget.Location = new System.Drawing.Point(19, 166);
            this.txtForecastBudget.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtForecastBudget.Name = "txtForecastBudget";
            this.txtForecastBudget.Size = new System.Drawing.Size(200, 28);
            this.txtForecastBudget.TabIndex = 8;
            // 
            // lblPlafond
            // 
            this.lblPlafond.AutoSize = true;
            this.lblPlafond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlafond.Location = new System.Drawing.Point(15, 50);
            this.lblPlafond.Name = "lblPlafond";
            this.lblPlafond.Size = new System.Drawing.Size(63, 20);
            this.lblPlafond.TabIndex = 7;
            this.lblPlafond.Text = "Plafond";
            // 
            // txtPlafond
            // 
            this.txtPlafond.BackColor = System.Drawing.Color.White;
            this.txtPlafond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlafond.Location = new System.Drawing.Point(19, 73);
            this.txtPlafond.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtPlafond.Name = "txtPlafond";
            this.txtPlafond.Size = new System.Drawing.Size(200, 28);
            this.txtPlafond.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(592, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 15;
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
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(278, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 29);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Mettre à jour un budget";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Budget réel";
            // 
            // txtRealBudget
            // 
            this.txtRealBudget.BackColor = System.Drawing.Color.White;
            this.txtRealBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealBudget.Location = new System.Drawing.Point(282, 73);
            this.txtRealBudget.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtRealBudget.Name = "txtRealBudget";
            this.txtRealBudget.Size = new System.Drawing.Size(200, 28);
            this.txtRealBudget.TabIndex = 10;
            // 
            // FrmUpdatebudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboPartnerships);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmUpdatebudget";
            this.Text = "Mettre à jour les budgets";
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPartnerships;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Label lblForecastBudget;
        private System.Windows.Forms.TextBox txtForecastBudget;
        private System.Windows.Forms.Label lblPlafond;
        private System.Windows.Forms.TextBox txtPlafond;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRealBudget;
    }
}