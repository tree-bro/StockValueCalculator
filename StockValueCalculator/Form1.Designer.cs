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
            this.groupBoxForStockInfo = new System.Windows.Forms.GroupBox();
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
            this.btnClearPreferStockList = new System.Windows.Forms.Button();
            this.comboBoxStockIDList = new System.Windows.Forms.ComboBox();
            this.checkBoxKeepPreferStockID = new System.Windows.Forms.CheckBox();
            this.groupBoxForCheckingParameters = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.calculationPage.SuspendLayout();
            this.groupBoxForManualInputParams.SuspendLayout();
            this.groupBoxForServerParseParams.SuspendLayout();
            this.stockMarketPage.SuspendLayout();
            this.groupBoxForStockInfo.SuspendLayout();
            this.groupBoxForCheckingParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarketPrice
            // 
            this.lblMarketPrice.AutoSize = true;
            this.lblMarketPrice.Location = new System.Drawing.Point(5, 25);
            this.lblMarketPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarketPrice.Name = "lblMarketPrice";
            this.lblMarketPrice.Size = new System.Drawing.Size(89, 12);
            this.lblMarketPrice.TabIndex = 0;
            this.lblMarketPrice.Text = "Market Price: ";
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.Location = new System.Drawing.Point(182, 23);
            this.txtMarketPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.Size = new System.Drawing.Size(160, 21);
            this.txtMarketPrice.TabIndex = 1;
            this.txtMarketPrice.Text = "10.0";
            // 
            // txtTradeTaxRate
            // 
            this.txtTradeTaxRate.Location = new System.Drawing.Point(182, 24);
            this.txtTradeTaxRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtTradeTaxRate.Name = "txtTradeTaxRate";
            this.txtTradeTaxRate.Size = new System.Drawing.Size(160, 21);
            this.txtTradeTaxRate.TabIndex = 3;
            this.txtTradeTaxRate.Text = "1";
            // 
            // txtProfitPerShare
            // 
            this.txtProfitPerShare.Location = new System.Drawing.Point(182, 54);
            this.txtProfitPerShare.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfitPerShare.Name = "txtProfitPerShare";
            this.txtProfitPerShare.Size = new System.Drawing.Size(160, 21);
            this.txtProfitPerShare.TabIndex = 5;
            this.txtProfitPerShare.Text = "1.0";
            // 
            // lblProfitPerShare
            // 
            this.lblProfitPerShare.AutoSize = true;
            this.lblProfitPerShare.Location = new System.Drawing.Point(5, 56);
            this.lblProfitPerShare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfitPerShare.Name = "lblProfitPerShare";
            this.lblProfitPerShare.Size = new System.Drawing.Size(113, 12);
            this.lblProfitPerShare.TabIndex = 4;
            this.lblProfitPerShare.Text = "Profit Per Share: ";
            // 
            // txtCompanyDuration
            // 
            this.txtCompanyDuration.Location = new System.Drawing.Point(182, 84);
            this.txtCompanyDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyDuration.Name = "txtCompanyDuration";
            this.txtCompanyDuration.Size = new System.Drawing.Size(160, 21);
            this.txtCompanyDuration.TabIndex = 7;
            this.txtCompanyDuration.Text = "50";
            // 
            // lblCompanyDuration
            // 
            this.lblCompanyDuration.AutoSize = true;
            this.lblCompanyDuration.Location = new System.Drawing.Point(5, 87);
            this.lblCompanyDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyDuration.Name = "lblCompanyDuration";
            this.lblCompanyDuration.Size = new System.Drawing.Size(155, 12);
            this.lblCompanyDuration.TabIndex = 6;
            this.lblCompanyDuration.Text = "Company Duration (year): ";
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.Location = new System.Drawing.Point(182, 114);
            this.txtDiscountRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Size = new System.Drawing.Size(160, 21);
            this.txtDiscountRate.TabIndex = 9;
            this.txtDiscountRate.Text = "5.0";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Location = new System.Drawing.Point(5, 116);
            this.lblDiscountRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(107, 12);
            this.lblDiscountRate.TabIndex = 8;
            this.lblDiscountRate.Text = "Discount Rate %: ";
            // 
            // txtNormalGrowthRate
            // 
            this.txtNormalGrowthRate.Location = new System.Drawing.Point(182, 142);
            this.txtNormalGrowthRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtNormalGrowthRate.Name = "txtNormalGrowthRate";
            this.txtNormalGrowthRate.Size = new System.Drawing.Size(160, 21);
            this.txtNormalGrowthRate.TabIndex = 11;
            this.txtNormalGrowthRate.Text = "1.0";
            // 
            // lblNormalGrowthRate
            // 
            this.lblNormalGrowthRate.AutoSize = true;
            this.lblNormalGrowthRate.Location = new System.Drawing.Point(5, 144);
            this.lblNormalGrowthRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNormalGrowthRate.Name = "lblNormalGrowthRate";
            this.lblNormalGrowthRate.Size = new System.Drawing.Size(137, 12);
            this.lblNormalGrowthRate.TabIndex = 10;
            this.lblNormalGrowthRate.Text = "Normal Growth Rate %: ";
            // 
            // txtHighSpeedGrowthRate
            // 
            this.txtHighSpeedGrowthRate.Location = new System.Drawing.Point(182, 171);
            this.txtHighSpeedGrowthRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtHighSpeedGrowthRate.Name = "txtHighSpeedGrowthRate";
            this.txtHighSpeedGrowthRate.Size = new System.Drawing.Size(160, 21);
            this.txtHighSpeedGrowthRate.TabIndex = 13;
            this.txtHighSpeedGrowthRate.Text = "5.0";
            // 
            // lblHighSpeedGrowthRate
            // 
            this.lblHighSpeedGrowthRate.AutoSize = true;
            this.lblHighSpeedGrowthRate.Location = new System.Drawing.Point(5, 174);
            this.lblHighSpeedGrowthRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighSpeedGrowthRate.Name = "lblHighSpeedGrowthRate";
            this.lblHighSpeedGrowthRate.Size = new System.Drawing.Size(161, 12);
            this.lblHighSpeedGrowthRate.TabIndex = 12;
            this.lblHighSpeedGrowthRate.Text = "High Speed Growth Rate %: ";
            // 
            // txtHighSpeedGrowthDuration
            // 
            this.txtHighSpeedGrowthDuration.Location = new System.Drawing.Point(182, 203);
            this.txtHighSpeedGrowthDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtHighSpeedGrowthDuration.Name = "txtHighSpeedGrowthDuration";
            this.txtHighSpeedGrowthDuration.Size = new System.Drawing.Size(160, 21);
            this.txtHighSpeedGrowthDuration.TabIndex = 15;
            this.txtHighSpeedGrowthDuration.Text = "3";
            // 
            // lblHighSpeedGrowthDuration
            // 
            this.lblHighSpeedGrowthDuration.AutoSize = true;
            this.lblHighSpeedGrowthDuration.Location = new System.Drawing.Point(5, 206);
            this.lblHighSpeedGrowthDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighSpeedGrowthDuration.Name = "lblHighSpeedGrowthDuration";
            this.lblHighSpeedGrowthDuration.Size = new System.Drawing.Size(173, 12);
            this.lblHighSpeedGrowthDuration.TabIndex = 14;
            this.lblHighSpeedGrowthDuration.Text = "High Speed Growth Duration: ";
            // 
            // txtProfitSharingRate
            // 
            this.txtProfitSharingRate.Location = new System.Drawing.Point(182, 53);
            this.txtProfitSharingRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfitSharingRate.Name = "txtProfitSharingRate";
            this.txtProfitSharingRate.Size = new System.Drawing.Size(160, 21);
            this.txtProfitSharingRate.TabIndex = 17;
            this.txtProfitSharingRate.Text = "20";
            // 
            // lblProfitSharingRate
            // 
            this.lblProfitSharingRate.AutoSize = true;
            this.lblProfitSharingRate.Location = new System.Drawing.Point(5, 55);
            this.lblProfitSharingRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfitSharingRate.Name = "lblProfitSharingRate";
            this.lblProfitSharingRate.Size = new System.Drawing.Size(143, 12);
            this.lblProfitSharingRate.TabIndex = 16;
            this.lblProfitSharingRate.Text = "Profit Sharing Rate %: ";
            // 
            // lblTradeTaxRate
            // 
            this.lblTradeTaxRate.AutoSize = true;
            this.lblTradeTaxRate.Location = new System.Drawing.Point(5, 26);
            this.lblTradeTaxRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTradeTaxRate.Name = "lblTradeTaxRate";
            this.lblTradeTaxRate.Size = new System.Drawing.Size(125, 12);
            this.lblTradeTaxRate.TabIndex = 18;
            this.lblTradeTaxRate.Text = "Trading Tax Rate %: ";
            // 
            // txtProfitSharingTax
            // 
            this.txtProfitSharingTax.Location = new System.Drawing.Point(182, 232);
            this.txtProfitSharingTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfitSharingTax.Name = "txtProfitSharingTax";
            this.txtProfitSharingTax.Size = new System.Drawing.Size(160, 21);
            this.txtProfitSharingTax.TabIndex = 20;
            this.txtProfitSharingTax.Text = "0.5";
            // 
            // lblProfitSharingTax
            // 
            this.lblProfitSharingTax.AutoSize = true;
            this.lblProfitSharingTax.Location = new System.Drawing.Point(5, 235);
            this.lblProfitSharingTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfitSharingTax.Name = "lblProfitSharingTax";
            this.lblProfitSharingTax.Size = new System.Drawing.Size(161, 12);
            this.lblProfitSharingTax.TabIndex = 19;
            this.lblProfitSharingTax.Text = "Profit Sharing Tax Rate %:";
            // 
            // txtDepressionFrequency
            // 
            this.txtDepressionFrequency.Location = new System.Drawing.Point(182, 262);
            this.txtDepressionFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepressionFrequency.Name = "txtDepressionFrequency";
            this.txtDepressionFrequency.Size = new System.Drawing.Size(160, 21);
            this.txtDepressionFrequency.TabIndex = 22;
            this.txtDepressionFrequency.Text = "5";
            // 
            // lblDepressionFrequency
            // 
            this.lblDepressionFrequency.AutoSize = true;
            this.lblDepressionFrequency.Location = new System.Drawing.Point(5, 264);
            this.lblDepressionFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepressionFrequency.Name = "lblDepressionFrequency";
            this.lblDepressionFrequency.Size = new System.Drawing.Size(179, 12);
            this.lblDepressionFrequency.TabIndex = 21;
            this.lblDepressionFrequency.Text = "Depression Frequency (years):";
            // 
            // txtDepressionLossRate
            // 
            this.txtDepressionLossRate.Location = new System.Drawing.Point(182, 290);
            this.txtDepressionLossRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepressionLossRate.Name = "txtDepressionLossRate";
            this.txtDepressionLossRate.Size = new System.Drawing.Size(160, 21);
            this.txtDepressionLossRate.TabIndex = 24;
            this.txtDepressionLossRate.Text = "90.0";
            // 
            // lblDepressionLossRate
            // 
            this.lblDepressionLossRate.AutoSize = true;
            this.lblDepressionLossRate.Location = new System.Drawing.Point(5, 292);
            this.lblDepressionLossRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepressionLossRate.Name = "lblDepressionLossRate";
            this.lblDepressionLossRate.Size = new System.Drawing.Size(143, 12);
            this.lblDepressionLossRate.TabIndex = 23;
            this.lblDepressionLossRate.Text = "Depression Loss Rate %:";
            // 
            // txtStockHeldDuration
            // 
            this.txtStockHeldDuration.Location = new System.Drawing.Point(182, 322);
            this.txtStockHeldDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockHeldDuration.Name = "txtStockHeldDuration";
            this.txtStockHeldDuration.Size = new System.Drawing.Size(160, 21);
            this.txtStockHeldDuration.TabIndex = 26;
            this.txtStockHeldDuration.Text = "10";
            // 
            // lblStockHeldDuration
            // 
            this.lblStockHeldDuration.AutoSize = true;
            this.lblStockHeldDuration.Location = new System.Drawing.Point(5, 324);
            this.lblStockHeldDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockHeldDuration.Name = "lblStockHeldDuration";
            this.lblStockHeldDuration.Size = new System.Drawing.Size(167, 12);
            this.lblStockHeldDuration.TabIndex = 25;
            this.lblStockHeldDuration.Text = "Stock Held Duration (year):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 506);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 34);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnParseCompanyDetails
            // 
            this.btnParseCompanyDetails.Location = new System.Drawing.Point(93, 457);
            this.btnParseCompanyDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnParseCompanyDetails.Name = "btnParseCompanyDetails";
            this.btnParseCompanyDetails.Size = new System.Drawing.Size(177, 34);
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
            this.btnParseCompanyDetailsFromServer.Location = new System.Drawing.Point(92, 391);
            this.btnParseCompanyDetailsFromServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnParseCompanyDetailsFromServer.Name = "btnParseCompanyDetailsFromServer";
            this.btnParseCompanyDetailsFromServer.Size = new System.Drawing.Size(177, 34);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 576);
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
            this.calculationPage.Location = new System.Drawing.Point(4, 22);
            this.calculationPage.Name = "calculationPage";
            this.calculationPage.Padding = new System.Windows.Forms.Padding(3);
            this.calculationPage.Size = new System.Drawing.Size(378, 550);
            this.calculationPage.TabIndex = 0;
            this.calculationPage.Text = "calculationPage";
            this.calculationPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxForManualInputParams
            // 
            this.groupBoxForManualInputParams.Controls.Add(this.lblTradeTaxRate);
            this.groupBoxForManualInputParams.Controls.Add(this.txtHighSpeedGrowthDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.lblProfitSharingRate);
            this.groupBoxForManualInputParams.Controls.Add(this.lblHighSpeedGrowthDuration);
            this.groupBoxForManualInputParams.Controls.Add(this.txtTradeTaxRate);
            this.groupBoxForManualInputParams.Controls.Add(this.txtProfitSharingRate);
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
            this.groupBoxForManualInputParams.Location = new System.Drawing.Point(6, 98);
            this.groupBoxForManualInputParams.Name = "groupBoxForManualInputParams";
            this.groupBoxForManualInputParams.Size = new System.Drawing.Size(357, 354);
            this.groupBoxForManualInputParams.TabIndex = 30;
            this.groupBoxForManualInputParams.TabStop = false;
            this.groupBoxForManualInputParams.Text = "Manual Input Params";
            // 
            // groupBoxForServerParseParams
            // 
            this.groupBoxForServerParseParams.Controls.Add(this.lblMarketPrice);
            this.groupBoxForServerParseParams.Controls.Add(this.txtProfitPerShare);
            this.groupBoxForServerParseParams.Controls.Add(this.txtMarketPrice);
            this.groupBoxForServerParseParams.Controls.Add(this.lblProfitPerShare);
            this.groupBoxForServerParseParams.Location = new System.Drawing.Point(6, 6);
            this.groupBoxForServerParseParams.Name = "groupBoxForServerParseParams";
            this.groupBoxForServerParseParams.Size = new System.Drawing.Size(357, 86);
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
            this.stockMarketPage.Location = new System.Drawing.Point(4, 22);
            this.stockMarketPage.Name = "stockMarketPage";
            this.stockMarketPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockMarketPage.Size = new System.Drawing.Size(378, 550);
            this.stockMarketPage.TabIndex = 1;
            this.stockMarketPage.Text = "stockMarketPage";
            this.stockMarketPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxForStockInfo
            // 
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
            this.groupBoxForStockInfo.Location = new System.Drawing.Point(6, 61);
            this.groupBoxForStockInfo.Name = "groupBoxForStockInfo";
            this.groupBoxForStockInfo.Size = new System.Drawing.Size(366, 230);
            this.groupBoxForStockInfo.TabIndex = 40;
            this.groupBoxForStockInfo.TabStop = false;
            this.groupBoxForStockInfo.Text = "StockInfo";
            // 
            // lblPERatio
            // 
            this.lblPERatio.AutoSize = true;
            this.lblPERatio.Location = new System.Drawing.Point(5, 187);
            this.lblPERatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPERatio.Name = "lblPERatio";
            this.lblPERatio.Size = new System.Drawing.Size(59, 12);
            this.lblPERatio.TabIndex = 42;
            this.lblPERatio.Text = "PE Ratio:";
            // 
            // txtPERatio
            // 
            this.txtPERatio.Enabled = false;
            this.txtPERatio.Location = new System.Drawing.Point(164, 185);
            this.txtPERatio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPERatio.Name = "txtPERatio";
            this.txtPERatio.Size = new System.Drawing.Size(184, 21);
            this.txtPERatio.TabIndex = 43;
            // 
            // lblDateOfInfo
            // 
            this.lblDateOfInfo.AutoSize = true;
            this.lblDateOfInfo.Location = new System.Drawing.Point(5, 87);
            this.lblDateOfInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfInfo.Name = "lblDateOfInfo";
            this.lblDateOfInfo.Size = new System.Drawing.Size(83, 12);
            this.lblDateOfInfo.TabIndex = 41;
            this.lblDateOfInfo.Text = "Date of Info:";
            // 
            // txtDateOfInfo
            // 
            this.txtDateOfInfo.Enabled = false;
            this.txtDateOfInfo.Location = new System.Drawing.Point(164, 85);
            this.txtDateOfInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateOfInfo.Name = "txtDateOfInfo";
            this.txtDateOfInfo.Size = new System.Drawing.Size(184, 21);
            this.txtDateOfInfo.TabIndex = 40;
            // 
            // lblSelectedStockID
            // 
            this.lblSelectedStockID.AutoSize = true;
            this.lblSelectedStockID.Location = new System.Drawing.Point(5, 29);
            this.lblSelectedStockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedStockID.Name = "lblSelectedStockID";
            this.lblSelectedStockID.Size = new System.Drawing.Size(59, 12);
            this.lblSelectedStockID.TabIndex = 32;
            this.lblSelectedStockID.Text = "Stock ID:";
            // 
            // lblCompanyProfitPerShare
            // 
            this.lblCompanyProfitPerShare.AutoSize = true;
            this.lblCompanyProfitPerShare.Location = new System.Drawing.Point(5, 151);
            this.lblCompanyProfitPerShare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyProfitPerShare.Name = "lblCompanyProfitPerShare";
            this.lblCompanyProfitPerShare.Size = new System.Drawing.Size(155, 12);
            this.lblCompanyProfitPerShare.TabIndex = 38;
            this.lblCompanyProfitPerShare.Text = "Company Profit Per Share:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(5, 58);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(83, 12);
            this.lblCompanyName.TabIndex = 37;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtCompanyProfitPerShare
            // 
            this.txtCompanyProfitPerShare.Enabled = false;
            this.txtCompanyProfitPerShare.Location = new System.Drawing.Point(164, 149);
            this.txtCompanyProfitPerShare.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyProfitPerShare.Name = "txtCompanyProfitPerShare";
            this.txtCompanyProfitPerShare.Size = new System.Drawing.Size(184, 21);
            this.txtCompanyProfitPerShare.TabIndex = 39;
            // 
            // txtLastTradingPrice
            // 
            this.txtLastTradingPrice.Enabled = false;
            this.txtLastTradingPrice.Location = new System.Drawing.Point(164, 117);
            this.txtLastTradingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastTradingPrice.Name = "txtLastTradingPrice";
            this.txtLastTradingPrice.Size = new System.Drawing.Size(184, 21);
            this.txtLastTradingPrice.TabIndex = 36;
            // 
            // lblLastTradingPrice
            // 
            this.lblLastTradingPrice.AutoSize = true;
            this.lblLastTradingPrice.Location = new System.Drawing.Point(5, 119);
            this.lblLastTradingPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastTradingPrice.Name = "lblLastTradingPrice";
            this.lblLastTradingPrice.Size = new System.Drawing.Size(119, 12);
            this.lblLastTradingPrice.TabIndex = 35;
            this.lblLastTradingPrice.Text = "Last Trading Price:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(164, 56);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(184, 21);
            this.txtCompanyName.TabIndex = 34;
            // 
            // btnRetrieveStockInfo
            // 
            this.btnRetrieveStockInfo.Location = new System.Drawing.Point(92, 343);
            this.btnRetrieveStockInfo.Name = "btnRetrieveStockInfo";
            this.btnRetrieveStockInfo.Size = new System.Drawing.Size(177, 32);
            this.btnRetrieveStockInfo.TabIndex = 31;
            this.btnRetrieveStockInfo.Text = "Retrieve Stock Info";
            this.btnRetrieveStockInfo.UseVisualStyleBackColor = true;
            this.btnRetrieveStockInfo.Click += new System.EventHandler(this.btnRetrieveStockInfo_Click);
            // 
            // btnClearPreferStockList
            // 
            this.btnClearPreferStockList.Location = new System.Drawing.Point(92, 442);
            this.btnClearPreferStockList.Name = "btnClearPreferStockList";
            this.btnClearPreferStockList.Size = new System.Drawing.Size(177, 30);
            this.btnClearPreferStockList.TabIndex = 41;
            this.btnClearPreferStockList.Text = "Clear Prefer Stock IDs";
            this.btnClearPreferStockList.UseVisualStyleBackColor = true;
            this.btnClearPreferStockList.Click += new System.EventHandler(this.btnClearPreferStockList_Click);
            // 
            // comboBoxStockIDList
            // 
            this.comboBoxStockIDList.FormattingEnabled = true;
            this.comboBoxStockIDList.Location = new System.Drawing.Point(164, 26);
            this.comboBoxStockIDList.Name = "comboBoxStockIDList";
            this.comboBoxStockIDList.Size = new System.Drawing.Size(184, 20);
            this.comboBoxStockIDList.TabIndex = 44;
            this.comboBoxStockIDList.SelectedIndexChanged += new System.EventHandler(this.comboBoxStockIDList_SelectedIndexChanged);
            // 
            // checkBoxKeepPreferStockID
            // 
            this.checkBoxKeepPreferStockID.AutoSize = true;
            this.checkBoxKeepPreferStockID.Location = new System.Drawing.Point(7, 20);
            this.checkBoxKeepPreferStockID.Name = "checkBoxKeepPreferStockID";
            this.checkBoxKeepPreferStockID.Size = new System.Drawing.Size(144, 16);
            this.checkBoxKeepPreferStockID.TabIndex = 42;
            this.checkBoxKeepPreferStockID.Text = "Keep Prefer Stock ID";
            this.checkBoxKeepPreferStockID.UseVisualStyleBackColor = true;
            // 
            // groupBoxForCheckingParameters
            // 
            this.groupBoxForCheckingParameters.Controls.Add(this.checkBoxKeepPreferStockID);
            this.groupBoxForCheckingParameters.Location = new System.Drawing.Point(6, 6);
            this.groupBoxForCheckingParameters.Name = "groupBoxForCheckingParameters";
            this.groupBoxForCheckingParameters.Size = new System.Drawing.Size(366, 49);
            this.groupBoxForCheckingParameters.TabIndex = 43;
            this.groupBoxForCheckingParameters.TabStop = false;
            this.groupBoxForCheckingParameters.Text = "CheckingParameters";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 599);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "StockValueCalculator";
            this.tabControl1.ResumeLayout(false);
            this.calculationPage.ResumeLayout(false);
            this.groupBoxForManualInputParams.ResumeLayout(false);
            this.groupBoxForManualInputParams.PerformLayout();
            this.groupBoxForServerParseParams.ResumeLayout(false);
            this.groupBoxForServerParseParams.PerformLayout();
            this.stockMarketPage.ResumeLayout(false);
            this.groupBoxForStockInfo.ResumeLayout(false);
            this.groupBoxForStockInfo.PerformLayout();
            this.groupBoxForCheckingParameters.ResumeLayout(false);
            this.groupBoxForCheckingParameters.PerformLayout();
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
    }
}

