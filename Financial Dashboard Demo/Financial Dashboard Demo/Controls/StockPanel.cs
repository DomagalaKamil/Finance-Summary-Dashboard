using Financial_Dashboard_Demo.Models;

namespace Financial_Dashboard_Demo.Controls
{
    public partial class StockPanel : UserControl
    {
        public StockPanel()
        {
            InitializeComponent();

            // IMPORTANT: without size, FlowLayoutPanel shows nothing
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void SetData(StockInfo stock)
        {
            lblCompany.Text = $"{stock.Company} ({stock.Symbol})";

            lblPrice.Text = $"Price: ${stock.Price:N2}";

            lblMarketCap.Text =
                $"Market Cap: {(stock.MarketCap / 1_000_000_000_000M):N2}T";

            lblChange.Text =
                $"{stock.ChangePercent:+0.00;-0.00}%";

            lblChange.ForeColor =
                stock.ChangePercent >= 0
                    ? Color.LimeGreen
                    : Color.Red;
        }
    }
}
