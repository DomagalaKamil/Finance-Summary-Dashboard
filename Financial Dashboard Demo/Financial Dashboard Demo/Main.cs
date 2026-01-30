using Financial_Dashboard_Demo.Controls;
using Financial_Dashboard_Demo.Services;
using System.Threading.Tasks;



namespace Financial_Dashboard_Demo
{
    public partial class Main : Form
    {

        private System.Windows.Forms.Timer refreshTimer;
        private bool isRefreshing = false;

        public Main()
        {
            InitializeComponent();

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 10_000; // 10 seconds
            refreshTimer.Tick += RefreshTimer_Tick;

        }

        private async void Main_Load_1(object sender, EventArgs e)
        {
            await LoadStocks();
            refreshTimer.Start();
        }

        private async Task LoadStocks()
        {
            if (isRefreshing)
                return;

            isRefreshing = true;

            try
            {
                flowLayoutPanelStocks.SuspendLayout();
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
            finally
            {
                flowLayoutPanelStocks.ResumeLayout();
                isRefreshing = false;
            }
        }

        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            await LoadStocks();
        }

    }
}