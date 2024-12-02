using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmDeleteUser : Form
    {
        public FrmDeleteUser()
        {
            InitializeComponent();
            cboRoles.DataSource = RoleManager.GetInstance().GetAll();
            cboRoles.DisplayMember = "libel";
            cboRoles.ValueMember = "id";
            cboRoles.SelectedIndex = -1;

            cboUsers.DataSource = UserManager.GetInstance().GetUsers();
            cboUsers.DisplayMember = "Login";
            cboUsers.ValueMember = "id";
            cboUsers.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (cboUsers.SelectedIndex == -1)
            {
                erreurs += "L'utilisateur doit être séléctionné\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int user_id = Convert.ToInt32(cboUsers.SelectedValue.ToString());
                UserManager.GetInstance().DeleteUser(user_id);
                MessageBox.Show("Utilisateur supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLogin.Text = "";
                txtPassword.Text = "";
                cboRoles.SelectedIndex = -1;
                cboUsers.SelectedIndex = -1;

                cboUsers.DataSource = UserManager.GetInstance().GetUsers();
                cboUsers.SelectedIndex = -1;
            }
        }

        private void cboUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboUsers.SelectedIndex != -1)
            {
                User user = (User)cboUsers.SelectedItem;
                txtLogin.Text = user.login;
                txtPassword.Text = user.password;
                cboRoles.SelectedValue = user.role_id;
            }
        }
    }
}
