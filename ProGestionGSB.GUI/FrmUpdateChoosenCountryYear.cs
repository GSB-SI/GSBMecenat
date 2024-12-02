using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmUpdateChoosenCountryYear : Form
    {

        public FrmUpdateChoosenCountryYear()
        {
            InitializeComponent();
            cboCountry.DataSource = CountryManager.GetInstance().GetCountries();
            cboCountry.DisplayMember = "name";
            cboCountry.ValueMember = "id";
            cboCountry.SelectedIndex = -1;

            cboContrats.DataSource = ChoosenCountryYearsManager.GetInstance().GetAll();
            cboContrats.DisplayMember = "CountryNameYear";
            cboContrats.ValueMember = "CountryNameYear";
            cboContrats.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtYear.Text) == true)
            {
                erreurs += "L'année doit être renseignée\n";
                txtYear.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtPlafond.Text) == true)
            {
                erreurs += "Le plafond doit être renseigné\n";
                txtPlafond.Focus();
            }
            if (cboCountry.SelectedIndex == -1)
            {
                erreurs += "Le pays doit être renseigné\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ChoosenCountryYear oldContrat = (ChoosenCountryYear)cboContrats.SelectedItem;
                int year = Convert.ToInt32(txtYear.Text.ToString());
                double plafond = Convert.ToInt32(txtPlafond.Text.ToString());
                int pays_id = Convert.ToInt32(cboCountry.SelectedValue.ToString());
                ChoosenCountryYearsManager.GetInstance().UpdateChoosenCountryYear(oldContrat.country_id, pays_id, oldContrat.choosenYear, year, plafond);
                MessageBox.Show("Contrat modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPlafond.Text = "";
                txtYear.Text = "";
                cboCountry.SelectedIndex = -1;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cboContrats_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (cboContrats.SelectedIndex != -1)
            {
                ChoosenCountryYear Part = (ChoosenCountryYear)cboContrats.SelectedItem;
                cboCountry.SelectedValue = Part.country_id;
                txtPlafond.Text = Part.plafond.ToString();
                txtYear.Text = Part.choosenYear.ToString();
            }
        }
    }
}
