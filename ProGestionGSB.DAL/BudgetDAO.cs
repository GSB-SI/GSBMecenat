using System;

namespace ProGestionGSB.DAL
{
    public class BudgetDAO
    {
        #region Singleton
        private static BudgetDAO instance;

        public static BudgetDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new BudgetDAO();
            }
            return instance;
        }
        #endregion

        public void UpdateAllBudgets(int id, float? forecastBudget, float? realBudget)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_partnerships_updateForecastBudget(id, forecastBudget);
                    ctx.sp_partnerships_updateRealBudget(id, realBudget);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the user.", ex);
            }
        }

    }
}