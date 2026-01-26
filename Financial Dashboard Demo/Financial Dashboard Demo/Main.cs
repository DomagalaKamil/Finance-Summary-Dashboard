using Financial_Dashboard_Demo.Controls;
using Financial_Dashboard_Demo.Services;
using System.Threading.Tasks;

namespace Financial_Dashboard_Demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load_1(object sender, EventArgs e)
        {
            await LoadStocks();
        }

        private async Task LoadStocks()
        {
            flowLayoutPanelStocks.Controls.Clear();

            var stocks = await YahooStockService.GetTopCompaniesAsync();

            foreach (var stock in stocks)
            {
                var panel = new StockPanel();
                panel.SetData(stock);
                panel.Margin = new Padding(10);

                flowLayoutPanelStocks.Controls.Add(panel);
            }
        }
    }
}