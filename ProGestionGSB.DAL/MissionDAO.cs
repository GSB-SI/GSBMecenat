using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public class MissionDAO
    {
        #region Singleton
        private static MissionDAO instance;
        public static MissionDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new MissionDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Mission> GetMissions()
        {
            using (var ctx = new GSBMecenatEntities())
            {
                var liste = ctx.Missions
                .ToList();
                return liste;
            }
        }
    }
}
