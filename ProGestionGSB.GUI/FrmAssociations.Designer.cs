namespace ProGestionGSB.GUI
{
    partial class FrmAssociations
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
            this.dgvAssociations = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.brtnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssociations
            // 
            this.dgvAssociations.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssociations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociations.Location = new System.Drawing.Point(44, 115);
            this.dgvAssociations.Name = "dgvAssociations";
            this.dgvAssociations.Size = new System.Drawing.Size(529, 246);
            this.dgvAssociations.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(592, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // brtnUpdate
            // 
            this.brtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brtnUpdate.Location = new System.Drawing.Point(592, 178);
            this.brtnUpdate.Name = "brtnUpdate";
            this.brtnUpdate.Size = new System.Drawing.Size(177, 57);
            this.brtnUpdate.TabIndex = 2;
            this.brtnUpdate.Text = "Modifier";
            this.brtnUpdate.UseVisualStyleBackColor = true;
            this.brtnUpdate.Click += new System.EventHandler(this.brtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(592, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(592, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des associations";
            // 
            // FrmAssociations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.brtnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAssociations);
            this.Name = "FrmAssociations";
            this.Text = "Gestion des associations";
            this.Load += new System.EventHandler(this.FrmAssociations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssociations;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button brtnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}