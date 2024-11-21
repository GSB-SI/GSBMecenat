using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.BLL
{
    public class UserManager
    {
        #region Singleton
        private static UserManager instance;
        public static UserManager GetInstance()
        {
            if (instance == null)
            {
                instance = new UserManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<User> GetUsers()
        {
            return UserDAO.GetInstance().GetUsers();
        }

        public sp_users_getbyId_Result GetUserById(int id)
        {
            return UserDAO.GetInstance().GetUserById(id);
        }

        public void AddUser(string login, string password, int role_id)
        {
            UserDAO.GetInstance().AddUser(login, password, role_id);
        }

        public void UpdateUser(int id, string login, string password, int role_id)
        {
            UserDAO.GetInstance().UpdateUser(id, login, password, role_id);
        }

        public void DeleteUser(int id)
        {
            UserDAO.GetInstance().DeleteUser(id);
        }
    }
}
