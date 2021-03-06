﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockValueCalculator
{
    public class StockInfo
    {
        public string CompanyName { get; set; }
        public string LastTradingPrice { get; set; }
        public string DateOfInfo { get; set; }
        public string CompanyProfitPerShare { get; set; }
        public string PERatio { get; set; }

        public Dictionary<DateTime,decimal> ProfitSharingDictionary { get; set; }

        public StockInfo()
        {
            this.ProfitSharingDictionary = new Dictionary<DateTime, decimal>();
        }

        public decimal getProfitSharingInLastYear(int offset)
        {
            decimal totalProfitSharing = decimal.Zero;
            foreach(DateTime publishDate in ProfitSharingDictionary.Keys)
            {
                if(publishDate.CompareTo(DateTime.Today.AddYears(offset)) > 0 &&
                    publishDate.CompareTo(DateTime.Today.AddYears(offset+1)) < 0)
                {
                    totalProfitSharing += ProfitSharingDictionary[publishDate];
                }
            }

            return totalProfitSharing;
        }

        public void addProfitSharingInfo(DateTime publishDate, string profitSharingInfo)
        {
            decimal profitSharing = decimal.Zero;
            decimal.TryParse(profitSharingInfo, out profitSharing);

            if (this.ProfitSharingDictionary.ContainsKey(publishDate))
            {
                this.ProfitSharingDictionary[publishDate] += profitSharing;
            }
            else
            {
                this.ProfitSharingDictionary.Add(publishDate, profitSharing);
            }
        }

    }
}
