using ProGestionGSB.DAL;

namespace ProGestionGSB.BLL
{
    public class BudgetManager
    {
        #region Singleton
        private static BudgetManager instance;

        public static BudgetManager GetInstance()
        {
            if (instance == null)
            {
                instance = new BudgetManager();
            }
            return instance;
        }
        #endregion

        public void UpdateAllPlafonds(int id, float? plafond, float? forecastBudget, float? realBudget)
        {
            BudgetDAO.GetInstance().UpdateAllBudgets(id, plafond, forecastBudget, realBudget);
        }
    }
}
