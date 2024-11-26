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
using System.Xml.Linq;

namespace ProGestionGSB.GUI
{
    public partial class FrmUpdatePartnership : Form
    {
        public FrmUpdatePartnership()
        {
            InitializeComponent();
            cboCountry.DataSource = CountryManager.GetInstance().GetCountries();
            cboCountry.DisplayMember = "name";
            cboCountry.ValueMember = "id";
            cboCountry.SelectedIndex = -1;

            cboAssociation.DataSource = AssociationManager.GetInstance().GetAssociations();
            cboAssociation.DisplayMember = "name";
            cboAssociation.ValueMember = "id";
            cboAssociation.SelectedIndex = -1;

            cboAction.DataSource = ActionManager.GetInstance().GetActions();
            cboAction.DisplayMember = "libel";
            cboAction.ValueMember = "id";
            cboAction.SelectedIndex = -1;

            fillPartnership();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fillPartnership()
        {
            cboPartnerships.DataSource = PartnershipManager.GetInstance().GetPartnerships();
            cboPartnerships.DisplayMember = "CountryNameDate";
            cboPartnerships.ValueMember = "id";
            cboPartnerships.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            cboAction.SelectedIndex = -1;
            cboAssociation.SelectedIndex = -1;
        }

        private void cboPartnerships_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboPartnerships.SelectedIndex != -1)
            {
                Partnership Part = (Partnership)cboPartnerships.SelectedItem;
                cboCountry.SelectedValue = Part.country_id;
                cboAction.SelectedValue = Part.action_id;
                cboAssociation.SelectedValue = Part.association_id;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (cboPartnerships.SelectedIndex == -1)
            {
                erreurs += "Veuillez sélectionner un partenariat pour modifier\n";
            }
            if (cboAssociation.SelectedIndex == -1)
            {
                erreurs += "L'association partenaire doit être renseignée\n";
            }
            if (cboCountry.SelectedIndex == -1)
            {
                erreurs += "Le pays doit être renseignée\n";
            }
            if (cboAction.SelectedIndex == -1)
            {
                erreurs += "L'action de mécénat doit être renseignée\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(cboPartnerships.SelectedValue.ToString());
                int action_id = Convert.ToInt32(cboAction.SelectedValue.ToString());
                int association_id = Convert.ToInt32(cboAssociation.SelectedValue.ToString());
                int country_id = Convert.ToInt32(cboCountry.SelectedValue.ToString());

                PartnershipManager.GetInstance().UpdatePartnership(id, action_id, country_id, association_id);
                MessageBox.Show("Partenariat modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillPartnership();
            }
        }
    }
}
