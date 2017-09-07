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
            setCalculationInitValues();
        }

        private void setLanguagePreference()
        {
            CultureInfo info = Thread.CurrentThread.CurrentUICulture;
            if (info.Name.Equals("zh-cn", StringComparison.CurrentCultureIgnoreCase))
            {
                lblMarketPrice.Text = ConfigurationManager.AppSettings.Get("lblMarketPrice_zh");
                lblTradeTaxRate.Text = ConfigurationManager.AppSettings.Get("lblTradingTaxRate_zh");
                lblProfitPerShare.Text = ConfigurationManager.AppSettings.Get("lblProfitPerShare_zh");
                lblProfitSharingRate.Text = ConfigurationManager.AppSettings.Get("lblProfitSharingRate_zh");
                lblCompanyDuration.Text = ConfigurationManager.AppSettings.Get("lblCompanyDuration_zh");
                lblDiscountRate.Text = ConfigurationManager.AppSettings.Get("lblDiscountRate_zh");
                lblNormalGrowthRate.Text = ConfigurationManager.AppSettings.Get("lblNormalGrowthRate_zh");
                lblHighSpeedGrowthRate.Text = ConfigurationManager.AppSettings.Get("lblHighSpeedGrowthRate_zh");
                lblHighSpeedGrowthDuration.Text = ConfigurationManager.AppSettings.Get("lblHighSpeedGrowthDuration_zh");
                lblProfitSharingTax.Text = ConfigurationManager.AppSettings.Get("lblProfitSharingTaxRate_zh");
                lblDepressionFrequency.Text = ConfigurationManager.AppSettings.Get("lblDepressionFrequency_zh");
                lblDepressionLossRate.Text = ConfigurationManager.AppSettings.Get("lblDepressionLossRate_zh");
                lblStockHeldDuration.Text = ConfigurationManager.AppSettings.Get("lblStockHeldDuration_zh");
                btnParseCompanyDetails.Text = ConfigurationManager.AppSettings.Get("btnParseCompanyDetails_zh");
                btnParseCompanyDetailsFromServer.Text = ConfigurationManager.AppSettings.Get("btnParseCompanyDetailsFromServer_zh");
                btnCalculate.Text = ConfigurationManager.AppSettings.Get("btnCalculate_zh");
                btnRetrieveStockInfo.Text = ConfigurationManager.AppSettings.Get("btnRefreshStockList_zh");

                lblSelectedStockID.Text = ConfigurationManager.AppSettings.Get("lblStockID_zh");
                lblCompanyName.Text = ConfigurationManager.AppSettings.Get("lblCompanyName_zh");
                lblLastTradingPrice.Text = ConfigurationManager.AppSettings.Get("lblLastTradingPrice_zh");
                lblCompanyProfitPerShare.Text = ConfigurationManager.AppSettings.Get("lblCompanyProfitPerShare_zh");
                lblDateOfInfo.Text = ConfigurationManager.AppSettings.Get("lblDateOfInfo_zh");
                lblPERatio.Text = ConfigurationManager.AppSettings.Get("lblPERatio_zh");

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

        private void setCalculationInitValues()
        {
            txtMarketPrice.Text = ConfigurationManager.AppSettings.Get("initValueMarketPrice");
            txtTradeTaxRate.Text = ConfigurationManager.AppSettings.Get("initValueTradingTaxRate");
            txtProfitPerShare.Text = ConfigurationManager.AppSettings.Get("initValueProfitPerShare");
            txtProfitSharingRate.Text = ConfigurationManager.AppSettings.Get("initValueProfitSharingRate");
            txtCompanyDuration.Text = ConfigurationManager.AppSettings.Get("initValueCompanyDuration");
            txtDiscountRate.Text = ConfigurationManager.AppSettings.Get("initValueDiscountRate");
            txtNormalGrowthRate.Text = ConfigurationManager.AppSettings.Get("initValueNormalGrowthRate");
            txtHighSpeedGrowthRate.Text = ConfigurationManager.AppSettings.Get("initValueHighSpeedGrowthRate");
            txtHighSpeedGrowthDuration.Text = ConfigurationManager.AppSettings.Get("initValueHighSpeedGrowthDuration");
            txtProfitSharingTax.Text = ConfigurationManager.AppSettings.Get("initValueProfitSharingTaxRate");
            txtDepressionFrequency.Text = ConfigurationManager.AppSettings.Get("initValueDepressionFrequency");
            txtDepressionLossRate.Text = ConfigurationManager.AppSettings.Get("initValueDepressionLossRate");
            txtStockHeldDuration.Text = ConfigurationManager.AppSettings.Get("initValueStockHeldDuration");
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
            decimal.TryParse(txtMarketPrice.Text.Trim(), out marketPrice);
            decimal.TryParse(txtTradeTaxRate.Text.Trim(), out tradingTaxRate);
            tradingTaxRate = tradingTaxRate / 100M;
            decimal.TryParse(txtProfitPerShare.Text.Trim(), out profitPerShare);
            decimal.TryParse(txtProfitSharingRate.Text.Trim(), out profitSharingRate);
            profitSharingRate = profitSharingRate / 100M;
            short.TryParse(txtCompanyDuration.Text.Trim(), out companyDuration);
            decimal.TryParse(txtDiscountRate.Text.Trim(), out discountRate);
            discountRate = discountRate / 100M;
            decimal.TryParse(txtNormalGrowthRate.Text.Trim(), out normalGrowthRate);
            normalGrowthRate = normalGrowthRate / 100M;
            decimal.TryParse(txtHighSpeedGrowthRate.Text.Trim(), out highSpeedGrowthRate);
            highSpeedGrowthRate = highSpeedGrowthRate / 100M;
            short.TryParse(txtHighSpeedGrowthDuration.Text.Trim(), out highSpeedGrwothDuration);
            decimal.TryParse(txtProfitSharingTax.Text.Trim(), out profitSharingTaxRate);
            profitSharingTaxRate = profitSharingTaxRate / 100M;
            short.TryParse(txtDepressionFrequency.Text.Trim(), out depressionFrequency);
            decimal.TryParse(txtDepressionLossRate.Text.Trim(), out depressionLossRate);
            depressionLossRate = depressionLossRate / 100M;
            short.TryParse(txtStockHeldDuration.Text.Trim(), out stockHeldDuration);
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
                decimal lastTradingPrice = decimal.Zero;
                decimal.TryParse(closePriceNode.InnerText.Trim(), out lastTradingPrice);
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