using ProGestionGSB.BLL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmPartnership : Form
    {
        public FrmPartnership()
        {
            InitializeComponent();
            dgvPartnerships.DataSource = PartnershipManager.GetInstance().GetPartnerships();
            dgvPartnerships.Columns["id"].Visible = false;
            dgvPartnerships.Columns["country_id"].Visible = false;
            dgvPartnerships.Columns["action_id"].Visible = false;
            dgvPartnerships.Columns["association_id"].Visible = false;
            dgvPartnerships.Columns["Country"].Visible = false;
            dgvPartnerships.Columns["Action"].Visible = false;
            dgvPartnerships.Columns["Association"].Visible = false;
            dgvPartnerships.Columns["CountryName"].Visible = false;
            dgvPartnerships.Columns["CountryNameDate"].Visible = false;
            dgvPartnerships.Columns["forecastBudget"].HeaderText = "budget prévu";
            dgvPartnerships.Columns["realBudget"].HeaderText = "budget réel";

            dgvPartnerships.Columns["date"].HeaderText = "date du partenariat";
            dgvPartnerships.Columns["CountryName"].HeaderText = "pays";
            dgvPartnerships.Columns["AssociationName"].HeaderText = "nom de l'association";
            dgvPartnerships.Columns["ActionLibel"].HeaderText = "action de mécénat";

            dgvPartnerships.Columns["AssociationName"].DisplayIndex = 0;
            dgvPartnerships.Columns["ActionLibel"].DisplayIndex = 1;


            dgvPartnerships.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPartnerships.Columns["AssociationName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPartnerships.RowHeadersVisible = false;
        }

        private void FrmPartnership_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPartnership frm = new FrmAddPartnership();
            frm.ShowDialog();
            dgvPartnerships.DataSource = PartnershipManager.GetInstance().GetPartnerships();
        }

        private void brtnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdatePartnership frm = new FrmUpdatePartnership();
            frm.ShowDialog();
            dgvPartnerships.DataSource = PartnershipManager.GetInstance().GetPartnerships();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmDeletePartnership frm = new FrmDeletePartnership();
            frm.ShowDialog();
            dgvPartnerships.DataSource = PartnershipManager.GetInstance().GetPartnerships();
        }
    }
}
