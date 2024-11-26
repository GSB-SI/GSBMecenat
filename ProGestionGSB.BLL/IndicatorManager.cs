using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.BLL
{
    public class IndicatorManager
    {
        #region Singleton
        private static IndicatorManager instance;
        public static IndicatorManager GetInstance()
        {
            if (instance == null)
            {
                instance = new IndicatorManager();
            }
            return instance;
        }
        #endregion Singleton

        public DataTable GetNbAssociationByCountry()
        {
            return IndicatorDAO.GetInstance().GetNbAssociationByCountry();
        }
        public DataTable GetNbPartnershipsByActionbyYear()
        {
            return IndicatorDAO.GetInstance().GetNbPartnershipsByActionbyYear();
        }
    }
}
