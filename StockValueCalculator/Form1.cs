using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

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

        public Form1()
        {
            InitializeComponent();
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

            StringBuilder sb = new StringBuilder();
            sb.Append("***********************************************\n");
            sb.Append("Inner value after deduct profit sharing: ");
            sb.Append(decimal.Round(totalInnerValue, 5));
            sb.Append("\n***********************************************\n");
            sb.Append("\n\n");
            sb.Append("***********************************************\n");
            sb.Append("Total profit sharing: ");
            sb.Append(decimal.Round(totalProfitSharing, 5));
            sb.Append("\n");
            sb.Append("Total trading tax paid: ");
            sb.Append(decimal.Round(totalTradingTaxPaid, 5));
            sb.Append("\n");
            sb.Append("Total buy tax paid: ");
            sb.Append(decimal.Round(totalBuyTax, 5));
            sb.Append("\n");
            sb.Append("Total sell tax paid: ");
            sb.Append(decimal.Round(totalSellTax, 5));
            sb.Append("\n");
            sb.Append("Total inner value for this stock: ");
            sb.Append(decimal.Round(totalInnerValue + totalProfitSharing - totalBuyTax - totalSellTax - totalTradingTaxPaid, 5));
            sb.Append("\n***********************************************\n");
            sb.Append("\n\n");
            sb.Append("***********************************************\n");
            sb.Append("Market Price/Inner Value: ");
            sb.Append(decimal.Round(marketPrice / (totalInnerValue + totalProfitSharing - totalBuyTax - totalSellTax - totalTradingTaxPaid) * 100,5) + "%");
            sb.Append("\n***********************************************\n");

            MessageBox.Show(sb.ToString(),"Calculation Result");
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
                MessageBox.Show("The selected company details file must be a csv file!", "File Format Error");
                return;
            }

            foreach(string line in File.ReadAllLines(selectedFilePath))
            {
                parseInputParametersFromFile(line);
            }

            MessageBox.Show("Successfully parsed company details from file [" + selectedFilePath + "]!");
        }
    }
}