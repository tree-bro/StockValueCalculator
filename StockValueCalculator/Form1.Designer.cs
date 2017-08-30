namespace StockValueCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarketPrice = new System.Windows.Forms.Label();
            this.txtMarketPrice = new System.Windows.Forms.TextBox();
            this.txtTradeTaxRate = new System.Windows.Forms.TextBox();
            this.txtProfitPerShare = new System.Windows.Forms.TextBox();
            this.lblProfitPerShare = new System.Windows.Forms.Label();
            this.txtCompanyDuration = new System.Windows.Forms.TextBox();
            this.lblCompanyDuration = new System.Windows.Forms.Label();
            this.txtDiscountRate = new System.Windows.Forms.TextBox();
            this.lblDiscountRate = new System.Windows.Forms.Label();
            this.txtNormalGrowthRate = new System.Windows.Forms.TextBox();
            this.lblNormalGrowthRate = new System.Windows.Forms.Label();
            this.txtHighSpeedGrowthRate = new System.Windows.Forms.TextBox();
            this.lblHighSpeedGrowthRate = new System.Windows.Forms.Label();
            this.txtHighSpeedGrowthDuration = new System.Windows.Forms.TextBox();
            this.lblHighSpeedGrowthDuration = new System.Windows.Forms.Label();
            this.txtProfitSharingRate = new System.Windows.Forms.TextBox();
            this.lblProfitSharingRate = new System.Windows.Forms.Label();
            this.lblTradeTaxRate = new System.Windows.Forms.Label();
            this.txtProfitSharingTax = new System.Windows.Forms.TextBox();
            this.lblProfitSharingTax = new System.Windows.Forms.Label();
            this.txtDepressionFrequency = new System.Windows.Forms.TextBox();
            this.lblDepressionFrequency = new System.Windows.Forms.Label();
            this.txtDepressionLossRate = new System.Windows.Forms.TextBox();
            this.lblDepressionLossRate = new System.Windows.Forms.Label();
            this.txtStockHeldDuration = new System.Windows.Forms.TextBox();
            this.lblStockHoldDuration = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnParseCompanyDetails = new System.Windows.Forms.Button();
            this.openFileDialogForCompanyDetails = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblMarketPrice
            // 
            this.lblMarketPrice.AutoSize = true;
            this.lblMarketPrice.Location = new System.Drawing.Point(37, 73);
            this.lblMarketPrice.Name = "lblMarketPrice";
            this.lblMarketPrice.Size = new System.Drawing.Size(119, 15);
            this.lblMarketPrice.TabIndex = 0;
            this.lblMarketPrice.Text = "Market Price: ";
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.Location = new System.Drawing.Point(273, 70);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.Size = new System.Drawing.Size(212, 25);
            this.txtMarketPrice.TabIndex = 1;
            this.txtMarketPrice.Text = "10.0";
            // 
            // txtTradeTaxRate
            // 
            this.txtTradeTaxRate.Location = new System.Drawing.Point(273, 106);
            this.txtTradeTaxRate.Name = "txtTradeTaxRate";
            this.txtTradeTaxRate.Size = new System.Drawing.Size(212, 25);
            this.txtTradeTaxRate.TabIndex = 3;
            this.txtTradeTaxRate.Text = "1";
            // 
            // txtProfitPerShare
            // 
            this.txtProfitPerShare.Location = new System.Drawing.Point(273, 142);
            this.txtProfitPerShare.Name = "txtProfitPerShare";
            this.txtProfitPerShare.Size = new System.Drawing.Size(212, 25);
            this.txtProfitPerShare.TabIndex = 5;
            this.txtProfitPerShare.Text = "1.0";
            // 
            // lblProfitPerShare
            // 
            this.lblProfitPerShare.AutoSize = true;
            this.lblProfitPerShare.Location = new System.Drawing.Point(37, 145);
            this.lblProfitPerShare.Name = "lblProfitPerShare";
            this.lblProfitPerShare.Size = new System.Drawing.Size(151, 15);
            this.lblProfitPerShare.TabIndex = 4;
            this.lblProfitPerShare.Text = "Profit Per Share: ";
            // 
            // txtCompanyDuration
            // 
            this.txtCompanyDuration.Location = new System.Drawing.Point(273, 219);
            this.txtCompanyDuration.Name = "txtCompanyDuration";
            this.txtCompanyDuration.Size = new System.Drawing.Size(212, 25);
            this.txtCompanyDuration.TabIndex = 7;
            this.txtCompanyDuration.Text = "50";
            // 
            // lblCompanyDuration
            // 
            this.lblCompanyDuration.AutoSize = true;
            this.lblCompanyDuration.Location = new System.Drawing.Point(37, 222);
            this.lblCompanyDuration.Name = "lblCompanyDuration";
            this.lblCompanyDuration.Size = new System.Drawing.Size(207, 15);
            this.lblCompanyDuration.TabIndex = 6;
            this.lblCompanyDuration.Text = "Company Duration (year): ";
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.Location = new System.Drawing.Point(273, 256);
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Size = new System.Drawing.Size(212, 25);
            this.txtDiscountRate.TabIndex = 9;
            this.txtDiscountRate.Text = "5.0";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Location = new System.Drawing.Point(37, 259);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(143, 15);
            this.lblDiscountRate.TabIndex = 8;
            this.lblDiscountRate.Text = "Discount Rate %: ";
            // 
            // txtNormalGrowthRate
            // 
            this.txtNormalGrowthRate.Location = new System.Drawing.Point(273, 291);
            this.txtNormalGrowthRate.Name = "txtNormalGrowthRate";
            this.txtNormalGrowthRate.Size = new System.Drawing.Size(212, 25);
            this.txtNormalGrowthRate.TabIndex = 11;
            this.txtNormalGrowthRate.Text = "1.0";
            // 
            // lblNormalGrowthRate
            // 
            this.lblNormalGrowthRate.AutoSize = true;
            this.lblNormalGrowthRate.Location = new System.Drawing.Point(37, 294);
            this.lblNormalGrowthRate.Name = "lblNormalGrowthRate";
            this.lblNormalGrowthRate.Size = new System.Drawing.Size(183, 15);
            this.lblNormalGrowthRate.TabIndex = 10;
            this.lblNormalGrowthRate.Text = "Normal Growth Rate %: ";
            // 
            // txtHighSpeedGrowthRate
            // 
            this.txtHighSpeedGrowthRate.Location = new System.Drawing.Point(273, 328);
            this.txtHighSpeedGrowthRate.Name = "txtHighSpeedGrowthRate";
            this.txtHighSpeedGrowthRate.Size = new System.Drawing.Size(212, 25);
            this.txtHighSpeedGrowthRate.TabIndex = 13;
            this.txtHighSpeedGrowthRate.Text = "5.0";
            // 
            // lblHighSpeedGrowthRate
            // 
            this.lblHighSpeedGrowthRate.AutoSize = true;
            this.lblHighSpeedGrowthRate.Location = new System.Drawing.Point(37, 331);
            this.lblHighSpeedGrowthRate.Name = "lblHighSpeedGrowthRate";
            this.lblHighSpeedGrowthRate.Size = new System.Drawing.Size(215, 15);
            this.lblHighSpeedGrowthRate.TabIndex = 12;
            this.lblHighSpeedGrowthRate.Text = "High Speed Growth Rate %: ";
            // 
            // txtHighSpeedGrowthDuration
            // 
            this.txtHighSpeedGrowthDuration.Location = new System.Drawing.Point(273, 368);
            this.txtHighSpeedGrowthDuration.Name = "txtHighSpeedGrowthDuration";
            this.txtHighSpeedGrowthDuration.Size = new System.Drawing.Size(212, 25);
            this.txtHighSpeedGrowthDuration.TabIndex = 15;
            this.txtHighSpeedGrowthDuration.Text = "3";
            // 
            // lblHighSpeedGrowthDuration
            // 
            this.lblHighSpeedGrowthDuration.AutoSize = true;
            this.lblHighSpeedGrowthDuration.Location = new System.Drawing.Point(37, 371);
            this.lblHighSpeedGrowthDuration.Name = "lblHighSpeedGrowthDuration";
            this.lblHighSpeedGrowthDuration.Size = new System.Drawing.Size(231, 15);
            this.lblHighSpeedGrowthDuration.TabIndex = 14;
            this.lblHighSpeedGrowthDuration.Text = "High Speed Growth Duration: ";
            // 
            // txtProfitSharingRate
            // 
            this.txtProfitSharingRate.Location = new System.Drawing.Point(273, 180);
            this.txtProfitSharingRate.Name = "txtProfitSharingRate";
            this.txtProfitSharingRate.Size = new System.Drawing.Size(212, 25);
            this.txtProfitSharingRate.TabIndex = 17;
            this.txtProfitSharingRate.Text = "20";
            // 
            // lblProfitSharingRate
            // 
            this.lblProfitSharingRate.AutoSize = true;
            this.lblProfitSharingRate.Location = new System.Drawing.Point(37, 183);
            this.lblProfitSharingRate.Name = "lblProfitSharingRate";
            this.lblProfitSharingRate.Size = new System.Drawing.Size(191, 15);
            this.lblProfitSharingRate.TabIndex = 16;
            this.lblProfitSharingRate.Text = "Profit Sharing Rate %: ";
            // 
            // lblTradeTaxRate
            // 
            this.lblTradeTaxRate.AutoSize = true;
            this.lblTradeTaxRate.Location = new System.Drawing.Point(37, 109);
            this.lblTradeTaxRate.Name = "lblTradeTaxRate";
            this.lblTradeTaxRate.Size = new System.Drawing.Size(167, 15);
            this.lblTradeTaxRate.TabIndex = 18;
            this.lblTradeTaxRate.Text = "Trading Tax Rate %: ";
            // 
            // txtProfitSharingTax
            // 
            this.txtProfitSharingTax.Location = new System.Drawing.Point(273, 404);
            this.txtProfitSharingTax.Name = "txtProfitSharingTax";
            this.txtProfitSharingTax.Size = new System.Drawing.Size(212, 25);
            this.txtProfitSharingTax.TabIndex = 20;
            this.txtProfitSharingTax.Text = "0.5";
            // 
            // lblProfitSharingTax
            // 
            this.lblProfitSharingTax.AutoSize = true;
            this.lblProfitSharingTax.Location = new System.Drawing.Point(37, 407);
            this.lblProfitSharingTax.Name = "lblProfitSharingTax";
            this.lblProfitSharingTax.Size = new System.Drawing.Size(215, 15);
            this.lblProfitSharingTax.TabIndex = 19;
            this.lblProfitSharingTax.Text = "Profit Sharing Tax Rate %:";
            // 
            // txtDepressionFrequency
            // 
            this.txtDepressionFrequency.Location = new System.Drawing.Point(273, 441);
            this.txtDepressionFrequency.Name = "txtDepressionFrequency";
            this.txtDepressionFrequency.Size = new System.Drawing.Size(212, 25);
            this.txtDepressionFrequency.TabIndex = 22;
            this.txtDepressionFrequency.Text = "5";
            // 
            // lblDepressionFrequency
            // 
            this.lblDepressionFrequency.AutoSize = true;
            this.lblDepressionFrequency.Location = new System.Drawing.Point(37, 444);
            this.lblDepressionFrequency.Name = "lblDepressionFrequency";
            this.lblDepressionFrequency.Size = new System.Drawing.Size(239, 15);
            this.lblDepressionFrequency.TabIndex = 21;
            this.lblDepressionFrequency.Text = "Depression Frequency (years):";
            // 
            // txtDepressionLossRate
            // 
            this.txtDepressionLossRate.Location = new System.Drawing.Point(273, 476);
            this.txtDepressionLossRate.Name = "txtDepressionLossRate";
            this.txtDepressionLossRate.Size = new System.Drawing.Size(212, 25);
            this.txtDepressionLossRate.TabIndex = 24;
            this.txtDepressionLossRate.Text = "90.0";
            // 
            // lblDepressionLossRate
            // 
            this.lblDepressionLossRate.AutoSize = true;
            this.lblDepressionLossRate.Location = new System.Drawing.Point(37, 479);
            this.lblDepressionLossRate.Name = "lblDepressionLossRate";
            this.lblDepressionLossRate.Size = new System.Drawing.Size(191, 15);
            this.lblDepressionLossRate.TabIndex = 23;
            this.lblDepressionLossRate.Text = "Depression Loss Rate %:";
            // 
            // txtStockHeldDuration
            // 
            this.txtStockHeldDuration.Location = new System.Drawing.Point(273, 516);
            this.txtStockHeldDuration.Name = "txtStockHeldDuration";
            this.txtStockHeldDuration.Size = new System.Drawing.Size(212, 25);
            this.txtStockHeldDuration.TabIndex = 26;
            this.txtStockHeldDuration.Text = "10";
            // 
            // lblStockHoldDuration
            // 
            this.lblStockHoldDuration.AutoSize = true;
            this.lblStockHoldDuration.Location = new System.Drawing.Point(37, 519);
            this.lblStockHoldDuration.Name = "lblStockHoldDuration";
            this.lblStockHoldDuration.Size = new System.Drawing.Size(223, 15);
            this.lblStockHoldDuration.TabIndex = 25;
            this.lblStockHoldDuration.Text = "Stock Held Duration (year):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(273, 576);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(166, 43);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnParseCompanyDetails
            // 
            this.btnParseCompanyDetails.Location = new System.Drawing.Point(70, 576);
            this.btnParseCompanyDetails.Name = "btnParseCompanyDetails";
            this.btnParseCompanyDetails.Size = new System.Drawing.Size(166, 43);
            this.btnParseCompanyDetails.TabIndex = 28;
            this.btnParseCompanyDetails.Text = "Parse Details";
            this.btnParseCompanyDetails.UseVisualStyleBackColor = true;
            this.btnParseCompanyDetails.Click += new System.EventHandler(this.btnParseCompanyDetails_Click);
            // 
            // openFileDialogForCompanyDetails
            // 
            this.openFileDialogForCompanyDetails.FileName = "openFileDialogForCompanyDetails";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 668);
            this.Controls.Add(this.btnParseCompanyDetails);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStockHeldDuration);
            this.Controls.Add(this.lblStockHoldDuration);
            this.Controls.Add(this.txtDepressionLossRate);
            this.Controls.Add(this.lblDepressionLossRate);
            this.Controls.Add(this.txtDepressionFrequency);
            this.Controls.Add(this.lblDepressionFrequency);
            this.Controls.Add(this.txtProfitSharingTax);
            this.Controls.Add(this.lblProfitSharingTax);
            this.Controls.Add(this.lblTradeTaxRate);
            this.Controls.Add(this.txtProfitSharingRate);
            this.Controls.Add(this.lblProfitSharingRate);
            this.Controls.Add(this.txtHighSpeedGrowthDuration);
            this.Controls.Add(this.lblHighSpeedGrowthDuration);
            this.Controls.Add(this.txtHighSpeedGrowthRate);
            this.Controls.Add(this.lblHighSpeedGrowthRate);
            this.Controls.Add(this.txtNormalGrowthRate);
            this.Controls.Add(this.lblNormalGrowthRate);
            this.Controls.Add(this.txtDiscountRate);
            this.Controls.Add(this.lblDiscountRate);
            this.Controls.Add(this.txtCompanyDuration);
            this.Controls.Add(this.lblCompanyDuration);
            this.Controls.Add(this.txtProfitPerShare);
            this.Controls.Add(this.lblProfitPerShare);
            this.Controls.Add(this.txtTradeTaxRate);
            this.Controls.Add(this.txtMarketPrice);
            this.Controls.Add(this.lblMarketPrice);
            this.Name = "Form1";
            this.Text = "StockValueCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarketPrice;
        private System.Windows.Forms.TextBox txtMarketPrice;
        private System.Windows.Forms.TextBox txtTradeTaxRate;
        private System.Windows.Forms.TextBox txtProfitPerShare;
        private System.Windows.Forms.Label lblProfitPerShare;
        private System.Windows.Forms.TextBox txtCompanyDuration;
        private System.Windows.Forms.Label lblCompanyDuration;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.Label lblDiscountRate;
        private System.Windows.Forms.TextBox txtNormalGrowthRate;
        private System.Windows.Forms.Label lblNormalGrowthRate;
        private System.Windows.Forms.TextBox txtHighSpeedGrowthRate;
        private System.Windows.Forms.Label lblHighSpeedGrowthRate;
        private System.Windows.Forms.TextBox txtHighSpeedGrowthDuration;
        private System.Windows.Forms.Label lblHighSpeedGrowthDuration;
        private System.Windows.Forms.TextBox txtProfitSharingRate;
        private System.Windows.Forms.Label lblProfitSharingRate;
        private System.Windows.Forms.Label lblTradeTaxRate;
        private System.Windows.Forms.TextBox txtProfitSharingTax;
        private System.Windows.Forms.Label lblProfitSharingTax;
        private System.Windows.Forms.TextBox txtDepressionFrequency;
        private System.Windows.Forms.Label lblDepressionFrequency;
        private System.Windows.Forms.TextBox txtDepressionLossRate;
        private System.Windows.Forms.Label lblDepressionLossRate;
        private System.Windows.Forms.TextBox txtStockHeldDuration;
        private System.Windows.Forms.Label lblStockHoldDuration;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnParseCompanyDetails;
        private System.Windows.Forms.OpenFileDialog openFileDialogForCompanyDetails;
    }
}

