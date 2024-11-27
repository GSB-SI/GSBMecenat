using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageAssociations_Click(object sender, EventArgs e)
        {
            FrmAssociations frm = new FrmAssociations();
            frm.ShowDialog();
        }

        private void btnManagePartnerships_Click(object sender, EventArgs e)
        {
            FrmPartnership frm = new FrmPartnership();
            frm.ShowDialog();
        }

        private void btnShowActionsByAssociation_Click(object sender, EventArgs e)
        {
            FrmShowActionByAssociation frm = new FrmShowActionByAssociation();
            frm.ShowDialog();
        }

        private void btnShowIndicators_Click(object sender, EventArgs e)
        {
            FrmIndicator frm = new FrmIndicator();
            frm.ShowDialog();
        }

        private void btnManagePlafonds_Click(object sender, EventArgs e)
        {
            FrmUpdatebudget frm = new FrmUpdatebudget();
            frm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
        }
    }
}
