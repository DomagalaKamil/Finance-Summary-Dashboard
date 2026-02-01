namespace Financial_Dashboard_Demo.Controls
{
    partial class StockPanel
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
            lblCompany = new Label();
            lblMarketCap = new Label();
            lblChange = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(26, 16);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(38, 15);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "label1";
            // 
            // lblMarketCap
            // 
            lblMarketCap.AutoSize = true;
            lblMarketCap.Location = new Point(228, 16);
            lblMarketCap.Name = "lblMarketCap";
            lblMarketCap.Size = new Size(38, 15);
            lblMarketCap.TabIndex = 2;
            lblMarketCap.Text = "label1";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(329, 16);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(38, 15);
            lblChange.TabIndex = 3;
            lblChange.Text = "label1";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(127, 16);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "label1";
            // 
            // StockPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice);
            Controls.Add(lblChange);
            Controls.Add(lblMarketCap);
            Controls.Add(lblCompany);
            Name = "StockPanel";
            Size = new Size(448, 46);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompany;
        private Label lblMarketCap;
        private Label lblChange;
        private Label lblPrice;
    }
}
