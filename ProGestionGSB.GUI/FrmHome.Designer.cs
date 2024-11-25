namespace ProGestionGSB.GUI
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageAssociations = new System.Windows.Forms.Button();
            this.btnManagePartnerships = new System.Windows.Forms.Button();
            this.btnManagePlafonds = new System.Windows.Forms.Button();
            this.btnShowActionsByAssociation = new System.Windows.Forms.Button();
            this.btnShowIndicators = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(216, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GSB Mécénat";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(67, 125);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(160, 85);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Gestion des utilisateurs";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnManageAssociations
            // 
            this.btnManageAssociations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAssociations.Location = new System.Drawing.Point(355, 126);
            this.btnManageAssociations.Name = "btnManageAssociations";
            this.btnManageAssociations.Size = new System.Drawing.Size(160, 85);
            this.btnManageAssociations.TabIndex = 2;
            this.btnManageAssociations.Text = "Gestion des associations";
            this.btnManageAssociations.UseVisualStyleBackColor = true;
            this.btnManageAssociations.Click += new System.EventHandler(this.btnManageAssociations_Click);
            // 
            // btnManagePartnerships
            // 
            this.btnManagePartnerships.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePartnerships.Location = new System.Drawing.Point(67, 250);
            this.btnManagePartnerships.Name = "btnManagePartnerships";
            this.btnManagePartnerships.Size = new System.Drawing.Size(160, 85);
            this.btnManagePartnerships.TabIndex = 3;
            this.btnManagePartnerships.Text = "Gestion des partenariats";
            this.btnManagePartnerships.UseVisualStyleBackColor = true;
            this.btnManagePartnerships.Click += new System.EventHandler(this.btnManagePartnerships_Click);
            // 
            // btnManagePlafonds
            // 
            this.btnManagePlafonds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePlafonds.Location = new System.Drawing.Point(355, 250);
            this.btnManagePlafonds.Name = "btnManagePlafonds";
            this.btnManagePlafonds.Size = new System.Drawing.Size(160, 85);
            this.btnManagePlafonds.TabIndex = 4;
            this.btnManagePlafonds.Text = "Gestion des plafonds de mécénat";
            this.btnManagePlafonds.UseVisualStyleBackColor = true;
            // 
            // btnShowActionsByAssociation
            // 
            this.btnShowActionsByAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowActionsByAssociation.Location = new System.Drawing.Point(67, 375);
            this.btnShowActionsByAssociation.Name = "btnShowActionsByAssociation";
            this.btnShowActionsByAssociation.Size = new System.Drawing.Size(160, 85);
            this.btnShowActionsByAssociation.TabIndex = 5;
            this.btnShowActionsByAssociation.Text = "Consultation de la liste des actions de mécénat par association";
            this.btnShowActionsByAssociation.UseVisualStyleBackColor = true;
            // 
            // btnShowIndicators
            // 
            this.btnShowIndicators.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowIndicators.Location = new System.Drawing.Point(355, 375);
            this.btnShowIndicators.Name = "btnShowIndicators";
            this.btnShowIndicators.Size = new System.Drawing.Size(160, 85);
            this.btnShowIndicators.TabIndex = 6;
            this.btnShowIndicators.Text = "Indicateurs";
            this.btnShowIndicators.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(221, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 57);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 617);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowIndicators);
            this.Controls.Add(this.btnShowActionsByAssociation);
            this.Controls.Add(this.btnManagePlafonds);
            this.Controls.Add(this.btnManagePartnerships);
            this.Controls.Add(this.btnManageAssociations);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmHome";
            this.Text = "Accueil GSB Mécénat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageAssociations;
        private System.Windows.Forms.Button btnManagePartnerships;
        private System.Windows.Forms.Button btnManagePlafonds;
        private System.Windows.Forms.Button btnShowActionsByAssociation;
        private System.Windows.Forms.Button btnShowIndicators;
        private System.Windows.Forms.Button btnExit;
    }
}

