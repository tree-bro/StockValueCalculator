using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockValueCalculator
{
    public class CompanyFileInfo
    {
        public Dictionary<string, string> FieldMapping { get; }

        public CompanyFileInfo()
        {
            this.FieldMapping = new Dictionary<string, string>();

            //Here simply put all posibilities to the dic for ease of search
            this.FieldMapping.Add("market price", "txtMarketPrice");
            this.FieldMapping.Add("trading tax rate %", "txtTradeTaxRate");
            this.FieldMapping.Add("profit per share", "txtProfitPerShare");
            this.FieldMapping.Add("profit sharing rate %", "txtProfitSharingRate");
            this.FieldMapping.Add("company duration", "txtCompanyDuration");
            this.FieldMapping.Add("discount rate %", "txtDiscountRate");
            this.FieldMapping.Add("normal growth rate %", "txtNormalGrowthRate");
            this.FieldMapping.Add("high speed growth rate %", "txtHighSpeedGrowthRate");
            this.FieldMapping.Add("high speed growth duration", "txtHighSpeedGrowthDuration");
            this.FieldMapping.Add("profit sharing tax rate %", "txtProfitSharingTax");
            this.FieldMapping.Add("depression frequency", "txtDepressionFrequency");
            this.FieldMapping.Add("depression loss rate %", "txtDepressionLossRate");
            this.FieldMapping.Add("stock held duration", "txtStockHeldDuration");

            this.FieldMapping.Add("市场价", "txtMarketPrice");
            this.FieldMapping.Add("交易印花税", "txtTradeTaxRate");
            this.FieldMapping.Add("每股盈利", "txtProfitPerShare");
            this.FieldMapping.Add("每股分红派系比例", "txtProfitSharingRate");
            this.FieldMapping.Add("企业存续期", "txtCompanyDuration");
            this.FieldMapping.Add("折现率", "txtDiscountRate");
            this.FieldMapping.Add("自然增长率", "txtNormalGrowthRate");
            this.FieldMapping.Add("高速增长率", "txtHighSpeedGrowthRate");
            this.FieldMapping.Add("高速增长期", "txtHighSpeedGrowthDuration");
            this.FieldMapping.Add("红股税率", "txtProfitSharingTax");
            this.FieldMapping.Add("衰退周期", "txtDepressionFrequency");
            this.FieldMapping.Add("衰退期损失率", "txtDepressionLossRate");
            this.FieldMapping.Add("持股周期", "txtStockHeldDuration");
        }

        public string getControlName(string fieldName)
        {
            return this.FieldMapping[fieldName] == null ? "" : this.FieldMapping[fieldName];
        }
    }
}
