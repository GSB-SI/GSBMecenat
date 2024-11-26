using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public class PartnershipDAO
    {
        #region Singleton
        private static PartnershipDAO instance;
        public static PartnershipDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new PartnershipDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Partnership> GetPartnerships()
        {
            using (var ctx = new GSBMecenatEntities())
            {
                var liste = ctx.Partnerships
                    .Include("Association")
                    .Include("Action")
                    .Include("Country")
                .ToList();
                return liste;
            }
        }
        public int AddPartnership(Partnership p)
        {
            using (var ctx = new GSBMecenatEntities())
            {
                try
                {
                    ctx.sp_partnerships_add(p.action_id,p.association_id,p.country_id);
                    return 0;
                }
                catch
                {
                    return -1;
                }

                ;
            }
        }
        public int UpdatePartnership(Partnership p)
        {
            using (var ctx = new GSBMecenatEntities())
            {
                try
                {
                    ctx.sp_partnerships_update(p.id,p.action_id, p.association_id, p.country_id);
                    return 0;
                }
                catch
                {
                    return -1;
                }

                ;
            }
        }
        public int DeletePartnership(Partnership p)
        {
            using (var ctx = new GSBMecenatEntities())
            {
                try
                {
                    ctx.sp_partnerships_delete(p.id);
                    return 0;
                }
                catch
                {
                    return -1;
                }

                ;
            }
        }
    }
}
