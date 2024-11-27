using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System.Drawing;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmBudgets : Form
    {
        private User utilisateurAuthentifie;

        public FrmBudgets(User user)
        {
            InitializeComponent();
            utilisateurAuthentifie = user;

            dgvBudgets.DataSource = PartnershipManager.GetInstance().GetPartnerships();
            dgvBudgets.Columns["Action"].Visible = false;
            dgvBudgets.Columns["Association"].Visible = false;
            dgvBudgets.Columns["Country"].Visible = false;
            dgvBudgets.Columns["country_id"].Visible = false;
            dgvBudgets.Columns["action_id"].Visible = false;
            dgvBudgets.Columns["association_id"].Visible = false;
            dgvBudgets.Columns["CountryName"].Visible = false;
            dgvBudgets.Columns["AssociationName"].Visible = false;
            dgvBudgets.Columns["ActionLibel"].Visible = false;
            dgvBudgets.Columns["date"].Visible = false;

            dgvBudgets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBudgets.Columns["CountryNameDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBudgets.Columns["CountryNameDate"].HeaderText = "Partenariat";
            dgvBudgets.Columns["CountryNameDate"].DisplayIndex = 1;
            dgvBudgets.Columns["plafond"].HeaderText = "Plafond";
            dgvBudgets.Columns["forecastBudget"].HeaderText = "Budget initial";
            dgvBudgets.Columns["realBudget"].HeaderText = "Budget réel";

            dgvBudgets.RowHeadersVisible = false;
            dgvBudgets.BackgroundColor = Color.White;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            FrmUpdatebudget target = new FrmUpdatebudget(utilisateurAuthentifie);
            target.ShowDialog();
            dgvBudgets.DataSource = PartnershipManager.GetInstance().GetPartnerships();
        }
    }
}
