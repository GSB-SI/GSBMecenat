using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmUpdateUser : Form
    {
        public FrmUpdateUser()
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



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (cboUsers.SelectedIndex == -1)
            {
                erreurs += "Un utilisateur doit être renseigné pour modifier\n";
            }
            if (string.IsNullOrWhiteSpace(txtLogin.Text) == true)
            {
                erreurs += "Le login de l'utilisateur doit être renseigné\n";
                txtLogin.Focus();
            }


            if (cboRoles.SelectedIndex == -1)
            {
                erreurs += "Le rôle doit être renseigné\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string login = txtLogin.Text;
                int role_id = Convert.ToInt32(cboRoles.SelectedValue.ToString());
                int user_id = Convert.ToInt32(cboUsers.SelectedValue.ToString());
                UserManager.GetInstance().UpdateUser(user_id, login, role_id);
                MessageBox.Show("Utilisateur modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLogin.Text = "";
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
                cboRoles.SelectedValue = user.role_id;
            }
        }
    }
}
