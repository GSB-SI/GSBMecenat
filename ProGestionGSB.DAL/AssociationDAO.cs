using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public class AssociationDAO
    {
        #region Singleton
        private static AssociationDAO instance;
        public static AssociationDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new AssociationDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Association> GetAssociations()
        {
            using (var ctx = new GSBMecenatEntities())
            {
                var liste = ctx.Associations
                .Include("Mission")
                .Include("Country")
                .ToList();
                return liste;
            }
        }

        public int AddAssociations(Association a)
        {
            using (var ctx = new GSBMecenatEntities())
            {
                try
                {
                    ctx.sp_associations_add(a.name, a.responsable, a.mission_id, a.country_id);
                    return 0;
                }
                catch
                {
                    return -1;
                }

                ;
            }
        }
        public int UpdateAssociations(Association a)
        {
            using (var ctx = new GSBMecenatEntities())
            {
                try
                {
                    ctx.sp_associations_update(a.id,a.name, a.responsable, a.mission_id, a.country_id);
                    return 0;
                }
                catch
                {
                    return -1;
                }

                ;
            }
        }

        public int DeleteAssociations(Association a)
        {
            using (var ctx = new GSBMecenatEntities())
            {
                try
                {
                    ctx.sp_associations_delete(a.id);
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
