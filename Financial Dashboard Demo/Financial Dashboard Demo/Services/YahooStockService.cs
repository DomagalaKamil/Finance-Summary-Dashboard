using YahooFinanceApi;
using Financial_Dashboard_Demo.Models;


namespace Financial_Dashboard_Demo.Services
{
    public static class YahooStockService
    {
        public static async Task<List<StockInfo>> GetTopCompaniesAsync()
        {
            string[] symbols =
            {
                "AAPL","MSFT","NVDA",
                "AMZN","GOOGL","META",
                "TSLA","BRK-B","AVGO"
            };

            var data = await Yahoo
                .Symbols(symbols)
                .Fields(
                    Field.LongName,
                    Field.RegularMarketPrice,
                    Field.MarketCap,
                    Field.RegularMarketChangePercent)
                .QueryAsync();

            return data.Select(s => new StockInfo
            {
                Symbol = s.Key,
                Company = s.Value[Field.LongName]?.ToString(),
                Price = Convert.ToDecimal(s.Value[Field.RegularMarketPrice]),
                MarketCap = Convert.ToDecimal(s.Value[Field.MarketCap]),
                ChangePercent = Convert.ToDecimal(
                    s.Value[Field.RegularMarketChangePercent])
            }).ToList();
        }
    }
}
