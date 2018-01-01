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
            this.checkBoxUsePreviousProfit = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepPreferStockID = new System.Windows.Forms.CheckBox();
            this.btnClearPreferStockList = new System.Windows.Forms.Button();
            this.groupBoxForStockInfo = new System.Windows.Forms.GroupBox();
            this.lblFifthYearProfitSharing = new System.Windows.Forms.Label();
            this.txtFifthYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblFourthYearProfitSharing = new System.Windows.Forms.Label();
            this.txtFourthYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblThirdYearProfitSharing = new System.Windows.Forms.Label();
            this.txtThirdYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblSecondYearProfitSharing = new System.Windows.Forms.Label();
            this.txtSecondYearProfitSharing = new System.Windows.Forms.TextBox();
            this.lblFirstYearProfitSharing = new System.Windows.Forms.Label();
            this.txtFirstYearProfitSharing = new System.Windows.Forms.TextBox();
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
            this.lblMarketPrice.Location = new System.Drawing.Point(5, 25);
            this.lblMarketPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarketPrice.Name = "lblMarketPrice";
            this.lblMarketPrice.Size = new System.Drawing.Size(89, 12);
            this.lblMarketPrice.TabIndex = 0;
            this.lblMarketPrice.Text = "Market Price: ";
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.BackColor = System.Drawing.Color.Wheat;
            this.txtMarketPrice.Location = new System.Drawing.Point(224, 22);
            this.txtMarketPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.Size = new System.Drawing.Size(160, 21);
            this.txtMarketPrice.TabIndex = 1;
            this.txtMarketPrice.Text = "10.0";
            // 
            // txtTradeTaxRate
            // 
            this.txtTradeTaxRate.BackColor = System.Drawing.Color.Wheat;
            this.txtTradeTaxRate.Location = new System.Drawing.Point(224, 23);
            this.txtTradeTaxRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtTradeTaxRate.Name = "txtTradeTaxRate";
            this.txtTradeTaxRate.Size = new System.Drawing.Size(160, 21);
            this.txtTradeTaxRate.TabIndex = 3;
            this.txtTradeTaxRate.Text = "1";
            // 
            // txtProfitPerShare
            // 
            this.txtProfitPerShare.BackColor = System.Drawing.Color.Wheat;
            this.txtProfitPerShare.Location = new System.Drawing.Point(224, 53);
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
            this.txtCompanyDuration.BackColor = System.Drawing.Color.Wheat;
            this.txtCompanyDuration.Location = new System.Drawing.Point(224, 56);
            this.txtCompanyDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyDuration.Name = "txtCompanyDuration";
            this.txtCompanyDuration.Size = new System.Drawing.Size(160, 21);
            this.txtCompanyDuration.TabIndex = 7;
            this.txtCompanyDuration.Text = "50";
            // 
            // lblCompanyDuration
            // 
            this.lblCompanyDuration.AutoSize = true;
            this.lblCompanyDuration.Location = new System.Drawing.Point(5, 62);
            this.lblCompanyDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyDuration.Name = "lblCompanyDuration";
            this.lblCompanyDuration.Size = new System.Drawing.Size(155, 12);
            this.lblCompanyDuration.TabIndex = 6;
            this.lblCompanyDuration.Text = "Company Duration (year): ";
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.BackColor = System.Drawing.Color.Wheat;
            this.txtDiscountRate.Location = new System.Drawing.Point(224, 86);
            this.txtDiscountRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Size = new System.Drawing.Size(160, 21);
            this.txtDiscountRate.TabIndex = 9;
            this.txtDiscountRate.Text = "5.0";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Location = new System.Drawing.Point(5, 90);
            this.lblDiscountRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(107, 12);
            this.lblDiscountRate.TabIndex = 8;
            this.lblDiscountRate.Text = "Discount Rate %: ";
            // 
            // txtNormalGrowthRate
            // 
            this.txtNormalGrowthRate.BackColor = System.Drawing.Color.Wheat;
            this.txtNormalGrowthRate.Location = new System.Drawing.Point(224, 115);
            this.txtNormalGrowthRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtNormalGrowthRate.Name = "txtNormalGrowthRate";
            this.txtNormalGrowthRate.Size = new System.Drawing.Size(160, 21);
            this.txtNormalGrowthRate.TabIndex = 11;
            this.txtNormalGrowthRate.Text = "1.0";
            // 
            // lblNormalGrowthRate
            // 
            this.lblNormalGrowthRate.AutoSize = true;
            this.lblNormalGrowthRate.Location = new System.Drawing.Point(5, 118);
            this.lblNormalGrowthRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNormalGrowthRate.Name = "lblNormalGrowthRate";
            this.lblNormalGrowthRate.Size = new System.Drawing.Size(137, 12);
            this.lblNormalGrowthRate.TabIndex = 10;
            this.lblNormalGrowthRate.Text = "Normal Growth Rate %: ";
            // 
            // txtHighSpeedGrowthRate
            // 
            this.txtHighSpeedGrowthRate.BackColor = System.Drawing.Color.Wheat;
            this.txtHighSpeedGrowthRate.Location = new System.Drawing.Point(224, 144);
            this.txtHighSpeedGrowthRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtHighSpeedGrowthRate.Name = "txtHighSpeedGrowthRate";
            this.txtHighSpeedGrowthRate.Size = new System.Drawing.Size(160, 21);
            this.txtHighSpeedGrowthRate.TabIndex = 13;
            this.txtHighSpeedGrowthRate.Text = "5.0";
            // 
            // lblHighSpeedGrowthRate
            // 
            this.lblHighSpeedGrowthRate.AutoSize = true;
            this.lblHighSpeedGrowthRate.Location = new System.Drawing.Point(5, 149);
            this.lblHighSpeedGrowthRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighSpeedGrowthRate.Name = "lblHighSpeedGrowthRate";
            this.lblHighSpeedGrowthRate.Size = new System.Drawing.Size(161, 12);
            this.lblHighSpeedGrowthRate.TabIndex = 12;
            this.lblHighSpeedGrowthRate.Text = "High Speed Growth Rate %: ";
            // 
            // txtHighSpeedGrowthDuration
            // 
            this.txtHighSpeedGrowthDuration.BackColor = System.Drawing.Color.Wheat;
            this.txtHighSpeedGrowthDuration.Location = new System.Drawing.Point(224, 176);
            this.txtHighSpeedGrowthDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtHighSpeedGrowthDuration.Name = "txtHighSpeedGrowthDuration";
            this.txtHighSpeedGrowthDuration.Size = new System.Drawing.Size(160, 21);
            this.txtHighSpeedGrowthDuration.TabIndex = 15;
            this.txtHighSpeedGrowthDuration.Text = "3";
            // 
            // lblHighSpeedGrowthDuration
            // 
            this.lblHighSpeedGrowthDuration.AutoSize = true;
            this.lblHighSpeedGrowthDuration.Location = new System.Drawing.Point(5, 181);
            this.lblHighSpeedGrowthDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighSpeedGrowthDuration.Name = "lblHighSpeedGrowthDuration";
            this.lblHighSpeedGrowthDuration.Size = new System.Drawing.Size(173, 12);
            this.lblHighSpeedGrowthDuration.TabIndex = 14;
            this.lblHighSpeedGrowthDuration.Text = "High Speed Growth Duration: ";
            // 
            // txtProfitSharingRate
            // 
            this.txtProfitSharingRate.BackColor = System.Drawing.Color.Wheat;
            this.txtProfitSharingRate.Location = new System.Drawing.Point(224, 82);
            this.txtProfitSharingRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfitSharingRate.Name = "txtProfitSharingRate";
            this.txtProfitSharingRate.Size = new System.Drawing.Size(160, 21);
            this.txtProfitSharingRate.TabIndex = 17;
            this.txtProfitSharingRate.Text = "20";
            // 
            // lblProfitSharingRate
            // 
            this.lblProfitSharingRate.AutoSize = true;
            this.lblProfitSharingRate.Location = new System.Drawing.Point(5, 86);
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
            this.txtProfitSharingTax.BackColor = System.Drawing.Color.Wheat;
            this.txtProfitSharingTax.Location = new System.Drawing.Point(224, 204);
            this.txtProfitSharingTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfitSharingTax.Name = "txtProfitSharingTax";
            this.txtProfitSharingTax.Size = new System.Drawing.Size(160, 21);
            this.txtProfitSharingTax.TabIndex = 20;
            this.txtProfitSharingTax.Text = "0.5";
            // 
            // lblProfitSharingTax
            // 
            this.lblProfitSharingTax.AutoSize = true;
            this.lblProfitSharingTax.Location = new System.Drawing.Point(5, 210);
            this.lblProfitSharingTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfitSharingTax.Name = "lblProfitSharingTax";
            this.lblProfitSharingTax.Size = new System.Drawing.Size(161, 12);
            this.lblProfitSharingTax.TabIndex = 19;
            this.lblProfitSharingTax.Text = "Profit Sharing Tax Rate %:";
            // 
            // txtDepressionFrequency
            // 
            this.txtDepressionFrequency.BackColor = System.Drawing.Color.Wheat;
            this.txtDepressionFrequency.Location = new System.Drawing.Point(224, 235);
            this.txtDepressionFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepressionFrequency.Name = "txtDepressionFrequency";
            this.txtDepressionFrequency.Size = new System.Drawing.Size(160, 21);
            this.txtDepressionFrequency.TabIndex = 22;
            this.txtDepressionFrequency.Text = "5";
            // 
            // lblDepressionFrequency
            // 
            this.lblDepressionFrequency.AutoSize = true;
            this.lblDepressionFrequency.Location = new System.Drawing.Point(5, 238);
            this.lblDepressionFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepressionFrequency.Name = "lblDepressionFrequency";
            this.lblDepressionFrequency.Size = new System.Drawing.Size(179, 12);
            this.lblDepressionFrequency.TabIndex = 21;
            this.lblDepressionFrequency.Text = "Depression Frequency (years):";
            // 
            // txtDepressionLossRate
            // 
            this.txtDepressionLossRate.BackColor = System.Drawing.Color.Wheat;
            this.txtDepressionLossRate.Location = new System.Drawing.Point(224, 262);
            this.txtDepressionLossRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepressionLossRate.Name = "txtDepressionLossRate";
            this.txtDepressionLossRate.Size = new System.Drawing.Size(160, 21);
            this.txtDepressionLossRate.TabIndex = 24;
            this.txtDepressionLossRate.Text = "90.0";
            // 
            // lblDepressionLossRate
            // 
            this.lblDepressionLossRate.AutoSize = true;
            this.lblDepressionLossRate.Location = new System.Drawing.Point(5, 266);
            this.lblDepressionLossRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepressionLossRate.Name = "lblDepressionLossRate";
            this.lblDepressionLossRate.Size = new System.Drawing.Size(143, 12);
            this.lblDepressionLossRate.TabIndex = 23;
            this.lblDepressionLossRate.Text = "Depression Loss Rate %:";
            // 
            // txtStockHeldDuration
            // 
            this.txtStockHeldDuration.BackColor = System.Drawing.Color.Wheat;
            this.txtStockHeldDuration.Location = new System.Drawing.Point(224, 294);
            this.txtStockHeldDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockHeldDuration.Name = "txtStockHeldDuration";
            this.txtStockHeldDuration.Size = new System.Drawing.Size(160, 21);
            this.txtStockHeldDuration.TabIndex = 26;
            this.txtStockHeldDuration.Text = "10";
            // 
            // lblStockHeldDuration
            // 
            this.lblStockHeldDuration.AutoSize = true;
            this.lblStockHeldDuration.Location = new System.Drawing.Point(5, 298);
            this.lblStockHeldDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockHeldDuration.Name = "lblStockHeldDuration";
            this.lblStockHeldDuration.Size = new System.Drawing.Size(167, 12);
            this.lblStockHeldDuration.TabIndex = 25;
            this.lblStockHeldDuration.Text = "Stock Held Duration (year):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalculate.Location = new System.Drawing.Point(109, 503);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(198, 34);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnParseCompanyDetails
            // 
            this.btnParseCompanyDetails.BackColor = System.Drawing.Color.SkyBlue;
            this.btnParseCompanyDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParseCompanyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParseCompanyDetails.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParseCompanyDetails.Location = new System.Drawing.Point(109, 455);
            this.btnParseCompanyDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnParseCompanyDetails.Name = "btnParseCompanyDetails";
            this.btnParseCompanyDetails.Size = new System.Drawing.Size(198, 34);
            this.btnParseCompanyDetails.TabIndex = 28;
            this.btnParseCompanyDetails.Text = "Parse Details From File";
            this.btnParseCompanyDetails.UseVisualStyleBackColor = false;
            this.btnParseCompanyDetails.Click += new System.EventHandler(this.btnParseCompanyDetails_Click);
            // 
            // openFileDialogForCompanyDetails
            // 
            this.openFileDialogForCompanyDetails.FileName = "openFileDialogForCompanyDetails";
            // 
            // btnParseCompanyDetailsFromServer
            // 
            this.btnParseCompanyDetailsFromServer.BackColor = System.Drawing.Color.SkyBlue;
            this.btnParseCompanyDetailsFromServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParseCompanyDetailsFromServer.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParseCompanyDetailsFromServer.Location = new System.Drawing.Point(111, 497);
            this.btnParseCompanyDetailsFromServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnParseCompanyDetailsFromServer.Name = "btnParseCompanyDetailsFromServer";
            this.btnParseCompanyDetailsFromServer.Size = new System.Drawing.Size(197, 34);
            this.btnParseCompanyDetailsFromServer.TabIndex = 29;
            this.btnParseCompanyDetailsFromServer.Text = "Parse Details From Server";
            this.btnParseCompanyDetailsFromServer.UseVisualStyleBackColor = false;
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
            this.tabControl1.Size = new System.Drawing.Size(441, 576);
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
            this.calculationPage.Size = new System.Drawing.Size(433, 550);
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
            this.groupBoxForManualInputParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxForManualInputParams.Location = new System.Drawing.Point(6, 125);
            this.groupBoxForManualInputParams.Name = "groupBoxForManualInputParams";
            this.groupBoxForManualInputParams.Size = new System.Drawing.Size(421, 325);
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
            this.groupBoxForServerParseParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxForServerParseParams.Location = new System.Drawing.Point(6, 6);
            this.groupBoxForServerParseParams.Name = "groupBoxForServerParseParams";
            this.groupBoxForServerParseParams.Size = new System.Drawing.Size(421, 112);
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
            this.stockMarketPage.Size = new System.Drawing.Size(433, 550);
            this.stockMarketPage.TabIndex = 1;
            this.stockMarketPage.Text = "stockMarketPage";
            this.stockMarketPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxForCheckingParameters
            // 
            this.groupBoxForCheckingParameters.Controls.Add(this.checkBoxUsePreviousProfit);
            this.groupBoxForCheckingParameters.Controls.Add(this.checkBoxKeepPreferStockID);
            this.groupBoxForCheckingParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxForCheckingParameters.Location = new System.Drawing.Point(6, 6);
            this.groupBoxForCheckingParameters.Name = "groupBoxForCheckingParameters";
            this.groupBoxForCheckingParameters.Size = new System.Drawing.Size(421, 49);
            this.groupBoxForCheckingParameters.TabIndex = 43;
            this.groupBoxForCheckingParameters.TabStop = false;
            this.groupBoxForCheckingParameters.Text = "CheckingParameters";
            // 
            // checkBoxUsePreviousProfit
            // 
            this.checkBoxUsePreviousProfit.AutoSize = true;
            this.checkBoxUsePreviousProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUsePreviousProfit.Location = new System.Drawing.Point(280, 20);
            this.checkBoxUsePreviousProfit.Name = "checkBoxUsePreviousProfit";
            this.checkBoxUsePreviousProfit.Size = new System.Drawing.Size(135, 16);
            this.checkBoxUsePreviousProfit.TabIndex = 43;
            this.checkBoxUsePreviousProfit.Text = "Use Previous Profit";
            this.checkBoxUsePreviousProfit.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeepPreferStockID
            // 
            this.checkBoxKeepPreferStockID.AutoSize = true;
            this.checkBoxKeepPreferStockID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxKeepPreferStockID.Location = new System.Drawing.Point(7, 20);
            this.checkBoxKeepPreferStockID.Name = "checkBoxKeepPreferStockID";
            this.checkBoxKeepPreferStockID.Size = new System.Drawing.Size(141, 16);
            this.checkBoxKeepPreferStockID.TabIndex = 42;
            this.checkBoxKeepPreferStockID.Text = "Keep Prefer Stock ID";
            this.checkBoxKeepPreferStockID.UseVisualStyleBackColor = true;
            // 
            // btnClearPreferStockList
            // 
            this.btnClearPreferStockList.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClearPreferStockList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPreferStockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPreferStockList.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearPreferStockList.Location = new System.Drawing.Point(244, 454);
            this.btnClearPreferStockList.Name = "btnClearPreferStockList";
            this.btnClearPreferStockList.Size = new System.Drawing.Size(177, 32);
            this.btnClearPreferStockList.TabIndex = 41;
            this.btnClearPreferStockList.Text = "Clear Prefer Stock IDs";
            this.btnClearPreferStockList.UseVisualStyleBackColor = false;
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
            this.groupBoxForStockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxForStockInfo.Location = new System.Drawing.Point(6, 61);
            this.groupBoxForStockInfo.Name = "groupBoxForStockInfo";
            this.groupBoxForStockInfo.Size = new System.Drawing.Size(421, 375);
            this.groupBoxForStockInfo.TabIndex = 40;
            this.groupBoxForStockInfo.TabStop = false;
            this.groupBoxForStockInfo.Text = "StockInfo";
            // 
            // lblFifthYearProfitSharing
            // 
            this.lblFifthYearProfitSharing.AutoSize = true;
            this.lblFifthYearProfitSharing.Location = new System.Drawing.Point(5, 347);
            this.lblFifthYearProfitSharing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFifthYearProfitSharing.Name = "lblFifthYearProfitSharing";
            this.lblFifthYearProfitSharing.Size = new System.Drawing.Size(149, 12);
            this.lblFifthYearProfitSharing.TabIndex = 53;
            this.lblFifthYearProfitSharing.Text = "5th Year Profit Sharing:";
            // 
            // txtFifthYearProfitSharing
            // 
            this.txtFifthYearProfitSharing.BackColor = System.Drawing.Color.Wheat;
            this.txtFifthYearProfitSharing.Enabled = false;
            this.txtFifthYearProfitSharing.Location = new System.Drawing.Point(201, 345);
            this.txtFifthYearProfitSharing.Margin = new System.Windows.Forms.Padding(2);
            this.txtFifthYearProfitSharing.Name = "txtFifthYearProfitSharing";
            this.txtFifthYearProfitSharing.Size = new System.Drawing.Size(184, 21);
            this.txtFifthYearProfitSharing.TabIndex = 54;
            // 
            // lblFourthYearProfitSharing
            // 
            this.lblFourthYearProfitSharing.AutoSize = true;
            this.lblFourthYearProfitSharing.Location = new System.Drawing.Point(5, 317);
            this.lblFourthYearProfitSharing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFourthYearProfitSharing.Name = "lblFourthYearProfitSharing";
            this.lblFourthYearProfitSharing.Size = new System.Drawing.Size(149, 12);
            this.lblFourthYearProfitSharing.TabIndex = 51;
            this.lblFourthYearProfitSharing.Text = "4th Year Profit Sharing:";
            // 
            // txtFourthYearProfitSharing
            // 
            this.txtFourthYearProfitSharing.BackColor = System.Drawing.Color.Wheat;
            this.txtFourthYearProfitSharing.Enabled = false;
            this.txtFourthYearProfitSharing.Location = new System.Drawing.Point(201, 314);
            this.txtFourthYearProfitSharing.Margin = new System.Windows.Forms.Padding(2);
            this.txtFourthYearProfitSharing.Name = "txtFourthYearProfitSharing";
            this.txtFourthYearProfitSharing.Size = new System.Drawing.Size(184, 21);
            this.txtFourthYearProfitSharing.TabIndex = 52;
            // 
            // lblThirdYearProfitSharing
            // 
            this.lblThirdYearProfitSharing.AutoSize = true;
            this.lblThirdYearProfitSharing.Location = new System.Drawing.Point(5, 283);
            this.lblThirdYearProfitSharing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThirdYearProfitSharing.Name = "lblThirdYearProfitSharing";
            this.lblThirdYearProfitSharing.Size = new System.Drawing.Size(149, 12);
            this.lblThirdYearProfitSharing.TabIndex = 49;
            this.lblThirdYearProfitSharing.Text = "3rd Year Profit Sharing:";
            // 
            // txtThirdYearProfitSharing
            // 
            this.txtThirdYearProfitSharing.BackColor = System.Drawing.Color.Wheat;
            this.txtThirdYearProfitSharing.Enabled = false;
            this.txtThirdYearProfitSharing.Location = new System.Drawing.Point(201, 281);
            this.txtThirdYearProfitSharing.Margin = new System.Windows.Forms.Padding(2);
            this.txtThirdYearProfitSharing.Name = "txtThirdYearProfitSharing";
            this.txtThirdYearProfitSharing.Size = new System.Drawing.Size(184, 21);
            this.txtThirdYearProfitSharing.TabIndex = 50;
            // 
            // lblSecondYearProfitSharing
            // 
            this.lblSecondYearProfitSharing.AutoSize = true;
            this.lblSecondYearProfitSharing.Location = new System.Drawing.Point(5, 250);
            this.lblSecondYearProfitSharing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondYearProfitSharing.Name = "lblSecondYearProfitSharing";
            this.lblSecondYearProfitSharing.Size = new System.Drawing.Size(149, 12);
            this.lblSecondYearProfitSharing.TabIndex = 47;
            this.lblSecondYearProfitSharing.Text = "2nd Year Profit Sharing:";
            // 
            // txtSecondYearProfitSharing
            // 
            this.txtSecondYearProfitSharing.BackColor = System.Drawing.Color.Wheat;
            this.txtSecondYearProfitSharing.Enabled = false;
            this.txtSecondYearProfitSharing.Location = new System.Drawing.Point(201, 248);
            this.txtSecondYearProfitSharing.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecondYearProfitSharing.Name = "txtSecondYearProfitSharing";
            this.txtSecondYearProfitSharing.Size = new System.Drawing.Size(184, 21);
            this.txtSecondYearProfitSharing.TabIndex = 48;
            // 
            // lblFirstYearProfitSharing
            // 
            this.lblFirstYearProfitSharing.AutoSize = true;
            this.lblFirstYearProfitSharing.Location = new System.Drawing.Point(5, 217);
            this.lblFirstYearProfitSharing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstYearProfitSharing.Name = "lblFirstYearProfitSharing";
            this.lblFirstYearProfitSharing.Size = new System.Drawing.Size(149, 12);
            this.lblFirstYearProfitSharing.TabIndex = 45;
            this.lblFirstYearProfitSharing.Text = "1st Year Profit Sharing:";
            // 
            // txtFirstYearProfitSharing
            // 
            this.txtFirstYearProfitSharing.BackColor = System.Drawing.Color.Wheat;
            this.txtFirstYearProfitSharing.Enabled = false;
            this.txtFirstYearProfitSharing.Location = new System.Drawing.Point(201, 214);
            this.txtFirstYearProfitSharing.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstYearProfitSharing.Name = "txtFirstYearProfitSharing";
            this.txtFirstYearProfitSharing.Size = new System.Drawing.Size(184, 21);
            this.txtFirstYearProfitSharing.TabIndex = 46;
            // 
            // comboBoxStockIDList
            // 
            this.comboBoxStockIDList.BackColor = System.Drawing.Color.Wheat;
            this.comboBoxStockIDList.FormattingEnabled = true;
            this.comboBoxStockIDList.Location = new System.Drawing.Point(201, 20);
            this.comboBoxStockIDList.Name = "comboBoxStockIDList";
            this.comboBoxStockIDList.Size = new System.Drawing.Size(184, 20);
            this.comboBoxStockIDList.TabIndex = 44;
            this.comboBoxStockIDList.SelectedIndexChanged += new System.EventHandler(this.comboBoxStockIDList_SelectedIndexChanged);
            // 
            // lblPERatio
            // 
            this.lblPERatio.AutoSize = true;
            this.lblPERatio.Location = new System.Drawing.Point(5, 182);
            this.lblPERatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPERatio.Name = "lblPERatio";
            this.lblPERatio.Size = new System.Drawing.Size(59, 12);
            this.lblPERatio.TabIndex = 42;
            this.lblPERatio.Text = "PE Ratio:";
            // 
            // txtPERatio
            // 
            this.txtPERatio.BackColor = System.Drawing.Color.Wheat;
            this.txtPERatio.Enabled = false;
            this.txtPERatio.Location = new System.Drawing.Point(201, 179);
            this.txtPERatio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPERatio.Name = "txtPERatio";
            this.txtPERatio.Size = new System.Drawing.Size(184, 21);
            this.txtPERatio.TabIndex = 43;
            // 
            // lblDateOfInfo
            // 
            this.lblDateOfInfo.AutoSize = true;
            this.lblDateOfInfo.Location = new System.Drawing.Point(5, 82);
            this.lblDateOfInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfInfo.Name = "lblDateOfInfo";
            this.lblDateOfInfo.Size = new System.Drawing.Size(83, 12);
            this.lblDateOfInfo.TabIndex = 41;
            this.lblDateOfInfo.Text = "Date of Info:";
            // 
            // txtDateOfInfo
            // 
            this.txtDateOfInfo.BackColor = System.Drawing.Color.Wheat;
            this.txtDateOfInfo.Enabled = false;
            this.txtDateOfInfo.Location = new System.Drawing.Point(201, 79);
            this.txtDateOfInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateOfInfo.Name = "txtDateOfInfo";
            this.txtDateOfInfo.Size = new System.Drawing.Size(184, 21);
            this.txtDateOfInfo.TabIndex = 40;
            // 
            // lblSelectedStockID
            // 
            this.lblSelectedStockID.AutoSize = true;
            this.lblSelectedStockID.Location = new System.Drawing.Point(5, 23);
            this.lblSelectedStockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedStockID.Name = "lblSelectedStockID";
            this.lblSelectedStockID.Size = new System.Drawing.Size(59, 12);
            this.lblSelectedStockID.TabIndex = 32;
            this.lblSelectedStockID.Text = "Stock ID:";
            // 
            // lblCompanyProfitPerShare
            // 
            this.lblCompanyProfitPerShare.AutoSize = true;
            this.lblCompanyProfitPerShare.Location = new System.Drawing.Point(5, 146);
            this.lblCompanyProfitPerShare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyProfitPerShare.Name = "lblCompanyProfitPerShare";
            this.lblCompanyProfitPerShare.Size = new System.Drawing.Size(155, 12);
            this.lblCompanyProfitPerShare.TabIndex = 38;
            this.lblCompanyProfitPerShare.Text = "Company Profit Per Share:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(5, 52);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(83, 12);
            this.lblCompanyName.TabIndex = 37;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtCompanyProfitPerShare
            // 
            this.txtCompanyProfitPerShare.BackColor = System.Drawing.Color.Wheat;
            this.txtCompanyProfitPerShare.Enabled = false;
            this.txtCompanyProfitPerShare.Location = new System.Drawing.Point(201, 143);
            this.txtCompanyProfitPerShare.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyProfitPerShare.Name = "txtCompanyProfitPerShare";
            this.txtCompanyProfitPerShare.Size = new System.Drawing.Size(184, 21);
            this.txtCompanyProfitPerShare.TabIndex = 39;
            // 
            // txtLastTradingPrice
            // 
            this.txtLastTradingPrice.BackColor = System.Drawing.Color.Wheat;
            this.txtLastTradingPrice.Enabled = false;
            this.txtLastTradingPrice.Location = new System.Drawing.Point(201, 111);
            this.txtLastTradingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastTradingPrice.Name = "txtLastTradingPrice";
            this.txtLastTradingPrice.Size = new System.Drawing.Size(184, 21);
            this.txtLastTradingPrice.TabIndex = 36;
            // 
            // lblLastTradingPrice
            // 
            this.lblLastTradingPrice.AutoSize = true;
            this.lblLastTradingPrice.Location = new System.Drawing.Point(5, 114);
            this.lblLastTradingPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastTradingPrice.Name = "lblLastTradingPrice";
            this.lblLastTradingPrice.Size = new System.Drawing.Size(119, 12);
            this.lblLastTradingPrice.TabIndex = 35;
            this.lblLastTradingPrice.Text = "Last Trading Price:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.Wheat;
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(201, 50);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(184, 21);
            this.txtCompanyName.TabIndex = 34;
            // 
            // btnRetrieveStockInfo
            // 
            this.btnRetrieveStockInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRetrieveStockInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetrieveStockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveStockInfo.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRetrieveStockInfo.Location = new System.Drawing.Point(6, 454);
            this.btnRetrieveStockInfo.Name = "btnRetrieveStockInfo";
            this.btnRetrieveStockInfo.Size = new System.Drawing.Size(177, 32);
            this.btnRetrieveStockInfo.TabIndex = 31;
            this.btnRetrieveStockInfo.Text = "Retrieve Stock Info";
            this.btnRetrieveStockInfo.UseVisualStyleBackColor = false;
            this.btnRetrieveStockInfo.Click += new System.EventHandler(this.btnRetrieveStockInfo_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(465, 599);
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
        private System.Windows.Forms.CheckBox checkBoxUsePreviousProfit;
    }
}

