using Financial_Dashboard_Demo.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Financial_Dashboard_Demo.Data
{
    public class PortfolioRepository
    {
        private readonly string _connectionString;

        public PortfolioRepository()
        {
            _connectionString =
                ConfigurationManager
                    .ConnectionStrings["FinanceDB"]
                    .ConnectionString;
        }

        // ===========================
        // PORTFOLIO HOLDINGS
        // ===========================
        public List<PortfolioStock> GetPortfolio()
        {
            var list = new List<PortfolioStock>();

            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            string sql = @"
                SELECT
                    stock_code,
                    stock_name,
                    SUM(quantity) AS total_quantity,
                    SUM(quantity * price_at_purchase) AS invested_value
                FROM portfolio_transactions
                GROUP BY stock_code, stock_name;
            ";

            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new PortfolioStock
                {
                    StockCode = reader.GetString("stock_code"),
                    StockName = reader.GetString("stock_name"),
                    Quantity = reader.GetInt32("total_quantity"),
                    InvestedValue = reader.GetDecimal("invested_value")
                });
            }

            return list;
        }

        // ===========================
        // CASH CALCULATIONS
        // ===========================
        public decimal GetTotalIncome()
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = new MySqlCommand(
                "SELECT IFNULL(SUM(transactionValue),0) FROM income",
                conn);

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public decimal GetTotalExpenses()
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = new MySqlCommand(
                "SELECT IFNULL(SUM(transactionValue),0) FROM expenses",
                conn);

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public decimal GetTotalInvested()
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = new MySqlCommand(
                @"SELECT IFNULL(SUM(price_at_purchase * quantity),0)
                  FROM portfolio_transactions",
                conn);

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        // ===========================
        // DAILY SNAPSHOT (EQUITY CURVE)
        // ===========================
        public void SaveDailySnapshot(decimal totalValue)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            string sql = @"
                INSERT INTO portfolio_history
                    (snapshot_date, total_value)
                VALUES
                    (CURDATE(), @value)
                ON DUPLICATE KEY UPDATE
                    total_value = @value;
            ";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@value", totalValue);
            cmd.ExecuteNonQuery();
        }

        // ===========================
        // HISTORY FOR CHART
        // ===========================
        public List<PortfolioSnapshot> GetPortfolioHistory()
        {
            var list = new List<PortfolioSnapshot>();

            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = new MySqlCommand(
                "SELECT snapshot_date, total_value FROM portfolio_history ORDER BY snapshot_date",
                conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new PortfolioSnapshot
                {
                    Date = reader.GetDateTime("snapshot_date"),
                    TotalValue = reader.GetDecimal("total_value")
                });
            }

            return list;
        }
    }
}
