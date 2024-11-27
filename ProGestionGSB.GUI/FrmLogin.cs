using ProGestionGSB.BLL;
using ProGestionGSB.DAL;
using System;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{
    public partial class FrmLogin : Form
    {
        public User User;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtLogin.Text) == true)
            {
                erreurs += "Le login est obligatoire\n";
                txtPassword.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                erreurs += "Le mot de passe est obligatoire\n";
                txtPassword.Focus();
            }
            #endregion

            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = UserManager.GetInstance().GetInfosUtilisateur(txtLogin.Text, txtPassword.Text);
                if (user != null)
                {
                    this.User = user;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Vos informations de connexion sont erronées", "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
