using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmUpdatePassword : Form
    {
        private User utilisateurAuthentifie;
        public FrmUpdatePassword(User user)
        {
            InitializeComponent();
            utilisateurAuthentifie = user;

        }

        private void btnChangePassword_Click(object sender, System.EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                erreurs += "Le nouveau mot de passe doit être renseigné\n";
                txtPassword.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtSecondPassword.Text) == true)
            {
                erreurs += "La confirmation du nouveau mot de passe doit être renseignée\n";
                txtSecondPassword.Focus();
            }
            if (txtPassword.Text != txtSecondPassword.Text)
            {
                erreurs += "Les mots de passe doivent être identiques\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int user_id = utilisateurAuthentifie.id;
                string password = txtPassword.Text;
                UserManager.GetInstance().resetPassword(user_id, password);
                MessageBox.Show("Mot de passe modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
