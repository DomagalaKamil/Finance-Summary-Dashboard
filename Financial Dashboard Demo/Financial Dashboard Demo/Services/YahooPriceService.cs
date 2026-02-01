using YahooFinanceApi;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Dashboard_Demo.Models;
using System;

namespace Financial_Dashboard_Demo.Services
{
    public class YahooPriceService
    {
        public async Task LoadPricesAsync(List<PortfolioStock> stocks)
        {
            var symbols = stocks.Select(s => s.StockCode).ToArray();

            var results = await Yahoo
                .Symbols(symbols)
                .Fields(Field.RegularMarketPrice)
                .QueryAsync();

            foreach (var stock in stocks)
            {
                if (results.TryGetValue(stock.StockCode, out var quote))
                {
                    stock.CurrentPrice =
                        Convert.ToDecimal(
                            quote[Field.RegularMarketPrice]);
                }
            }
        }
    }
}
