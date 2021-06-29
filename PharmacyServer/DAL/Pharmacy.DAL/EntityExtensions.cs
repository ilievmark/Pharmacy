namespace Pharmacy.DAL
{
    public static class EntityExtensions
    {
        public static decimal GetActualPrice(this PriceEntity priceEntity)
            => priceEntity.IncomePrice + priceEntity.GetProfit();

        public static decimal GetProfit(this PriceEntity priceEntity)
            => priceEntity.IncomePrice * priceEntity.Percent;
    }
}
