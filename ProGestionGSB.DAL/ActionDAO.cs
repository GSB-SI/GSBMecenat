using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public class ActionDAO
    {
        #region Singleton
        private static ActionDAO instance;
        public static ActionDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ActionDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Action> GetActions()
        {
            using (var ctx = new GSBMecenatEntities())
            {
                var liste = ctx.Actions
                .ToList();
                return liste;
            }
        }
    }
}
