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
    public partial class FrmDeletePartnership : Form
    {
        public FrmDeletePartnership()
        {
            InitializeComponent();

            cboAction.Enabled = false;
            cboAssociation.Enabled = false;
            cboCountry.Enabled = false;

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

        private void FrmDeletePartnership_Load(object sender, EventArgs e)
        {

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cboPartnerships.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un partenariat pour supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Partnership Part= (Partnership)cboPartnerships.SelectedItem;
                PartnershipManager.GetInstance().DeletePartnership(Part);
                MessageBox.Show("Partenariat supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillPartnership();
            }

        }
    }
}
