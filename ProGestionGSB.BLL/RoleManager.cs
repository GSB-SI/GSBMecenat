using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.BLL
{
    public class RoleManager
    {
        #region Singleton
        private static RoleManager instance;
        public static RoleManager GetInstance()
        {
            if (instance == null)
            {
                instance = new RoleManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Role> GetAll()
        {
            return RoleDAO.GetInstance().GetAll();
        }
    }
}
