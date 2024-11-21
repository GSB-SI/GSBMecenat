using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProGestionGSB.BLL
{
    public class AssociationManager
    {
        #region Singleton
        private static AssociationManager instance;
        public static AssociationManager GetInstance()
        {
            if (instance == null)
            {
                instance = new AssociationManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<Association> GetAssociations()
        {
            return AssociationDAO.GetInstance().GetAssociations();
        }
        public int AddAssociation(string name,string responsable, int mission_id, int country_id)
        {
            Association a = new Association();
            a.name = name;
            a.responsable = responsable;
            a.mission_id = mission_id;
            a.country_id = country_id;
            return AssociationDAO.GetInstance().AddAssociations(a);
        }

        public int UpdateAssociations(int id,string name, string responsable, int mission_id, int country_id)
        {
            Association a = new Association();
            a.id = id;
            a.name = name;
            a.responsable = responsable;
            a.mission_id = mission_id;
            a.country_id = country_id;
            return AssociationDAO.GetInstance().UpdateAssociations(a);
        }
        public int DeleteAssociations(Association a)
        {

            return AssociationDAO.GetInstance().DeleteAssociations(a);
        }

    }
}
