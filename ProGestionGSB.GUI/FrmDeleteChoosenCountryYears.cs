using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmDeleteChoosenCountryYears : Form
    {
        public FrmDeleteChoosenCountryYears()
        {
            InitializeComponent();

            cboContrats.DataSource = ChoosenCountryYearsManager.GetInstance().GetAll();
            cboContrats.DisplayMember = "CountryNameYear";
            cboContrats.ValueMember = "CountryNameYear";
            cboContrats.SelectedIndex = -1;
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

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, System.EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text.ToString());
            int pays_id = Convert.ToInt32(cboCountry.SelectedValue.ToString());
            ChoosenCountryYearsManager.GetInstance().DeleteChoosenCountryYear(pays_id, year);
            MessageBox.Show("Contrat supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPlafond.Text = "";
            txtYear.Text = "";
            cboCountry.SelectedIndex = -1;
        }
    }
}
