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
    public partial class FrmDeleteAssociation : Form
    {
        public FrmDeleteAssociation()
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

            txtName.Enabled = false;
            txtResponsable.Enabled = false;
            cboCountry.Enabled = false;
            cboMission.Enabled = false;

            
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
                Association Asso = (Association)cboAssociation.SelectedItem;
                txtName.Text = Asso.name;
                txtResponsable.Text = Asso.responsable;
                cboCountry.SelectedValue = Asso.country_id;
                cboMission.SelectedValue = Asso.mission_id;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboAssociation.SelectedIndex==-1)
            {
                MessageBox.Show("Veuillez sélectionner une association pour supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Association Asso = (Association)cboAssociation.SelectedItem;
                AssociationManager.GetInstance().DeleteAssociations(Asso);
                MessageBox.Show("Association supprimée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillAssociation();
            }

        }

        private void FrmDeleteAssociation_Load(object sender, EventArgs e)
        {

        }
    }
}
