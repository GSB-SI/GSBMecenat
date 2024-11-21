using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public class CountryDAO
    {
        #region Singleton
        private static CountryDAO instance;
        public static CountryDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CountryDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Country> GetCountries()
        {
            using (var ctx = new GSBMecenatEntities())
            {
                var liste = ctx.Countries
                .ToList();
                return liste;
            }
        }
    }
}
