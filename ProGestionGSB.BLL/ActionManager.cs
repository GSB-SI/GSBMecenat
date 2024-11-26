using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.BLL
{
    public class ActionManager
    {
        #region Singleton
        private static ActionManager instance;
        public static ActionManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ActionManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<ProGestionGSB.DAL.Action> GetActions()
        {
            return ActionDAO.GetInstance().GetActions();
        }
    }
}
