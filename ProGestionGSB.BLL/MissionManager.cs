using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.BLL
{
    public class MissionManager
    {
        #region Singleton
        private static MissionManager instance;
        public static MissionManager GetInstance()
        {
            if (instance == null)
            {
                instance = new MissionManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<Mission> GetMissions()
        {
            return MissionDAO.GetInstance().GetMissions();
        }
    }
}
