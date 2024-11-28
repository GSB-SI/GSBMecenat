using ProGestionGSB.BLL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmAddChoosenCountryYears : Form
    {
        public FrmAddChoosenCountryYears()
        {
            InitializeComponent();
            cboCountry.DataSource = CountryManager.GetInstance().GetCountries();
            cboCountry.DisplayMember = "name";
            cboCountry.ValueMember = "id";
            cboCountry.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
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
                int year = Convert.ToInt32(txtYear.Text.ToString());
                double plafond = Convert.ToInt32(txtPlafond.Text.ToString());
                int pays_id = Convert.ToInt32(cboCountry.SelectedValue.ToString());
                ChoosenCountryYearsManager.GetInstance().AddChoosenCountryYear(pays_id, year, plafond);
                MessageBox.Show("Contrat ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPlafond.Text = "";
                txtYear.Text = "";
                cboCountry.SelectedIndex = -1;
            }
        }
    }
}
