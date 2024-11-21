using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmUpdateAssociation : Form
    {
        public FrmUpdateAssociation()
        {
            InitializeComponent();
            cboCountry.DataSource = CountryManager.GetInstance().GetCountries();
            cboCountry.DisplayMember = "name";
            cboCountry.ValueMember = "id";
            cboCountry.SelectedIndex = -1;

            cboMission.DataSource = MissionManager.GetInstance().GetMissions();
            cboMission.DisplayMember = "libel";
            cboMission.ValueMember = "id";
            cboMission.SelectedIndex = -1;
            fillAssociation();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fillAssociation()
        {
            cboAssociation.DataSource = AssociationManager.GetInstance().GetAssociations();
            cboAssociation.DisplayMember = "name";
            cboAssociation.ValueMember = "id";
            cboAssociation.SelectedIndex = -1;
            txtName.Text = "";
            txtResponsable.Text = "";
            cboCountry.SelectedIndex = -1;
            cboMission.SelectedIndex = -1;
        }

        private void cboAssociation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboAssociation.SelectedIndex != -1)
            {
                Association Asso= (Association)cboAssociation.SelectedItem;
                txtName.Text = Asso.name;
                txtResponsable.Text = Asso.responsable;
                cboCountry.SelectedValue = Asso.country_id;
                cboMission.SelectedValue = Asso.mission_id;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                erreurs += "Le nom de l'association doit être renseigné\n";
                txtName.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtResponsable.Text) == true)
            {
                erreurs += "Le nom du responsable doit être renseigné\n";
                txtResponsable.Focus();
            }
            
            if (cboMission.SelectedIndex == -1)
            {
                erreurs += "La mission de l'association doit être renseignée\n";
            }
            if (cboCountry.SelectedIndex == -1)
            {
                erreurs += "Le pays d'origine de l'association doit être renseignée\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Enregistrement du produit dans la BDD
                int id = Convert.ToInt32(cboAssociation.SelectedValue.ToString());
                string name = txtName.Text;
                string responsable = txtResponsable.Text;
                int mission_id = Convert.ToInt32(cboMission.SelectedValue.ToString());
                int country_id = Convert.ToInt32(cboCountry.SelectedValue.ToString());

                AssociationManager.GetInstance().UpdateAssociations(id,name,responsable,mission_id,country_id);
                MessageBox.Show("Produit modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillAssociation();
            }
        }

        private void FrmUpdateAssociation_Load(object sender, EventArgs e)
        {

        }
    }
}
