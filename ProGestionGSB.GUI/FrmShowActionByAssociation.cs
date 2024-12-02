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
using System.Xml.Linq;

namespace ProGestionGSB.GUI
{
    public partial class FrmShowActionByAssociation : Form
    {
        public FrmShowActionByAssociation()
        {
            InitializeComponent();
            cboAssociation.DataSource = AssociationManager.GetInstance().GetAssociations();
            cboAssociation.DisplayMember = "name";
            cboAssociation.ValueMember = "id";
            cboAssociation.SelectedIndex = -1;
        }

        private void cboAssociation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboAssociation.SelectedIndex != -1)
            {
                Association Asso = (Association)cboAssociation.SelectedItem;
                DataTable table = new DataTable();
                table.Columns.Add("Action en partenariat avec l'association");
                foreach (string actions in AssociationManager.GetInstance().ActionsByAssociation(Asso))
                {
                    table.Rows.Add(actions);
                }
                dgvActions.DataSource = table;
                dgvActions.Columns["Action en partenariat avec l'association"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActions.RowHeadersVisible = false;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
