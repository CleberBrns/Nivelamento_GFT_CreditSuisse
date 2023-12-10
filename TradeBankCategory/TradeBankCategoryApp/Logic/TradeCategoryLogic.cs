using System.Collections.Generic;
using System.Linq;
using TradeBankCategoryApp.Entities;

namespace TradeBankCategoryApp.Logic
{
    public class TradeCategoryLogic
    {
        public List<string> GetGategoriesFromTrades(List<Trade> trades)
        {
            List<string> categories = new List<string>();

            if (trades != null && trades.Any())
            {
                foreach (var item in trades)
                {
                    categories.Add(new CategoryFinderLogic(item).GetRiskCategory());
                }
            }

            return categories;
        }
    }
}
