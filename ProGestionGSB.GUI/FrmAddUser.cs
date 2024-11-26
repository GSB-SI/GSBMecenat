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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
            cboRoles.DataSource = RoleManager.GetInstance().GetAll();
            cboRoles.DisplayMember = "libel";
            cboRoles.ValueMember = "id";
            cboRoles.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtLogin.Text) == true)
            {
                erreurs += "Le login de l'utilisateur doit être renseigné\n";
                txtLogin.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                erreurs += "Le mot de passe de l'utilisateur est obligatoire\n";
                txtPassword.Focus();
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
                string password = txtPassword.Text;
                int role_id = Convert.ToInt32(cboRoles.SelectedValue.ToString());
                UserManager.GetInstance().AddUser(login, password, role_id);
                MessageBox.Show("Utilisateur ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLogin.Text = "";
                txtPassword.Text = "";
                cboRoles.SelectedIndex = -1;
            }
        }
    }
}
