using TradeBankCategoryApp.Logic.Interface;

namespace TradeBankCategoryApp.Logic
{
    internal class PublicCategoryLogic : IGetRiskCategory
    {
        readonly double CategoryValue;
        public PublicCategoryLogic(double categoryValue)
        {
            this.CategoryValue = categoryValue;
        }

        public string GetRiskCategory()
        {
            if (CategoryValue < 1000000)
            {
                return "LOWRISK";
            }
            else if (CategoryValue > 1000000)
            {
                return "MEDIUMRISK";
            }

            return string.Empty;
        }
    }
}
