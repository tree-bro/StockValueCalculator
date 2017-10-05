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
            this.lblStockHeldDuration = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnParseCompanyDetails = new System.Windows.Forms.Button();
            this.openFileDialogForCompanyDetails = new System.Windows.Forms.OpenFileDialog();
            this.btnParseCompanyDetailsFromServer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.calculationPage = new System.Windows.Forms.TabPage();
            this.groupBoxForManualInputParams = new System.Windows.Forms.GroupBox();
            this.groupBoxForServerParseParams = new System.Windows.Forms.GroupBox();
            this.stockMarketPage = new System.Windows.Forms.TabPage();
            this.groupBoxForCheckingParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxKeepPreferStockID = new System.Windows.Forms.CheckBox();
            this.btnClearPreferStockList = new System.Windows.Forms.Button();
            this.groupBoxForStockInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxStockIDList = new System.Windows.Forms.ComboBox();
            this.lblPERatio = new System.Windows.Forms.Label();
            this.txtPERatio = new System.Windows.Forms.TextBox();
            this.lblDateOfInfo = new System.Windows.Forms.Label();
            this.txtDateOfInfo = new System.Windows.Forms.TextBox();
            this.lblSelectedStockID = new System.Windows.Forms.Label();
            this.lblCompanyProfitPerShare = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyProfitPerShare = new System.Windows.Forms.TextBox();
            this.txtLastTradingPrice = new System.Windows.Forms.TextBox();
            this.lblLastTradingPrice = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnRetrieveStockInfo = new System.Windows.Forms.Button();
            this.lblFirstYearProfitSharing = new System.Windows.Forms.Label();
            this.txtFirstYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblSecondYearProfitSharing = new System.Windows.Forms.Label();
            this.txtSecondYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblThirdYearProfitSharing = new System.Windows.Forms.Label();
            this.txtThirdYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblFourthYearProfitSharing = new System.Windows.Forms.Label();
            this.txtFourthYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblFifthYearProfitSharing = new System.Windows.Forms.Label();
            this.txtFifthYearProfitSharing = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.calculationPage.SuspendLayout();
            this.groupBoxForManualInputParams.SuspendLayout();
            this.groupBoxForServerParseParams.SuspendLayout();
            this.stockMarketPage.SuspendLayout();
            this.groupBoxForCheckingParameters.SuspendLayout();
            this.groupBoxForStockInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarketPrice
            // 
            this.lblMarketPrice.AutoSize = true;
            this.lblMarketPrice.Location = new System.Drawing.Point(7, 31);
            this.lblMarketPrice.Name = "lblMarketPrice";
            this.lblMarketPrice.Size = new System.Drawing.Size(119, 15);
            this.lblMarketPrice.TabIndex = 0;
            this.lblMarketPrice.Text = "Market Price: ";
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.Location = new System.Drawing.Point(243, 29);
            this.txtMarketPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.Size = new System.Drawing.Size(212, 25);
            this.txtMarketPrice.TabIndex = 1;
            this.txtMarketPrice.Text = "10.0";
            // 
            // txtTradeTaxRate
            // 
            this.txtTradeTaxRate.Location = new System.Drawing.Point(243, 31);
            this.txtTradeTaxRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTradeTaxRate.Name = "txtTradeTaxRate";
            this.txtTradeTaxRate.Size = new System.Drawing.Size(212, 25);
            this.txtTradeTaxRate.TabIndex = 3;
            this.txtTradeTaxRate.Text = "1";
            // 
            // txtProfitPerShare
            // 
            this.txtProfitPerShare.Location = new System.Drawing.Point(243, 68);
            this.txtProfitPerShare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfitPerShare.Name = "txtProfitPerShare";
            this.txtProfitPerShare.Size = new System.Drawing.Size(212, 25);
            this.txtProfitPerShare.TabIndex = 5;
            this.txtProfitPerShare.Text = "1.0";
            // 
            // lblProfitPerShare
            // 
            this.lblProfitPerShare.AutoSize = true;
            this.lblProfitPerShare.Location = new System.Drawing.Point(7, 70);
            this.lblProfitPerShare.Name = "lblProfitPerShare";
            this.lblProfitPerShare.Size = new System.Drawing.Size(151, 15);
            this.lblProfitPerShare.TabIndex = 4;
            this.lblProfitPerShare.Text = "Profit Per Share: ";
            // 
            // txtCompanyDuration
            // 
            this.txtCompanyDuration.Location = new System.Drawing.Point(243, 73);
            this.txtCompanyDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyDuration.Name = "txtCompanyDuration";
            this.txtCompanyDuration.Size = new System.Drawing.Size(212, 25);
            this.txtCompanyDuration.TabIndex = 7;
            this.txtCompanyDuration.Text = "50";
            // 
            // lblCompanyDuration
            // 
            this.lblCompanyDuration.AutoSize = true;
            this.lblCompanyDuration.Location = new System.Drawing.Point(7, 77);
            this.lblCompanyDuration.Name = "lblCompanyDuration";
            this.lblCompanyDuration.Size = new System.Drawing.Size(207, 15);
            this.lblCompanyDuration.TabIndex = 6;
            this.lblCompanyDuration.Text = "Company Duration (year): ";
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.Location = new System.Drawing.Point(243, 110);
            this.txtDiscountRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Size = new System.Drawing.Size(212, 25);
            this.txtDiscountRate.TabIndex = 9;
            this.txtDiscountRate.Text = "5.0";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Location = new System.Drawing.Point(7, 113);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(143, 15);
            this.lblDiscountRate.TabIndex = 8;
            this.lblDiscountRate.Text = "Discount Rate %: ";
            // 
            // txtNormalGrowthRate
            // 
            this.txtNormalGrowthRate.Location = new System.Drawing.Point(243, 146);
            this.txtNormalGrowthRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNormalGrowthRate.Name = "txtNormalGrowthRate";
            this.txtNormalGrowthRate.Size = new System.Drawing.Size(212, 25);
            this.txtNormalGrowthRate.TabIndex = 11;
            this.txtNormalGrowthRate.Text = "1.0";
            // 
            // lblNormalGrowthRate
            // 
            this.lblNormalGrowthRate.AutoSize = true;
            this.lblNormalGrowthRate.Location = new System.Drawing.Point(7, 148);
            this.lblNormalGrowthRate.Name = "lblNormalGrowthRate";
            this.lblNormalGrowthRate.Size = new System.Drawing.Size(183, 15);
            this.lblNormalGrowthRate.TabIndex = 10;
            this.lblNormalGrowthRate.Text = "Normal Growth Rate %: ";
            // 
            // txtHighSpeedGrowthRate
            // 
            this.txtHighSpeedGrowthRate.Location = new System.Drawing.Point(243, 182);
            this.txtHighSpeedGrowthRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHighSpeedGrowthRate.Name = "txtHighSpeedGrowthRate";
            this.txtHighSpeedGrowthRate.Size = new System.Drawing.Size(212, 25);
            this.txtHighSpeedGrowthRate.TabIndex = 13;
            this.txtHighSpeedGrowthRate.Text = "5.0";
            // 
            // lblHighSpeedGrowthRate
            // 
            this.lblHighSpeedGrowthRate.AutoSize = true;
            this.lblHighSpeedGrowthRate.Location = new System.Drawing.Point(7, 186);
            this.lblHighSpeedGrowthRate.Name = "lblHighSpeedGrowthRate";
            this.lblHighSpeedGrowthRate.Size = new System.Drawing.Size(215, 15);
            this.lblHighSpeedGrowthRate.TabIndex = 12;
            this.lblHighSpeedGrowthRate.Text = "High Speed Growth Rate %: ";
            // 
            // txtHighSpeedGrowthDuration
            // 
            this.txtHighSpeedGrowthDuration.Location = new System.Drawing.Point(243, 222);
            this.txtHighSpeedGrowthDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHighSpeedGrowthDuration.Name = "txtHighSpeedGrowthDuration";
            this.txtHighSpeedGrowthDuration.Size = new System.Drawing.Size(212, 25);
            this.txtHighSpeedGrowthDuration.TabIndex = 15;
            this.txtHighSpeedGrowthDuration.Text = "3";
            // 
            // lblHighSpeedGrowthDuration
            // 
            this.lblHighSpeedGrowthDuration.AutoSize = true;
            this.lblHighSpeedGrowthDuration.Location = new System.Drawing.Point(7, 226);
            this.lblHighSpeedGrowthDuration.Name = "lblHighSpeedGrowthDuration";
            this.lblHighSpeedGrowthDuration.Size = new System.Drawing.Size(231, 15);
            this.lblHighSpeedGrowthDuration.TabIndex = 14;
            this.lblHighSpeedGrowthDuration.Text = "High Speed Growth Duration: ";
            // 
            // txtProfitSharingRate
            // 
            this.txtProfitSharingRate.Location = new System.Drawing.Point(243, 104);
            this.txtProfitSharingRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfitSharingRate.Name = "txtProfitSharingRate";
            this.txtProfitSharingRate.Size = new System.Drawing.Size(212, 25);
            this.txtProfitSharingRate.TabIndex = 17;
            this.txtProfitSharingRate.Text = "20";
            // 
            // lblProfitSharingRate
            // 
            this.lblProfitSharingRate.AutoSize = true;
            this.lblProfitSharingRate.Location = new System.Drawing.Point(7, 107);
            this.lblProfitSharingRate.Name = "lblProfitSharingRate";
            this.lblProfitSharingRate.Size = new System.Drawing.Size(191, 15);
            this.lblProfitSharingRate.TabIndex = 16;
            this.lblProfitSharingRate.Text = "Profit Sharing Rate %: ";
            // 
            // lblTradeTaxRate
            // 
            this.lblTradeTaxRate.AutoSize = true;
            this.lblTradeTaxRate.Location = new System.Drawing.Point(7, 33);
            this.lblTradeTaxRate.Name = "lblTradeTaxRate";
            this.lblTradeTaxRate.Size = new System.Drawing.Size(167, 15);
            this.lblTradeTaxRate.TabIndex = 18;
            this.lblTradeTaxRate.Text = "Trading Tax Rate %: ";
            // 
            // txtProfitSharingTax
            // 
            this.txtProfitSharingTax.Location = new System.Drawing.Point(243, 258);
            this.txtProfitSharingTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfitSharingTax.Name = "txtProfitSharingTax";
            this.txtProfitSharingTax.Size = new System.Drawing.Size(212, 25);
            this.txtProfitSharingTax.TabIndex = 20;
            this.txtProfitSharingTax.Text = "0.5";
            // 
            // lblProfitSharingTax
            // 
            this.lblProfitSharingTax.AutoSize = true;
            this.lblProfitSharingTax.Location = new System.Drawing.Point(7, 262);
            this.lblProfitSharingTax.Name = "lblProfitSharingTax";
            this.lblProfitSharingTax.Size = new System.Drawing.Size(215, 15);
            this.lblProfitSharingTax.TabIndex = 19;
            this.lblProfitSharingTax.Text = "Profit Sharing Tax Rate %:";
            // 
            // txtDepressionFrequency
            // 
            this.txtDepressionFrequency.Location = new System.Drawing.Point(243, 296);
            this.txtDepressionFrequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepressionFrequency.Name = "txtDepressionFrequency";
            this.txtDepressionFrequency.Size = new System.Drawing.Size(212, 25);
            this.txtDepressionFrequency.TabIndex = 22;
            this.txtDepressionFrequency.Text = "5";
            // 
            // lblDepressionFrequency
            // 
            this.lblDepressionFrequency.AutoSize = true;
            this.lblDepressionFrequency.Location = new System.Drawing.Point(7, 298);
            this.lblDepressionFrequency.Name = "lblDepressionFrequency";
            this.lblDepressionFrequency.Size = new System.Drawing.Size(239, 15);
            this.lblDepressionFrequency.TabIndex = 21;
            this.lblDepressionFrequency.Text = "Depression Frequency (years):";
            // 
            // txtDepressionLossRate
            // 
            this.txtDepressionLossRate.Location = new System.Drawing.Point(243, 330);
            this.txtDepressionLossRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepressionLossRate.Name = "txtDepressionLossRate";
            this.txtDepressionLossRate.Size = new System.Drawing.Size(212, 25);
            this.txtDepressionLossRate.TabIndex = 24;
            this.txtDepressionLossRate.Text = "90.0";
            // 
            // lblDepressionLossRate
            // 
            this.lblDepressionLossRate.AutoSize = true;
            this.lblDepressionLossRate.Location = new System.Drawing.Point(7, 333);
            this.lblDepressionLossRate.Name = "lblDepressionLossRate";
            this.lblDepressionLossRate.Size = new System.Drawing.Size(191, 15);
            this.lblDepressionLossRate.TabIndex = 23;
            this.lblDepressionLossRate.Text = "Depression Loss Rate %:";
            // 
            // txtStockHeldDuration
            // 
            this.txtStockHeldDuration.Location = new System.Drawing.Point(243, 370);
            this.txtStockHeldDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockHeldDuration.Name = "txtStockHeldDuration";
            this.txtStockHeldDuration.Size = new System.Drawing.Size(212, 25);
            this.txtStockHeldDuration.TabIndex = 26;
            this.txtStockHeldDuration.Text = "10";
            // 
            // lblStockHeldDuration
            // 
            this.lblStockHeldDuration.AutoSize = true;
            this.lblStockHeldDuration.Location = new System.Drawing.Point(7, 373);
            this.lblStockHeldDuration.Name = "lblStockHeldDuration";
            this.lblStockHeldDuration.Size = new System.Drawing.Size(223, 15);
            this.lblStockHeldDuration.TabIndex = 25;
            this.lblStockHeldDuration.Text = "Stock Held Duration (year):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(124, 632);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(236, 42);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnParseCompanyDetails
            // 
            this.btnParseCompanyDetails.Location = new System.Drawing.Point(124, 571);
            this.btnParseCompanyDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParseCompanyDetails.Name = "btnParseCompanyDetails";
            this.btnParseCompanyDetails.Size = new System.Drawing.Size(236, 42);
            this.btnParseCompanyDetails.TabIndex = 28;
            this.btnParseCompanyDetails.Text = "Parse Details From File";
            this.btnParseCompanyDetails.UseVisualStyleBackColor = true;
            this.btnParseCompanyDetails.Click += new System.EventHandler(this.btnParseCompanyDetails_Click);
            // 
            // openFileDialogForCompanyDetails
            // 
            this.openFileDialogForCompanyDetails.FileName = "openFileDialogForCompanyDetails";
            // 
            // btnParseCompanyDetailsFromServer
            // 
            this.btnParseCompanyDetailsFromServer.Location = new System.Drawing.Point(264, 565);
            this.btnParseCompanyDetailsFromServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParseCompanyDetailsFromServer.Name = "btnParseCompanyDetailsFromServer";
            this.btnParseCompanyDetailsFromServer.Size = new System.Drawing.Size(236, 42);
            this.btnParseCompanyDetailsFromServer.TabIndex = 29;
            this.btnParseCompanyDetailsFromServer.Text = "Parse Details From Server";
            this.btnParseCompanyDetailsFromServer.UseVisualStyleBackColor = true;
            this.btnParseCompanyDetailsFromServer.Click += new System.EventHandler(this.btnParseCompanyDetailsFromServer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.calculationPage);
            this.tabControl1.Controls.Add(this.stockMarketPage);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 720);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragDrop);
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragEnter);
            // 
            // calculationPage
            // 
            this.calculationPage.Controls.Add(this.groupBoxForManualInputParams);
            this.calculationPage.Controls.Add(this.groupBoxForServerParseParams);
            this.calculationPage.Controls.Add(this.btnCalculate);
            this.calculationPage.Controls.Add(this.btnParseCompanyDetails);
            this.calculationPage.Location = new System.Drawing.Point(4, 25);
            this.calculationPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculationPage.Name = "calculationPage";
            this.calculationPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculationPage.Size = new System.Drawing.Size(507, 691);
            this.calculationPage.TabIndex = 0;
            this.calculationPage.Text = "calculationPage";
            this.calculationPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxForManualInputParams
            // 
            this.groupBoxForManualInputParams.Controls.Add(this.lblTradeTaxRate);
            this.groupBoxForManualInputParams.Controls.Add(this.txtHighSpeedGrowthDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.lblHighSpeedGrowthDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.txtTradeTaxRate);
            this.groupBoxForManualInputParams.Controls.Add(this.txtStockHeldDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.txtHighSpeedGrowthRate);
            this.groupBoxForManualInputParams.Controls.Add(this.lblStockHeldDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.lblHighSpeedGrowthRate);
            this.groupBoxForManualInputParams.Controls.Add(this.lblCompanyDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.lblProfitSharingTax);
            this.groupBoxForManualInputParams.Controls.Add(this.txtDepressionLossRate);
            this.groupBoxForManualInputParams.Controls.Add(this.txtNormalGrowthRate);
            this.groupBoxForManualInputParams.Controls.Add(this.txtCompanyDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.txtProfitSharingTax);
            this.groupBoxForManualInputParams.Controls.Add(this.lblDepressionLossRate);
            this.groupBoxForManualInputParams.Controls.Add(this.lblNormalGrowthRate);
            this.groupBoxForManualInputParams.Controls.Add(this.lblDiscountRate);
            this.groupBoxForManualInputParams.Controls.Add(this.lblDepressionFrequency);
            this.groupBoxForManualInputParams.Controls.Add(this.txtDepressionFrequency);
            this.groupBoxForManualInputParams.Controls.Add(this.txtDiscountRate);
            this.groupBoxForManualInputParams.Location = new System.Drawing.Point(8, 156);
            this.groupBoxForManualInputParams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForManualInputParams.Name = "groupBoxForManualInputParams";
            this.groupBoxForManualInputParams.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForManualInputParams.Size = new System.Drawing.Size(476, 406);
            this.groupBoxForManualInputParams.TabIndex = 30;
            this.groupBoxForManualInputParams.TabStop = false;
            this.groupBoxForManualInputParams.Text = "Manual Input Params";
            // 
            // groupBoxForServerParseParams
            // 
            this.groupBoxForServerParseParams.Controls.Add(this.lblMarketPrice);
            this.groupBoxForServerParseParams.Controls.Add(this.txtProfitPerShare);
            this.groupBoxForServerParseParams.Controls.Add(this.lblProfitSharingRate);
            this.groupBoxForServerParseParams.Controls.Add(this.txtMarketPrice);
            this.groupBoxForServerParseParams.Controls.Add(this.lblProfitPerShare);
            this.groupBoxForServerParseParams.Controls.Add(this.txtProfitSharingRate);
            this.groupBoxForServerParseParams.Location = new System.Drawing.Point(8, 8);
            this.groupBoxForServerParseParams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForServerParseParams.Name = "groupBoxForServerParseParams";
            this.groupBoxForServerParseParams.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForServerParseParams.Size = new System.Drawing.Size(476, 140);
            this.groupBoxForServerParseParams.TabIndex = 29;
            this.groupBoxForServerParseParams.TabStop = false;
            this.groupBoxForServerParseParams.Text = "Server Parsable Params";
            // 
            // stockMarketPage
            // 
            this.stockMarketPage.Controls.Add(this.groupBoxForCheckingParameters);
            this.stockMarketPage.Controls.Add(this.btnClearPreferStockList);
            this.stockMarketPage.Controls.Add(this.groupBoxForStockInfo);
            this.stockMarketPage.Controls.Add(this.btnRetrieveStockInfo);
            this.stockMarketPage.Controls.Add(this.btnParseCompanyDetailsFromServer);
            this.stockMarketPage.Location = new System.Drawing.Point(4, 25);
            this.stockMarketPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stockMarketPage.Name = "stockMarketPage";
            this.stockMarketPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stockMarketPage.Size = new System.Drawing.Size(507, 691);
            this.stockMarketPage.TabIndex = 1;
            this.stockMarketPage.Text = "stockMarketPage";
            this.stockMarketPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxForCheckingParameters
            // 
            this.groupBoxForCheckingParameters.Controls.Add(this.checkBoxKeepPreferStockID);
            this.groupBoxForCheckingParameters.Location = new System.Drawing.Point(8, 8);
            this.groupBoxForCheckingParameters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForCheckingParameters.Name = "groupBoxForCheckingParameters";
            this.groupBoxForCheckingParameters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForCheckingParameters.Size = new System.Drawing.Size(488, 61);
            this.groupBoxForCheckingParameters.TabIndex = 43;
            this.groupBoxForCheckingParameters.TabStop = false;
            this.groupBoxForCheckingParameters.Text = "CheckingParameters";
            // 
            // checkBoxKeepPreferStockID
            // 
            this.checkBoxKeepPreferStockID.AutoSize = true;
            this.checkBoxKeepPreferStockID.Location = new System.Drawing.Point(9, 25);
            this.checkBoxKeepPreferStockID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxKeepPreferStockID.Name = "checkBoxKeepPreferStockID";
            this.checkBoxKeepPreferStockID.Size = new System.Drawing.Size(189, 19);
            this.checkBoxKeepPreferStockID.TabIndex = 42;
            this.checkBoxKeepPreferStockID.Text = "Keep Prefer Stock ID";
            this.checkBoxKeepPreferStockID.UseVisualStyleBackColor = true;
            // 
            // btnClearPreferStockList
            // 
            this.btnClearPreferStockList.Location = new System.Drawing.Point(133, 625);
            this.btnClearPreferStockList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearPreferStockList.Name = "btnClearPreferStockList";
            this.btnClearPreferStockList.Size = new System.Drawing.Size(236, 38);
            this.btnClearPreferStockList.TabIndex = 41;
            this.btnClearPreferStockList.Text = "Clear Prefer Stock IDs";
            this.btnClearPreferStockList.UseVisualStyleBackColor = true;
            this.btnClearPreferStockList.Click += new System.EventHandler(this.btnClearPreferStockList_Click);
            // 
            // groupBoxForStockInfo
            // 
            this.groupBoxForStockInfo.Controls.Add(this.lblFifthYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.txtFifthYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.lblFourthYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.txtFourthYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.lblThirdYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.txtThirdYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.lblSecondYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.txtSecondYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.lblFirstYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.txtFirstYearProfitSharing);
            this.groupBoxForStockInfo.Controls.Add(this.comboBoxStockIDList);
            this.groupBoxForStockInfo.Controls.Add(this.lblPERatio);
            this.groupBoxForStockInfo.Controls.Add(this.txtPERatio);
            this.groupBoxForStockInfo.Controls.Add(this.lblDateOfInfo);
            this.groupBoxForStockInfo.Controls.Add(this.txtDateOfInfo);
            this.groupBoxForStockInfo.Controls.Add(this.lblSelectedStockID);
            this.groupBoxForStockInfo.Controls.Add(this.lblCompanyProfitPerShare);
            this.groupBoxForStockInfo.Controls.Add(this.lblCompanyName);
            this.groupBoxForStockInfo.Controls.Add(this.txtCompanyProfitPerShare);
            this.groupBoxForStockInfo.Controls.Add(this.txtLastTradingPrice);
            this.groupBoxForStockInfo.Controls.Add(this.lblLastTradingPrice);
            this.groupBoxForStockInfo.Controls.Add(this.txtCompanyName);
            this.groupBoxForStockInfo.Location = new System.Drawing.Point(8, 76);
            this.groupBoxForStockInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForStockInfo.Name = "groupBoxForStockInfo";
            this.groupBoxForStockInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForStockInfo.Size = new System.Drawing.Size(488, 469);
            this.groupBoxForStockInfo.TabIndex = 40;
            this.groupBoxForStockInfo.TabStop = false;
            this.groupBoxForStockInfo.Text = "StockInfo";
            // 
            // comboBoxStockIDList
            // 
            this.comboBoxStockIDList.FormattingEnabled = true;
            this.comboBoxStockIDList.Location = new System.Drawing.Point(219, 25);
            this.comboBoxStockIDList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStockIDList.Name = "comboBoxStockIDList";
            this.comboBoxStockIDList.Size = new System.Drawing.Size(244, 23);
            this.comboBoxStockIDList.TabIndex = 44;
            this.comboBoxStockIDList.SelectedIndexChanged += new System.EventHandler(this.comboBoxStockIDList_SelectedIndexChanged);
            // 
            // lblPERatio
            // 
            this.lblPERatio.AutoSize = true;
            this.lblPERatio.Location = new System.Drawing.Point(7, 227);
            this.lblPERatio.Name = "lblPERatio";
            this.lblPERatio.Size = new System.Drawing.Size(79, 15);
            this.lblPERatio.TabIndex = 42;
            this.lblPERatio.Text = "PE Ratio:";
            // 
            // txtPERatio
            // 
            this.txtPERatio.Enabled = false;
            this.txtPERatio.Location = new System.Drawing.Point(219, 224);
            this.txtPERatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPERatio.Name = "txtPERatio";
            this.txtPERatio.Size = new System.Drawing.Size(244, 25);
            this.txtPERatio.TabIndex = 43;
            // 
            // lblDateOfInfo
            // 
            this.lblDateOfInfo.AutoSize = true;
            this.lblDateOfInfo.Location = new System.Drawing.Point(7, 102);
            this.lblDateOfInfo.Name = "lblDateOfInfo";
            this.lblDateOfInfo.Size = new System.Drawing.Size(111, 15);
            this.lblDateOfInfo.TabIndex = 41;
            this.lblDateOfInfo.Text = "Date of Info:";
            // 
            // txtDateOfInfo
            // 
            this.txtDateOfInfo.Enabled = false;
            this.txtDateOfInfo.Location = new System.Drawing.Point(219, 99);
            this.txtDateOfInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateOfInfo.Name = "txtDateOfInfo";
            this.txtDateOfInfo.Size = new System.Drawing.Size(244, 25);
            this.txtDateOfInfo.TabIndex = 40;
            // 
            // lblSelectedStockID
            // 
            this.lblSelectedStockID.AutoSize = true;
            this.lblSelectedStockID.Location = new System.Drawing.Point(7, 29);
            this.lblSelectedStockID.Name = "lblSelectedStockID";
            this.lblSelectedStockID.Size = new System.Drawing.Size(79, 15);
            this.lblSelectedStockID.TabIndex = 32;
            this.lblSelectedStockID.Text = "Stock ID:";
            // 
            // lblCompanyProfitPerShare
            // 
            this.lblCompanyProfitPerShare.AutoSize = true;
            this.lblCompanyProfitPerShare.Location = new System.Drawing.Point(7, 182);
            this.lblCompanyProfitPerShare.Name = "lblCompanyProfitPerShare";
            this.lblCompanyProfitPerShare.Size = new System.Drawing.Size(207, 15);
            this.lblCompanyProfitPerShare.TabIndex = 38;
            this.lblCompanyProfitPerShare.Text = "Company Profit Per Share:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(7, 65);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(111, 15);
            this.lblCompanyName.TabIndex = 37;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtCompanyProfitPerShare
            // 
            this.txtCompanyProfitPerShare.Enabled = false;
            this.txtCompanyProfitPerShare.Location = new System.Drawing.Point(219, 179);
            this.txtCompanyProfitPerShare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyProfitPerShare.Name = "txtCompanyProfitPerShare";
            this.txtCompanyProfitPerShare.Size = new System.Drawing.Size(244, 25);
            this.txtCompanyProfitPerShare.TabIndex = 39;
            // 
            // txtLastTradingPrice
            // 
            this.txtLastTradingPrice.Enabled = false;
            this.txtLastTradingPrice.Location = new System.Drawing.Point(219, 139);
            this.txtLastTradingPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastTradingPrice.Name = "txtLastTradingPrice";
            this.txtLastTradingPrice.Size = new System.Drawing.Size(244, 25);
            this.txtLastTradingPrice.TabIndex = 36;
            // 
            // lblLastTradingPrice
            // 
            this.lblLastTradingPrice.AutoSize = true;
            this.lblLastTradingPrice.Location = new System.Drawing.Point(7, 142);
            this.lblLastTradingPrice.Name = "lblLastTradingPrice";
            this.lblLastTradingPrice.Size = new System.Drawing.Size(159, 15);
            this.lblLastTradingPrice.TabIndex = 35;
            this.lblLastTradingPrice.Text = "Last Trading Price:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(219, 63);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(244, 25);
            this.txtCompanyName.TabIndex = 34;
            // 
            // btnRetrieveStockInfo
            // 
            this.btnRetrieveStockInfo.Location = new System.Drawing.Point(8, 567);
            this.btnRetrieveStockInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetrieveStockInfo.Name = "btnRetrieveStockInfo";
            this.btnRetrieveStockInfo.Size = new System.Drawing.Size(236, 40);
            this.btnRetrieveStockInfo.TabIndex = 31;
            this.btnRetrieveStockInfo.Text = "Retrieve Stock Info";
            this.btnRetrieveStockInfo.UseVisualStyleBackColor = true;
            this.btnRetrieveStockInfo.Click += new System.EventHandler(this.btnRetrieveStockInfo_Click);
            // 
            // lblFirstYearProfitSharing
            // 
            this.lblFirstYearProfitSharing.AutoSize = true;
            this.lblFirstYearProfitSharing.Location = new System.Drawing.Point(7, 271);
            this.lblFirstYearProfitSharing.Name = "lblFirstYearProfitSharing";
            this.lblFirstYearProfitSharing.Size = new System.Drawing.Size(199, 15);
            this.lblFirstYearProfitSharing.TabIndex = 45;
            this.lblFirstYearProfitSharing.Text = "1st Year Profit Sharing:";
            // 
            // txtFirstYearProfitSharing
            // 
            this.txtFirstYearProfitSharing.Enabled = false;
            this.txtFirstYearProfitSharing.Location = new System.Drawing.Point(219, 268);
            this.txtFirstYearProfitSharing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstYearProfitSharing.Name = "txtFirstYearProfitSharing";
            this.txtFirstYearProfitSharing.Size = new System.Drawing.Size(244, 25);
            this.txtFirstYearProfitSharing.TabIndex = 46;
            // 
            // lblSecondYearProfitSharing
            // 
            this.lblSecondYearProfitSharing.AutoSize = true;
            this.lblSecondYearProfitSharing.Location = new System.Drawing.Point(7, 313);
            this.lblSecondYearProfitSharing.Name = "lblSecondYearProfitSharing";
            this.lblSecondYearProfitSharing.Size = new System.Drawing.Size(199, 15);
            this.lblSecondYearProfitSharing.TabIndex = 47;
            this.lblSecondYearProfitSharing.Text = "2nd Year Profit Sharing:";
            // 
            // txtSecondYearProfitSharing
            // 
            this.txtSecondYearProfitSharing.Enabled = false;
            this.txtSecondYearProfitSharing.Location = new System.Drawing.Point(219, 310);
            this.txtSecondYearProfitSharing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSecondYearProfitSharing.Name = "txtSecondYearProfitSharing";
            this.txtSecondYearProfitSharing.Size = new System.Drawing.Size(244, 25);
            this.txtSecondYearProfitSharing.TabIndex = 48;
            // 
            // lblThirdYearProfitSharing
            // 
            this.lblThirdYearProfitSharing.AutoSize = true;
            this.lblThirdYearProfitSharing.Location = new System.Drawing.Point(7, 354);
            this.lblThirdYearProfitSharing.Name = "lblThirdYearProfitSharing";
            this.lblThirdYearProfitSharing.Size = new System.Drawing.Size(199, 15);
            this.lblThirdYearProfitSharing.TabIndex = 49;
            this.lblThirdYearProfitSharing.Text = "3rd Year Profit Sharing:";
            // 
            // txtThirdYearProfitSharing
            // 
            this.txtThirdYearProfitSharing.Enabled = false;
            this.txtThirdYearProfitSharing.Location = new System.Drawing.Point(219, 351);
            this.txtThirdYearProfitSharing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThirdYearProfitSharing.Name = "txtThirdYearProfitSharing";
            this.txtThirdYearProfitSharing.Size = new System.Drawing.Size(244, 25);
            this.txtThirdYearProfitSharing.TabIndex = 50;
            // 
            // lblFourthYearProfitSharing
            // 
            this.lblFourthYearProfitSharing.AutoSize = true;
            this.lblFourthYearProfitSharing.Location = new System.Drawing.Point(7, 396);
            this.lblFourthYearProfitSharing.Name = "lblFourthYearProfitSharing";
            this.lblFourthYearProfitSharing.Size = new System.Drawing.Size(199, 15);
            this.lblFourthYearProfitSharing.TabIndex = 51;
            this.lblFourthYearProfitSharing.Text = "4th Year Profit Sharing:";
            // 
            // txtFourthYearProfitSharing
            // 
            this.txtFourthYearProfitSharing.Enabled = false;
            this.txtFourthYearProfitSharing.Location = new System.Drawing.Point(219, 393);
            this.txtFourthYearProfitSharing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFourthYearProfitSharing.Name = "txtFourthYearProfitSharing";
            this.txtFourthYearProfitSharing.Size = new System.Drawing.Size(244, 25);
            this.txtFourthYearProfitSharing.TabIndex = 52;
            // 
            // lblFifthYearProfitSharing
            // 
            this.lblFifthYearProfitSharing.AutoSize = true;
            this.lblFifthYearProfitSharing.Location = new System.Drawing.Point(7, 434);
            this.lblFifthYearProfitSharing.Name = "lblFifthYearProfitSharing";
            this.lblFifthYearProfitSharing.Size = new System.Drawing.Size(199, 15);
            this.lblFifthYearProfitSharing.TabIndex = 53;
            this.lblFifthYearProfitSharing.Text = "5th Year Profit Sharing:";
            // 
            // txtFifthYearProfitSharing
            // 
            this.txtFifthYearProfitSharing.Enabled = false;
            this.txtFifthYearProfitSharing.Location = new System.Drawing.Point(219, 431);
            this.txtFifthYearProfitSharing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFifthYearProfitSharing.Name = "txtFifthYearProfitSharing";
            this.txtFifthYearProfitSharing.Size = new System.Drawing.Size(244, 25);
            this.txtFifthYearProfitSharing.TabIndex = 54;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 749);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "StockValueCalculator";
            this.tabControl1.ResumeLayout(false);
            this.calculationPage.ResumeLayout(false);
            this.groupBoxForManualInputParams.ResumeLayout(false);
            this.groupBoxForManualInputParams.PerformLayout();
            this.groupBoxForServerParseParams.ResumeLayout(false);
            this.groupBoxForServerParseParams.PerformLayout();
            this.stockMarketPage.ResumeLayout(false);
            this.groupBoxForCheckingParameters.ResumeLayout(false);
            this.groupBoxForCheckingParameters.PerformLayout();
            this.groupBoxForStockInfo.ResumeLayout(false);
            this.groupBoxForStockInfo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblStockHeldDuration;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnParseCompanyDetails;
        private System.Windows.Forms.OpenFileDialog openFileDialogForCompanyDetails;
        private System.Windows.Forms.Button btnParseCompanyDetailsFromServer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calculationPage;
        private System.Windows.Forms.TabPage stockMarketPage;
        private System.Windows.Forms.Button btnRetrieveStockInfo;
        private System.Windows.Forms.Label lblSelectedStockID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtLastTradingPrice;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyProfitPerShare;
        private System.Windows.Forms.TextBox txtCompanyProfitPerShare;
        private System.Windows.Forms.Label lblLastTradingPrice;
        private System.Windows.Forms.GroupBox groupBoxForStockInfo;
        private System.Windows.Forms.Label lblDateOfInfo;
        private System.Windows.Forms.TextBox txtDateOfInfo;
        private System.Windows.Forms.Label lblPERatio;
        private System.Windows.Forms.TextBox txtPERatio;
        private System.Windows.Forms.GroupBox groupBoxForManualInputParams;
        private System.Windows.Forms.GroupBox groupBoxForServerParseParams;
        private System.Windows.Forms.Button btnClearPreferStockList;
        private System.Windows.Forms.ComboBox comboBoxStockIDList;
        private System.Windows.Forms.CheckBox checkBoxKeepPreferStockID;
        private System.Windows.Forms.GroupBox groupBoxForCheckingParameters;
        private System.Windows.Forms.Label lblFifthYearProfitSharing;
        private System.Windows.Forms.TextBox txtFifthYearProfitSharing;
        private System.Windows.Forms.Label lblFourthYearProfitSharing;
        private System.Windows.Forms.TextBox txtFourthYearProfitSharing;
        private System.Windows.Forms.Label lblThirdYearProfitSharing;
        private System.Windows.Forms.TextBox txtThirdYearProfitSharing;
        private System.Windows.Forms.Label lblSecondYearProfitSharing;
        private System.Windows.Forms.TextBox txtSecondYearProfitSharing;
        private System.Windows.Forms.Label lblFirstYearProfitSharing;
        private System.Windows.Forms.TextBox txtFirstYearProfitSharing;
    }
}

