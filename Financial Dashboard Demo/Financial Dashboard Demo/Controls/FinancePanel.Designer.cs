namespace Financial_Dashboard_Demo.Controls
{
    partial class FinancePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblTitle = new Label();
            label1 = new Label();
            lblPortfolioValue = new Label();
            lblChange = new Label();
            groupBox1 = new GroupBox();
            btnYear = new Button();
            btnYearToDate = new Button();
            btnSixMonths = new Button();
            btnQuarter = new Button();
            btnMonth = new Button();
            btnWeek = new Button();
            label2 = new Label();
            lblAvaliable = new Label();
            lblProfitLoss = new Label();
            label5 = new Label();
            chartPortfolio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPortfolio).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 1;
            label1.Text = "Cash and Holdings";
            // 
            // lblPortfolioValue
            // 
            lblPortfolioValue.AutoSize = true;
            lblPortfolioValue.Font = new Font("Segoe UI", 22F);
            lblPortfolioValue.Location = new Point(12, 70);
            lblPortfolioValue.Name = "lblPortfolioValue";
            lblPortfolioValue.Size = new Size(114, 41);
            lblPortfolioValue.TabIndex = 2;
            lblPortfolioValue.Text = "$12345";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(12, 121);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(48, 15);
            lblChange.TabIndex = 3;
            lblChange.Text = "Change";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnYear);
            groupBox1.Controls.Add(btnYearToDate);
            groupBox1.Controls.Add(btnSixMonths);
            groupBox1.Controls.Add(btnQuarter);
            groupBox1.Controls.Add(btnMonth);
            groupBox1.Controls.Add(btnWeek);
            groupBox1.Location = new Point(918, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 48);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnYear
            // 
            btnYear.Location = new Point(271, 19);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(47, 23);
            btnYear.TabIndex = 5;
            btnYear.Text = "1Y";
            btnYear.UseVisualStyleBackColor = true;
            // 
            // btnYearToDate
            // 
            btnYearToDate.Location = new Point(218, 19);
            btnYearToDate.Name = "btnYearToDate";
            btnYearToDate.Size = new Size(47, 23);
            btnYearToDate.TabIndex = 4;
            btnYearToDate.Text = "YTD";
            btnYearToDate.UseVisualStyleBackColor = true;
            // 
            // btnSixMonths
            // 
            btnSixMonths.Location = new Point(165, 19);
            btnSixMonths.Name = "btnSixMonths";
            btnSixMonths.Size = new Size(47, 23);
            btnSixMonths.TabIndex = 3;
            btnSixMonths.Text = "6M";
            btnSixMonths.UseVisualStyleBackColor = true;
            // 
            // btnQuarter
            // 
            btnQuarter.Location = new Point(112, 19);
            btnQuarter.Name = "btnQuarter";
            btnQuarter.Size = new Size(47, 23);
            btnQuarter.TabIndex = 2;
            btnQuarter.Text = "3M";
            btnQuarter.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            btnMonth.Location = new Point(59, 19);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(47, 23);
            btnMonth.TabIndex = 1;
            btnMonth.Text = "1M";
            btnMonth.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            btnWeek.Location = new Point(6, 19);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(47, 23);
            btnWeek.TabIndex = 0;
            btnWeek.Text = "1W";
            btnWeek.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 271);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 5;
            label2.Text = "Avaliable USD";
            // 
            // lblAvaliable
            // 
            lblAvaliable.AutoSize = true;
            lblAvaliable.Font = new Font("Segoe UI", 12F);
            lblAvaliable.Location = new Point(12, 292);
            lblAvaliable.Name = "lblAvaliable";
            lblAvaliable.Size = new Size(46, 21);
            lblAvaliable.TabIndex = 6;
            lblAvaliable.Text = "$123";
            // 
            // lblProfitLoss
            // 
            lblProfitLoss.AutoSize = true;
            lblProfitLoss.Font = new Font("Segoe UI", 12F);
            lblProfitLoss.Location = new Point(212, 292);
            lblProfitLoss.Name = "lblProfitLoss";
            lblProfitLoss.Size = new Size(46, 21);
            lblProfitLoss.TabIndex = 8;
            lblProfitLoss.Text = "$123";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(212, 271);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 7;
            label5.Text = "Profit/Loss";
            // 
            // chartPortfolio
            // 
            chartPortfolio.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartPortfolio.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPortfolio.Legends.Add(legend2);
            chartPortfolio.Location = new Point(12, 139);
            chartPortfolio.Name = "chartPortfolio";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPortfolio.Series.Add(series2);
            chartPortfolio.Size = new Size(1212, 120);
            chartPortfolio.TabIndex = 9;
            chartPortfolio.Text = "chart1";
            // 
            // FinancePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(chartPortfolio);
            Controls.Add(lblProfitLoss);
            Controls.Add(label5);
            Controls.Add(lblAvaliable);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(lblChange);
            Controls.Add(lblPortfolioValue);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "FinancePanel";
            Size = new Size(1266, 344);
            Load += FinancePanel_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPortfolio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblPortfolioValue;
        private Label lblChange;
        private GroupBox groupBox1;
        private Button btnYear;
        private Button btnYearToDate;
        private Button btnSixMonths;
        private Button btnQuarter;
        private Button btnMonth;
        private Button btnWeek;
        private Label label2;
        private Label lblAvaliable;
        private Label lblProfitLoss;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPortfolio;
    }
}
