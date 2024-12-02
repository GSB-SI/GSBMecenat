using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.BLL
{
    public class PartnershipManager
    {
        #region Singleton
        private static PartnershipManager instance;
        public static PartnershipManager GetInstance()
        {
            if (instance == null)
            {
                instance = new PartnershipManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<Partnership> GetPartnerships()
        {
            return PartnershipDAO.GetInstance().GetPartnerships();
        }
        public int AddPartnership(int action_id, int country_id,int association_id)
        {
            Partnership p = new Partnership();
            p.action_id = action_id;
            p.country_id = country_id;
            p.association_id = association_id;
            return PartnershipDAO.GetInstance().AddPartnership(p);
        }
        public int UpdatePartnership(int id, int action_id, int country_id, int association_id)
        {
            Partnership p = new Partnership();
            p.id = id;
            p.action_id= action_id;
            p.association_id= association_id;
            p.country_id= country_id;
            return PartnershipDAO.GetInstance().UpdatePartnership(p);
        }
        public int DeletePartnership(Partnership p)
        {
            return PartnershipDAO.GetInstance().DeletePartnership(p);
        }
    }
}
