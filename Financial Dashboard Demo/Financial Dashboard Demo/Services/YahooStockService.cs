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

            var list = new List<StockInfo>();

            foreach (var s in data)
            {
                list.Add(new StockInfo
                {
                    Symbol = s.Key,
                    Company = s.Value[Field.LongName]?.ToString() ?? "N/A",

                    Price = s.Value[Field.RegularMarketPrice] != null
                        ? Convert.ToDecimal(s.Value[Field.RegularMarketPrice])
                        : 0,

                    MarketCap = s.Value[Field.MarketCap] != null
                        ? Convert.ToDecimal(s.Value[Field.MarketCap])
                        : 0,

                    ChangePercent = s.Value[Field.RegularMarketChangePercent] != null
                        ? Convert.ToDecimal(
                            s.Value[Field.RegularMarketChangePercent])
                        : 0
                });
            }

            return list;
        }
    }
}
