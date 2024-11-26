namespace ProGestionGSB.GUI
{
    partial class FrmShowActionByAssociation
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
            this.cboAssociation = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvActions = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAssociation
            // 
            this.cboAssociation.FormattingEnabled = true;
            this.cboAssociation.Location = new System.Drawing.Point(320, 104);
            this.cboAssociation.Name = "cboAssociation";
            this.cboAssociation.Size = new System.Drawing.Size(177, 21);
            this.cboAssociation.TabIndex = 14;
            this.cboAssociation.SelectionChangeCommitted += new System.EventHandler(this.cboAssociation_SelectionChangeCommitted);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(148, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 58);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Liste des actions de mécénat en partenariat\r\n avec une association sélectionnée";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvActions
            // 
            this.dgvActions.AllowUserToAddRows = false;
            this.dgvActions.AllowUserToDeleteRows = false;
            this.dgvActions.AllowUserToResizeColumns = false;
            this.dgvActions.AllowUserToResizeRows = false;
            this.dgvActions.BackgroundColor = System.Drawing.Color.White;
            this.dgvActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActions.Location = new System.Drawing.Point(143, 131);
            this.dgvActions.Name = "dgvActions";
            this.dgvActions.ReadOnly = true;
            this.dgvActions.Size = new System.Drawing.Size(530, 246);
            this.dgvActions.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(320, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmShowActionByAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvActions);
            this.Controls.Add(this.cboAssociation);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmShowActionByAssociation";
            this.Text = "Liste des actions de mécénat menées en partenariat avec une association sélection" +
    "née";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboAssociation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvActions;
        private System.Windows.Forms.Button btnClose;
    }
}