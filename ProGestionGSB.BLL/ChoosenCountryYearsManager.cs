using ProGestionGSB.DAL;
using System.Collections.Generic;

namespace ProGestionGSB.BLL
{
    public class ChoosenCountryYearsManager
    {
        #region Singleton
        private static ChoosenCountryYearsManager instance;
        public static ChoosenCountryYearsManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ChoosenCountryYearsManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<ChoosenCountryYear> GetAll()
        {
            return ChoosenCountryYearsDAO.GetInstance().GetAll();
        }

        public sp_choosenCountryYears_getByYear_Result GetByYear(int year)
        {
            return ChoosenCountryYearsDAO.GetInstance().GetByYear(year);
        }

        public void AddChoosenCountryYear(int country_id, int year, double? plafond)
        {
            ChoosenCountryYearsDAO.GetInstance().AddChoosenCountryYear(country_id, year, plafond);
        }

        public void UpdateChoosenCountryYear(int oldcountry_id, int newcountry_id, int oldChoosenYear, int newChoosenYear, double? plafond)
        {
            ChoosenCountryYearsDAO.GetInstance().UpdateChoosenCountryYear(oldcountry_id, newcountry_id, oldChoosenYear, newChoosenYear, plafond);
        }

        public void DeleteChoosenCountryYear(int country_id, int year)
        {
            ChoosenCountryYearsDAO.GetInstance().DeleteChoosenCountryYear(country_id, year);
        }
    }
}
