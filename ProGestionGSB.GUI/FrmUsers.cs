using ProGestionGSB.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProGestionGSB.GUI
{

    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();

            dgvUsers.DataSource = UserManager.GetInstance().GetUsers();
            dgvUsers.Columns["Role"].Visible = false;

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsers.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvUsers.RowHeadersVisible = false;
            dgvUsers.BackgroundColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUser target = new FrmAddUser();
            target.ShowDialog();
            dgvUsers.DataSource = UserManager.GetInstance().GetUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateUser target = new FrmUpdateUser();
            target.ShowDialog();
            dgvUsers.DataSource = UserManager.GetInstance().GetUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmDeleteUser target = new FrmDeleteUser();
            target.ShowDialog();
            dgvUsers.DataSource = UserManager.GetInstance().GetUsers();
        }
    }
}
