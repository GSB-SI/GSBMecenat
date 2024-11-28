using ProGestionGSB.BLL;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmChoosenCountryYears : Form
    {
        public FrmChoosenCountryYears()
        {
            InitializeComponent();

            dgvChoosenCountryYears.DataSource = ChoosenCountryYearsManager.GetInstance().GetAll();

            dgvChoosenCountryYears.Columns["Country"].Visible = false;
            dgvChoosenCountryYears.Columns["country_id"].Visible = false;
            dgvChoosenCountryYears.Columns["CountryNameYear"].Visible = false;

            dgvChoosenCountryYears.Columns["CountryName"].HeaderText = "Pays";
            dgvChoosenCountryYears.Columns["CountryName"].DisplayIndex = 0;
            dgvChoosenCountryYears.Columns["choosenYear"].HeaderText = "Année";
            dgvChoosenCountryYears.Columns["plafond"].HeaderText = "Plafond";

            dgvChoosenCountryYears.Columns["CountryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvChoosenCountryYears.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvChoosenCountryYears.RowHeadersVisible = false;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FrmAddChoosenCountryYears target = new FrmAddChoosenCountryYears();
            target.ShowDialog();
            dgvChoosenCountryYears.DataSource = ChoosenCountryYearsManager.GetInstance().GetAll();

        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            FrmDeleteChoosenCountryYears target = new FrmDeleteChoosenCountryYears();
            target.ShowDialog();
            dgvChoosenCountryYears.DataSource = ChoosenCountryYearsManager.GetInstance().GetAll();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            FrmUpdateChoosenCountryYear target = new FrmUpdateChoosenCountryYear();
            target.ShowDialog();
            dgvChoosenCountryYears.DataSource = ChoosenCountryYearsManager.GetInstance().GetAll();
        }
    }
}
