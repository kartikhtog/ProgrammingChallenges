namespace Algorithms
{
    public class MaxProfitOnStockIndex
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 1)
            {
                return 0;
            }
            var lastPrice = prices[0];
            var profit = 0;
            foreach (var price in prices)
            {
                if (price > lastPrice)
                {
                    profit += price - lastPrice;
                }
                lastPrice = price;
            }
            return profit;
        }
    }
}










