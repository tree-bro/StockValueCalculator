using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace StockValueCalculator
{
    public partial class Form1 : Form
    {
        //parse input parameters before calculation
        private decimal marketPrice;
        private decimal tradingTaxRate;
        private decimal profitPerShare;
        private decimal profitSharingRate;
        private short companyDuration;
        private decimal discountRate;
        private decimal normalGrowthRate;
        private decimal highSpeedGrowthRate;
        private short highSpeedGrwothDuration;
        private decimal profitSharingTaxRate;
        private short depressionFrequency;
        private decimal depressionLossRate;
        private short stockHeldDuration;

        private decimal assumedStockPriceGrowth = new decimal(0.02);

        //temp variables for calculation
        private decimal totalInnerValue;
        private decimal currentInterest;
        private decimal totalProfitSharing;
        private decimal totalTradingTaxPaid;
        private decimal resultForSell;
        private decimal feePaid;
        private decimal totalBuyTax;
        private decimal totalSellTax;
        private decimal currentGrowth;

        private string successMessage = PromptMessages.successMessageEN;
        private string parseCompanyDetailsFormatError = PromptMessages.parseCompanyDetailsFormatErrorEN;
        private string parseCompanyDetailsSuccessMessage = PromptMessages.parseCompanyDetailsSuccessMessageEN;
        private string retrieveStockInfoSuccessMessage = PromptMessages.retrieveStockInfoSuccessMessageEN;
        private string retrieveStockInfoFailedMessage = PromptMessages.retrieveStockInfoFailedMessageEN;
        private string parseCompanyDetailsFromServerSuccessMessage = PromptMessages.parseCompanyDetailsFromServerSuccessMessageEN;
        private string parseCompanyDetailsFromServerError = PromptMessages.parseCompanyDetailsFromServerErrorEN;
        private string unknownStockIDMessage = PromptMessages.unknownStockIDMessageEN;

        public Form1()
        {
            InitializeComponent();
            setLanguagePreference();
        }

        private void setLanguagePreference()
        {
            CultureInfo info = Thread.CurrentThread.CurrentUICulture;
            if (info.Name.Equals("zh-cn", StringComparison.CurrentCultureIgnoreCase))
            {
                lblMarketPrice.Text = ConfigurationManager.AppSettings.Get("txtMarketPrice_zh");
                lblTradeTaxRate.Text = ConfigurationManager.AppSettings.Get("txtTradingTaxRate_zh");
                lblProfitPerShare.Text = ConfigurationManager.AppSettings.Get("txtProfitPerShare_zh");
                lblProfitSharingRate.Text = ConfigurationManager.AppSettings.Get("txtProfitSharingRate_zh");
                lblCompanyDuration.Text = ConfigurationManager.AppSettings.Get("txtCompanyDuration_zh");
                lblDiscountRate.Text = ConfigurationManager.AppSettings.Get("txtDiscountRate_zh");
                lblNormalGrowthRate.Text = ConfigurationManager.AppSettings.Get("txtNormalGrowthRate_zh");
                lblHighSpeedGrowthRate.Text = ConfigurationManager.AppSettings.Get("txtHighSpeedGrowthRate_zh");
                lblHighSpeedGrowthDuration.Text = ConfigurationManager.AppSettings.Get("txtHighSpeedGrowthDuration_zh");
                lblProfitSharingTax.Text = ConfigurationManager.AppSettings.Get("txtProfitSharingTaxRate_zh");
                lblDepressionFrequency.Text = ConfigurationManager.AppSettings.Get("txtDepressionFrequency_zh");
                lblDepressionLossRate.Text = ConfigurationManager.AppSettings.Get("txtDepressionLossRate_zh");
                lblStockHeldDuration.Text = ConfigurationManager.AppSettings.Get("txtStockHeldDuration_zh");
                btnParseCompanyDetails.Text = ConfigurationManager.AppSettings.Get("btnParseCompanyDetails_zh");
                btnParseCompanyDetailsFromServer.Text = ConfigurationManager.AppSettings.Get("btnParseCompanyDetailsFromServer_zh");
                btnCalculate.Text = ConfigurationManager.AppSettings.Get("btnCalculate_zh");
                btnRetrieveStockInfo.Text = ConfigurationManager.AppSettings.Get("btnRefreshStockList_zh");

                lblSelectedStockID.Text = ConfigurationManager.AppSettings.Get("txtStockID_zh");
                lblCompanyName.Text = ConfigurationManager.AppSettings.Get("txtCompanyName_zh");
                lblLastTradingPrice.Text = ConfigurationManager.AppSettings.Get("txtLastTradingPrice_zh");
                lblCompanyProfitPerShare.Text = ConfigurationManager.AppSettings.Get("txtCompanyProfitPerShare_zh");
                lblDateOfInfo.Text = ConfigurationManager.AppSettings.Get("txtDateOfInfo_zh");
                lblPERatio.Text = ConfigurationManager.AppSettings.Get("txtPERatio_zh");

                calculationPage.Text = ConfigurationManager.AppSettings.Get("tabCalculationPage_zh");
                stockMarketPage.Text = ConfigurationManager.AppSettings.Get("tabStockMarketPage_zh");
                groupBoxForStockInfo.Text = ConfigurationManager.AppSettings.Get("groupStockInfo_zh");

                successMessage = PromptMessages.successMessageZH;
                parseCompanyDetailsFormatError = PromptMessages.parseCompanyDetailsFormatErrorZH;
                parseCompanyDetailsSuccessMessage = PromptMessages.parseCompanyDetailsSuccessMessageZH;
                retrieveStockInfoSuccessMessage = PromptMessages.retrieveStockInfoSuccessMessageZH;
                retrieveStockInfoFailedMessage = PromptMessages.retrieveStockInfoFailedMessageZH;
                parseCompanyDetailsFromServerSuccessMessage = PromptMessages.parseCompanyDetailsFromServerSuccessMessageZH;
                parseCompanyDetailsFromServerError = PromptMessages.parseCompanyDetailsFromServerErrorZH;
                unknownStockIDMessage = PromptMessages.unknownStockIDMessageZH;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Retrieve input params.
            parseInputParameters();

            //Declare temp variables for calculation
            resetTempCalVariables();

            for (var idx = 1; idx <= companyDuration; idx++) {
                //calculate the risk interest rate for current year
                currentInterest = currentInterest * (decimal.One / (decimal.One + discountRate));

                //If HSG is larger than 0, and current year has not reach the upper limit for HSG, then calculate for HSG
                if (highSpeedGrowthRate > 0 && highSpeedGrwothDuration >= idx) {
                    currentGrowth = currentGrowth * (decimal.One + highSpeedGrowthRate);
                } else {
                    currentGrowth = currentGrowth * (decimal.One + normalGrowthRate);
                }

                if (idx % depressionFrequency > 0)
                {
                    totalProfitSharing = totalProfitSharing + currentInterest * profitPerShare * currentGrowth * profitSharingRate * (decimal.One - profitSharingTaxRate);
                    totalTradingTaxPaid = totalTradingTaxPaid + currentInterest * profitPerShare * currentGrowth * profitSharingRate * profitSharingTaxRate;
                    totalInnerValue = totalInnerValue + currentInterest * profitPerShare * currentGrowth * (1 - profitSharingRate);
                    resultForSell = resultForSell + profitPerShare * currentGrowth * (1 - profitSharingRate);
                } else {
                    totalProfitSharing = totalProfitSharing + currentInterest * profitPerShare * currentGrowth * profitSharingRate * (decimal.One - profitSharingTaxRate) * (decimal.One - depressionLossRate);
                    totalTradingTaxPaid = totalTradingTaxPaid + currentInterest * profitPerShare * currentGrowth * profitSharingRate * profitSharingTaxRate * (decimal.One - depressionLossRate);
                    totalInnerValue = totalInnerValue + currentInterest * profitPerShare * currentGrowth * (decimal.One - profitSharingRate) * (decimal.One - depressionLossRate);
                    resultForSell = resultForSell + profitPerShare * currentGrowth * (decimal.One - profitSharingRate) * (decimal.One - depressionLossRate);
                }

                if (stockHeldDuration > 0 && idx % stockHeldDuration == 0) {
                    totalBuyTax = totalBuyTax + marketPrice * (decimal.One + idx * assumedStockPriceGrowth) * tradingTaxRate * currentInterest;
                    totalSellTax = totalSellTax + marketPrice * (decimal.One + idx * assumedStockPriceGrowth) * tradingTaxRate * currentInterest;
                }
            }
            totalSellTax = totalSellTax + resultForSell * currentInterest * tradingTaxRate;

            string displaySuccessMessage = successMessage
                                                .Replace("[_MARKET_PRICE_]", Convert.ToString(decimal.Round(marketPrice, 5)))
                                                .Replace("[_INNER_VALUE_DEDUCT_PROFIT_SHARING_]", Convert.ToString(decimal.Round(totalInnerValue, 5)))
                                                .Replace("[_PROFIT_SHARING_]", Convert.ToString(decimal.Round(totalProfitSharing, 5)))
                                                .Replace("[_TRADING_TAX_PAID_]", Convert.ToString(decimal.Round(totalTradingTaxPaid, 5)))
                                                .Replace("[_BUY_TAX_PAID_]", Convert.ToString(decimal.Round(totalBuyTax, 5)))
                                                .Replace("[_SELL_TAX_PAID_]",Convert.ToString(decimal.Round(totalSellTax, 5)))
                                                .Replace("[_INNER_VALUE_]", Convert.ToString(decimal.Round(totalInnerValue + totalProfitSharing - totalBuyTax - totalSellTax - totalTradingTaxPaid, 5)))
                                                .Replace("[_MARKET_PRICE_TO_INNER_VALUE_]", Convert.ToString(decimal.Round(marketPrice / (totalInnerValue + totalProfitSharing - totalBuyTax - totalSellTax - totalTradingTaxPaid) * 100, 5)));

            MessageBox.Show(displaySuccessMessage, "Calculation Result");
        }
	        
        private void resetTempCalVariables()
        {
            totalInnerValue = decimal.Zero;
            currentInterest = decimal.One;
            totalProfitSharing = decimal.Zero;
            totalTradingTaxPaid = decimal.Zero;
            resultForSell = decimal.Zero;
            feePaid = decimal.Zero;
            totalBuyTax = marketPrice * tradingTaxRate;
            totalSellTax = decimal.Zero;
            currentGrowth = decimal.One;
        }

        private void parseInputParameters()
        {
            marketPrice = decimal.Parse(txtMarketPrice.Text.Trim());
            tradingTaxRate = decimal.Parse(txtTradeTaxRate.Text.Trim()) / 100M;
            profitPerShare = decimal.Parse(txtProfitPerShare.Text.Trim());
            profitSharingRate = decimal.Parse(txtProfitSharingRate.Text.Trim()) / 100M;
            companyDuration = short.Parse(txtCompanyDuration.Text.Trim());
            discountRate = decimal.Parse(txtDiscountRate.Text.Trim()) / 100M;
            normalGrowthRate = decimal.Parse(txtNormalGrowthRate.Text.Trim()) / 100M;
            highSpeedGrowthRate = decimal.Parse(txtHighSpeedGrowthRate.Text.Trim()) / 100M;
            highSpeedGrwothDuration = short.Parse(txtHighSpeedGrowthDuration.Text.Trim());
            profitSharingTaxRate = decimal.Parse(txtProfitSharingTax.Text.Trim()) / 100M;
            depressionFrequency = short.Parse(txtDepressionFrequency.Text.Trim());
            depressionLossRate = decimal.Parse(txtDepressionLossRate.Text.Trim()) / 100M;
            stockHeldDuration = short.Parse(txtStockHeldDuration.Text.Trim());
        }

        private void parseInputParametersFromFile(string line)
        {
            string[] splitLines = line.Trim().Split(',');
            if(splitLines.Length < 2)
            {
                return;
            }

            if(splitLines[0].Trim().Equals("market price", StringComparison.CurrentCultureIgnoreCase))
            {
                txtMarketPrice.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("trading tax rate %", StringComparison.CurrentCultureIgnoreCase))
            {
                txtTradeTaxRate.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("profit per share", StringComparison.CurrentCultureIgnoreCase))
            {
                txtProfitPerShare.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("profit sharing rate %", StringComparison.CurrentCultureIgnoreCase))
            {
                txtProfitSharingRate.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("company duration", StringComparison.CurrentCultureIgnoreCase))
            {
                txtCompanyDuration.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("discount rate %", StringComparison.CurrentCultureIgnoreCase))
            {
                txtDiscountRate.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("normal growth rate %", StringComparison.CurrentCultureIgnoreCase))
            {
                txtNormalGrowthRate.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("high speed growth rate %", StringComparison.CurrentCultureIgnoreCase))
            {
                txtHighSpeedGrowthRate.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("high speed growth duration", StringComparison.CurrentCultureIgnoreCase))
            {
                txtHighSpeedGrowthDuration.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("profit sharing tax rate %", StringComparison.CurrentCultureIgnoreCase))
            {
                txtProfitSharingTax.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("depression frequency", StringComparison.CurrentCultureIgnoreCase))
            {
                txtDepressionFrequency.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("depression loss rate %", StringComparison.CurrentCultureIgnoreCase))
            {
                txtDepressionLossRate.Text = splitLines[1].Trim();
            }
            else if(splitLines[0].Trim().Equals("stock held duration", StringComparison.CurrentCultureIgnoreCase))
            {
                txtStockHeldDuration.Text = splitLines[1].Trim();
            }
        }

        private void btnParseCompanyDetails_Click(object sender, EventArgs e)
        {
            openFileDialogForCompanyDetails.ShowDialog();
            string selectedFilePath = openFileDialogForCompanyDetails.FileName;

            if (!selectedFilePath.EndsWith(".csv"))
            {
                MessageBox.Show(parseCompanyDetailsFormatError, "File Format Error");
                return;
            }

            foreach(string line in File.ReadAllLines(selectedFilePath))
            {
                parseInputParametersFromFile(line);
            }

            MessageBox.Show(parseCompanyDetailsSuccessMessage.Replace("[_FILE_PATH_]", selectedFilePath));
        }

        private void btnParseCompanyDetailsFromServer_Click(object sender, EventArgs e)
        {
            if (!txtCompanyName.Text.Trim().Equals(""))
            {
                txtMarketPrice.Text = txtLastTradingPrice.Text;
                txtProfitPerShare.Text = txtCompanyProfitPerShare.Text;

                MessageBox.Show(parseCompanyDetailsFromServerSuccessMessage.Replace("[_STOCK_ID_]", txtStockID.Text.Trim()).Replace("[_COMPANY_NAME_]", txtCompanyName.Text.Trim()));
                tabControl1.SelectTab(calculationPage);
                resetStockInfoPageParameters();
            }
            else
            {
                MessageBox.Show(parseCompanyDetailsFromServerError);
            }
            
        }

        private void resetStockInfoPageParameters()
        {
            txtCompanyName.Text = "";
            txtDateOfInfo.Text = "";
            txtLastTradingPrice.Text = "";
            txtCompanyProfitPerShare.Text = "";
            txtPERatio.Text = "";
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void btnRetrieveStockInfo_Click(object sender, EventArgs e)
        {
            
            string stockID = txtStockID.Text.Trim();

            StockMarketTypes marketType = Utils.checkMarketType(stockID);

            switch (marketType)
            {
                case StockMarketTypes.CHINA_SZ_EXCHANGE_MARKET:
                    retrieveStockInfoByID("sz" + stockID);
                    break;
                case StockMarketTypes.CHINA_SH_EXCHANGE_MARKET:
                    retrieveStockInfoByID("sh" + stockID);
                    break;
                case StockMarketTypes.UNKNOWN:
                    MessageBox.Show(unknownStockIDMessage);
                    break;
            }                
            
        }

        private void retrieveStockInfoByID(string stockID)
        {
            string requestURL = URLTemplates.baiduTemplateByID.Replace("[_STOCK_ID_]", stockID);

            HtmlAgilityPack.HtmlDocument htmlDocument = Utils.loadHtmlDocument(requestURL, Encoding.GetEncoding("utf-8"));

            HtmlNode tableNode = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='stock-bets']");

            if(tableNode != null)
            {
                HtmlNode nameNode = tableNode.SelectSingleNode("//a[@class='bets-name']");
                HtmlNode dateNode = tableNode.SelectSingleNode("//span[@class='state f-up']");
                HtmlNode closePriceNode = tableNode.SelectSingleNode("//strong[@class='_close']");
                HtmlNode detailNode = tableNode.SelectSingleNode("//div[@class='line1']");

                txtCompanyName.Text = nameNode.InnerText.Trim();
                txtLastTradingPrice.Text = closePriceNode.InnerText.Trim();
                txtDateOfInfo.Text = dateNode.InnerText.Trim().Replace("&nbsp;","");
                decimal companyProfitPerShare = decimal.Zero;
                decimal peRatio = decimal.Zero;
                decimal lastTradingPrice = decimal.Parse(closePriceNode.InnerText.Trim());
                foreach (HtmlNode subNode in detailNode.ChildNodes)
                {
                    if (subNode.HasChildNodes)
                    {
                        if (subNode.FirstChild.InnerText.Equals("每股收益", StringComparison.CurrentCultureIgnoreCase))
                        {
                            decimal.TryParse(subNode.LastChild.InnerText.Trim(), out companyProfitPerShare);
                        }
                        else if (subNode.FirstChild.InnerText.Contains("市盈率"))
                        {
                            txtPERatio.Text = subNode.LastChild.InnerText.Trim();
                            decimal.TryParse(subNode.LastChild.InnerText.Trim(), out peRatio);
                        }
                    }
                }

                // Recalculate the profit per share using PERatio and provided profit per share.
                if(companyProfitPerShare > 0 && peRatio > 0)
                {
                    companyProfitPerShare = decimal.Round((lastTradingPrice / peRatio) * 2 - companyProfitPerShare, 4);
                }
                else if(peRatio > 0)
                {
                    companyProfitPerShare = decimal.Round(lastTradingPrice / peRatio, 4);
                }

                
                txtCompanyProfitPerShare.Text = Convert.ToString(companyProfitPerShare);

                MessageBox.Show(retrieveStockInfoSuccessMessage);
            } else
            {
                MessageBox.Show(retrieveStockInfoFailedMessage);
            }
            
        }
       
    }
}