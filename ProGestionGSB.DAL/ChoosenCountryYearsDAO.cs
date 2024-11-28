using System;
using System.Collections.Generic;
using System.Linq;

namespace ProGestionGSB.DAL
{
    public class ChoosenCountryYearsDAO
    {
        #region Singleton
        private static ChoosenCountryYearsDAO instance;

        public static ChoosenCountryYearsDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ChoosenCountryYearsDAO();
            }
            return instance;
        }
        #endregion

        public List<ChoosenCountryYear> GetAll()
        {
            using (GSBMecenatEntities ctx = new GSBMecenatEntities())
            {
                return ctx.ChoosenCountryYears.Include("Country").ToList();
            }
        }

        public sp_choosenCountryYears_getByYear_Result GetByYear(int year)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    var result = ctx.sp_choosenCountryYears_getByYear(year).FirstOrDefault();
                    return result ?? throw new Exception("ChoosenCountryYear not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the ChoosenCountryYear.", ex);
            }
        }

        public void AddChoosenCountryYear(int country_id, int year, double? plafond)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_choosenCountryYears_add(country_id, year, plafond);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the ChoosenCountryYear.", ex);
            }
        }

        public void UpdateChoosenCountryYear(int oldcountry_id, int newcountry_id, int oldChoosenYear, int newChoosenYear, double? plafond)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_choosenCountryYears_update(oldcountry_id, newcountry_id, oldChoosenYear, newChoosenYear, plafond);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the ChoosenCountryYear.", ex);
            }
        }

        public void DeleteChoosenCountryYear(int country_id, int year)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_choosenCountryYears_delete(country_id, year);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the ChoosenCountryYear.", ex);
            }
        }
    }
}
