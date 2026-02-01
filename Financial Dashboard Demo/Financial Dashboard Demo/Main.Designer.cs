namespace Financial_Dashboard_Demo
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelStocks = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            btnWallet = new Button();
            btnDiscover = new Button();
            btnPortoflio = new Button();
            btnWatchList = new Button();
            btnHome = new Button();
            dataGridView1 = new DataGridView();
            financePanel = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelStocks
            // 
            flowLayoutPanelStocks.AutoScroll = true;
            flowLayoutPanelStocks.Location = new Point(188, 361);
            flowLayoutPanelStocks.Name = "flowLayoutPanelStocks";
            flowLayoutPanelStocks.Size = new Size(642, 466);
            flowLayoutPanelStocks.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnWallet);
            groupBox1.Controls.Add(btnDiscover);
            groupBox1.Controls.Add(btnPortoflio);
            groupBox1.Controls.Add(btnWatchList);
            groupBox1.Controls.Add(btnHome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(153, 815);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnWallet
            // 
            btnWallet.Location = new Point(6, 278);
            btnWallet.Name = "btnWallet";
            btnWallet.Size = new Size(141, 58);
            btnWallet.TabIndex = 4;
            btnWallet.Text = "Wallet";
            btnWallet.UseVisualStyleBackColor = true;
            // 
            // btnDiscover
            // 
            btnDiscover.Location = new Point(6, 214);
            btnDiscover.Name = "btnDiscover";
            btnDiscover.Size = new Size(141, 58);
            btnDiscover.TabIndex = 3;
            btnDiscover.Text = "Discover";
            btnDiscover.UseVisualStyleBackColor = true;
            // 
            // btnPortoflio
            // 
            btnPortoflio.Location = new Point(6, 150);
            btnPortoflio.Name = "btnPortoflio";
            btnPortoflio.Size = new Size(141, 58);
            btnPortoflio.TabIndex = 2;
            btnPortoflio.Text = "Portfolio";
            btnPortoflio.UseVisualStyleBackColor = true;
            // 
            // btnWatchList
            // 
            btnWatchList.Location = new Point(6, 86);
            btnWatchList.Name = "btnWatchList";
            btnWatchList.Size = new Size(141, 58);
            btnWatchList.TabIndex = 1;
            btnWatchList.Text = "Watch List";
            btnWatchList.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(6, 22);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(141, 58);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseCompatibleTextRendering = true;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(845, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(604, 319);
            dataGridView1.TabIndex = 3;
            // 
            // financePanel
            // 
            financePanel.Location = new Point(188, 34);
            financePanel.Name = "financePanel";
            financePanel.Size = new Size(1261, 314);
            financePanel.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 848);
            Controls.Add(financePanel);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanelStocks);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load_1;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelStocks;
        private GroupBox groupBox1;
        private Button btnWatchList;
        private Button btnHome;
        private Button btnPortoflio;
        private Button btnDiscover;
        private Button btnWallet;
        private DataGridView dataGridView1;
        private Panel financePanel;
    }
}
