using System;
using System.Collections.Generic;
using System.Text;

namespace Financial_Dashboard_Demo.Models
{
    public class StockInfo
    {
        public string Symbol { get; set; }
        public string Company { get; set; }
        public decimal MarketCap { get; set; }
        public decimal Price { get; set; }
        public decimal ChangePercent { get; set; }
    }

}
