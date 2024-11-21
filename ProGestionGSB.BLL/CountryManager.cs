using ProGestionGSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.BLL
{
    public class CountryManager
    {
        #region Singleton
        private static CountryManager instance;
        public static CountryManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CountryManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<Country> GetCountries()
        {
            return CountryDAO.GetInstance().GetCountries();
        }
    }
}
