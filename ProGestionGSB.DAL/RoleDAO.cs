using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public class RoleDAO
    {
        #region Singleton
        private static RoleDAO instance;

        public static RoleDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new RoleDAO();
            }
            return instance;
        }
        #endregion

        public List<Role> GetAll()
        {
            using (GSBMecenatEntities ctx = new GSBMecenatEntities())
            {
                return ctx.Roles.ToList();
            }
        }
    }
}
