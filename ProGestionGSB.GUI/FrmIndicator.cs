using ProGestionGSB.BLL;
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
    public partial class FrmIndicator : Form
    {
        public FrmIndicator()
        {
            InitializeComponent();
            dgvNbAssociationByCountry.DataSource = IndicatorManager.GetInstance().GetNbAssociationByCountry();

            dgvNbAssociationByCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNbAssociationByCountry.Columns["Pays"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNbAssociationByCountry.RowHeadersVisible = false;

            
            dgvNbPartnershipsByActionByYear.DataSource = IndicatorManager.GetInstance().GetNbPartnershipsByActionbyYear();
            
            dgvNbPartnershipsByActionByYear.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNbPartnershipsByActionByYear.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNbPartnershipsByActionByYear.RowHeadersVisible = false;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
