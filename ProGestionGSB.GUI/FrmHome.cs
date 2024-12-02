using ProGestionGSB.DAL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmHome : Form
    {

        public User utilisateurAuthentifie;
        public FrmHome()
        {
            InitializeComponent();
            desactiveMenus();
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
            FrmBudgets frm = new FrmBudgets(utilisateurAuthentifie);
            frm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void desactiveMenus()
        {
            btnManageAssociations.Enabled = false;
            btnManagePartnerships.Enabled = false;
            btnShowActionsByAssociation.Enabled = false;
            btnShowIndicators.Enabled = false;
            btnManageUsers.Enabled = false;
            btnManagePlafonds.Enabled = false;
            btnChoosenCountryYears.Enabled = false;
            btnResetpassword.Enabled = false;
        }

        private void FrmHome_Shown(object sender, EventArgs e)
        {
            using (FrmLogin formLogin = new FrmLogin())
            {
                formLogin.ShowDialog();
                utilisateurAuthentifie = formLogin.User;
            }
            if (utilisateurAuthentifie != null)
            {
                activeMenus();
            }
        }

        private void activeMenus()
        {
            if (utilisateurAuthentifie.Role.libel == "Administrateur")
            {
                btnManageUsers.Enabled = true;
            }
            btnManageAssociations.Enabled = true;
            btnManagePartnerships.Enabled = true;
            btnShowActionsByAssociation.Enabled = true;
            btnShowIndicators.Enabled = true;
            btnManagePlafonds.Enabled = true;
            btnChoosenCountryYears.Enabled = true;
            btnResetpassword.Enabled = true;
        }

        private void btnChoosenCountryYears_Click(object sender, EventArgs e)
        {
            FrmChoosenCountryYears target = new FrmChoosenCountryYears(utilisateurAuthentifie);
            target.ShowDialog();
        }

        private void btnResetpassword_Click(object sender, EventArgs e)
        {
            FrmUpdatePassword target = new FrmUpdatePassword(utilisateurAuthentifie);
            target.ShowDialog();
        }
    }
}
