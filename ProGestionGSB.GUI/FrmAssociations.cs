using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProGestionGSB.BLL;

namespace ProGestionGSB.GUI
{
    public partial class FrmAssociations : Form
    {
        public FrmAssociations()
        {
            InitializeComponent();

            dgvAssociations.DataSource = AssociationManager.GetInstance().GetAssociations();
            dgvAssociations.Columns["Partnerships"].Visible=false;
            dgvAssociations.Columns["id"].Visible = false;
            dgvAssociations.Columns["country_id"].Visible = false;
            dgvAssociations.Columns["mission_id"].Visible = false;
            dgvAssociations.Columns["Country"].Visible = false;
            dgvAssociations.Columns["Mission"].Visible = false;
            dgvAssociations.Columns["name"].HeaderText = "Nom de l'association";
            dgvAssociations.Columns["responsable"].HeaderText = "Responsable";
            dgvAssociations.Columns["CountryName"].HeaderText = "Pays d'origine";
            dgvAssociations.Columns["MissionLibel"].HeaderText = "Mission de l'association";


            dgvAssociations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAssociations.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAssociations.RowHeadersVisible = false; 
            
        }

        private void FrmAssociations_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddAssociation frm = new FrmAddAssociation();
            frm.ShowDialog();
            dgvAssociations.DataSource=AssociationManager.GetInstance().GetAssociations();
        }

        private void brtnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateAssociation frm = new FrmUpdateAssociation();
            frm.ShowDialog();
            dgvAssociations.DataSource = AssociationManager.GetInstance().GetAssociations();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmDeleteAssociation frm = new FrmDeleteAssociation();
            frm.ShowDialog();
            dgvAssociations.DataSource = AssociationManager.GetInstance().GetAssociations();
        }
    }
}
