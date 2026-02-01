using System;
using System.Collections.Generic;
using System.Text;

namespace Financial_Dashboard_Demo.Models
{
    public class PortfolioStock
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public int Quantity { get; set; }

        public decimal InvestedValue { get; set; }

        public decimal CurrentPrice { get; set; }

        public decimal CurrentValue
            => Quantity * CurrentPrice;

        public decimal ProfitLoss
            => CurrentValue - InvestedValue;
    }


}
