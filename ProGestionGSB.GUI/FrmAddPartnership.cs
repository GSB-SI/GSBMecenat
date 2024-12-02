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
    public partial class FrmAddPartnership : Form
    {
        public FrmAddPartnership()
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddPartnership_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (cboAssociation.SelectedIndex == -1)
            {
                erreurs += "L'association doit être renseignée\n";
            }
            if (cboCountry.SelectedIndex == -1)
            {
                erreurs += "Le pays doit être renseigné\n";
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
                int action_id = Convert.ToInt32(cboAction.SelectedValue.ToString());
                int country_id = Convert.ToInt32(cboCountry.SelectedValue.ToString());
                int association_id = Convert.ToInt32(cboAssociation.SelectedValue.ToString());            
                int result = PartnershipManager.GetInstance().AddPartnership(action_id, country_id, association_id);
                MessageBox.Show("Partenariat enregistré", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCountry.SelectedIndex = -1;
                cboAction.SelectedIndex = -1;
                cboAssociation.SelectedIndex = -1;

            }
        }
    }
}
