using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmUpdatebudget : Form
    {
        public FrmUpdatebudget()
        {
            InitializeComponent();

            cboPartnerships.DataSource = PartnershipManager.GetInstance().GetPartnerships();
            cboPartnerships.DisplayMember = "CountryNameDate";
            cboPartnerships.ValueMember = "id";
            cboPartnerships.SelectedIndex = -1;
        }

        private void cboPartnerships_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Partnership partnership = (Partnership)cboPartnerships.SelectedItem;

            txtPlafond.Text = Convert.ToString(partnership.plafond);
            txtForecastBudget.Text = Convert.ToString(partnership.forecastBudget);
            txtRealBudget.Text = Convert.ToString(partnership.realBudget);
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            string erreurs = "";
            float? plafond = null;
            float? forecastBudget = null;
            float? realBudget = null;
            if (cboPartnerships.SelectedIndex == -1)
            {
                erreurs += "Veuillez sélectionner une association pour modifier\n";
            }
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPlafond.Text))
                {
                    plafond = Convert.ToSingle(txtPlafond.Text);
                }

                if (!string.IsNullOrEmpty(txtForecastBudget.Text))
                {
                    forecastBudget = Convert.ToSingle(txtForecastBudget.Text);
                }

                if (!string.IsNullOrEmpty(txtRealBudget.Text))
                {
                    realBudget = Convert.ToSingle(txtRealBudget.Text);
                }

                int partnership_id = Convert.ToInt32(cboPartnerships.SelectedValue.ToString());
                BudgetManager.GetInstance().UpdateAllPlafonds(partnership_id, plafond, forecastBudget, realBudget);
                MessageBox.Show("Budget modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPartnerships.DataSource = PartnershipManager.GetInstance().GetPartnerships();
                cboPartnerships.SelectedIndex = -1;


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
