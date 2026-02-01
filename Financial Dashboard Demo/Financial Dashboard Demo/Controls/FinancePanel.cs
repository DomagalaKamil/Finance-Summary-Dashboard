using Financial_Dashboard_Demo.Data;
using Financial_Dashboard_Demo.Models;
using Financial_Dashboard_Demo.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Financial_Dashboard_Demo.Controls
{
    public partial class FinancePanel : UserControl
    {
        private readonly PortfolioRepository _repository;
        private readonly YahooPriceService _priceService;

        public FinancePanel()
        {
            InitializeComponent();

            _repository = new PortfolioRepository();
            _priceService = new YahooPriceService();
        }

        private async void FinancePanel_Load(object sender, EventArgs e)
        {
            await LoadDashboard();
        }

        private async Task LoadDashboard()
        {
            // --- load portfolio ---
            var portfolio = _repository.GetPortfolio();

            await _priceService.LoadPricesAsync(portfolio);

            // --- DB totals ---
            decimal totalIncome = _repository.GetTotalIncome();
            decimal totalExpenses = _repository.GetTotalExpenses();
            decimal totalInvested = _repository.GetTotalInvested();

            // --- cash ---
            decimal availableCash =
                totalIncome - totalExpenses - totalInvested;

            // --- current market value ---
            decimal portfolioMarketValue =
                portfolio.Sum(p => p.CurrentValue);

            // --- total account value ---
            decimal totalAccountValue =
                availableCash + portfolioMarketValue;

            // --- UI ---
            lblAvaliable.Text = $"{availableCash:N2}";
            lblPortfolioValue.Text = $"{totalAccountValue:N2}";

            // --- save snapshot ---
            _repository.SaveDailySnapshot(totalAccountValue);

            // --- draw equity curve ---
            LoadEquityCurve();
        }

        private void LoadEquityCurve()
        {
            var history = _repository.GetPortfolioHistory();
            RenderEquityChart(history);
        }

        private void RenderEquityChart(
            System.Collections.Generic.List<PortfolioSnapshot> history)
        {
            chartPortfolio.Series.Clear();
            chartPortfolio.ChartAreas.Clear();

            ChartArea area = new ChartArea("area");
            area.AxisX.IntervalType = DateTimeIntervalType.Months;
            area.AxisX.LabelStyle.Format = "MMM yyyy";
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chartPortfolio.ChartAreas.Add(area);

            Series equity = new Series("Portfolio Value")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                ChartArea = "area",
                XValueType = ChartValueType.DateTime
            };

            foreach (var point in history)
            {
                equity.Points.AddXY(
                    point.Date,
                    (double)point.TotalValue
                );
            }

            chartPortfolio.Series.Add(equity);
            chartPortfolio.Invalidate();
        }
    }
}
