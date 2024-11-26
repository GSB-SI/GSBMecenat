using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public class IndicatorDAO
    {
        #region Singleton
        private static IndicatorDAO instance;
        public static IndicatorDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new IndicatorDAO();
            }
            return instance;
        }
        #endregion Singleton

        public DataTable GetNbAssociationByCountry()
        {
            using (var ctx = new GSBMecenatEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("Pays");
                table.Columns.Add("Nombre d'association");
                foreach(sp_nbAssociationByCountry_Result a in ctx.sp_nbAssociationByCountry())
                {
                    table.Rows.Add(a.name,a.Number);
                }

                return table;
            }
        }
        public DataTable GetNbPartnershipsByActionbyYear()
        {
            using (var ctx = new GSBMecenatEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("Action");
                table.Columns.Add("Année");
                table.Columns.Add("Nombre de partenariat");
                foreach (sp_nbPartnershipsByActionByYear_Result1 result in ctx.sp_nbPartnershipsByActionByYear())
                {
                    table.Rows.Add(result.libel, result.year,result.nbPartnerships);
                }

                return table;
            }
        }
    }
}
