using TradeBankCategoryApp.Entities;

namespace TradeBankCategoryApp.Logic
{
    internal class CategoryFinderLogic
    {
        readonly ITrade Trade;

        public CategoryFinderLogic(ITrade trade)
        {
            this.Trade = trade;
        }

        public string GetRiskCategory()
        {
            if (Trade.ClientSector.Equals("Public"))
            {
                return new PublicCategoryLogic(Trade.Value).GetRiskCategory();
            }
            else if (Trade.ClientSector.Equals("Private"))
            {
                return new PrivateCategoryLogic(Trade.Value).GetRiskCategory();
            }

            return "TradeRiskNotMapped";
        }
    }
}
