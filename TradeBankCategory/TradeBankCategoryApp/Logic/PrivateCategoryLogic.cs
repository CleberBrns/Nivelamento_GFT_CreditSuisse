using TradeBankCategoryApp.Logic.Interface;

namespace TradeBankCategoryApp.Logic
{
    internal class PrivateCategoryLogic : IGetRiskCategory
    {
        readonly double CategoryValue;
        public PrivateCategoryLogic(double categoryValue) 
        {
            this.CategoryValue = categoryValue;
        }

        public string GetRiskCategory()
        {
            if (CategoryValue > 1000000)
            {
                return "HIGHRISK";
            }

            return string.Empty;
        }
    }
}
