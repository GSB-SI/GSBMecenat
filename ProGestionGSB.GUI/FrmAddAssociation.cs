using ProGestionGSB.BLL;
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
    public partial class FrmAddAssociation : Form
    {
        public FrmAddAssociation()
        {
            InitializeComponent();

            cboMission.DataSource = MissionManager.GetInstance().GetMissions();
            cboMission.DisplayMember = "libel";
            cboMission.ValueMember = "id";
            cboMission.SelectedIndex = -1;

            cboCountry.DataSource = CountryManager.GetInstance().GetCountries();
            cboCountry.DisplayMember = "name";
            cboCountry.ValueMember = "id";
            cboCountry.SelectedIndex = -1;

        }

        private void FrmAddAssociations_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                erreurs += "Le nom du responsable est obligatoire\n";
                txtResponsable.Focus();
            }
           
            if (cboCountry.SelectedIndex == -1)
            {
                erreurs += "Le pays d'origine doit être renseigné\n";
            }
            if (cboMission.SelectedIndex == -1)
            {
                erreurs += "La mission de l'association doit être renseignée\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtName.Text;
                string responsable = txtResponsable.Text;
                int mission_id = Convert.ToInt32(cboMission.SelectedValue.ToString());
                int country_id = Convert.ToInt32(cboCountry.SelectedValue.ToString());
                AssociationManager.GetInstance().AddAssociation(name,responsable,mission_id,country_id);
                MessageBox.Show("Association ajoutée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = "";
                txtResponsable.Text = "";
                cboCountry.SelectedIndex = -1;
                cboMission.SelectedIndex = -1;
            }
        }
    }
}
