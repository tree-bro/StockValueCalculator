using HtmlAgilityPack;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace StockValueCalculator
{
    public class Utils
    {
        public static HtmlAgilityPack.HtmlDocument loadHtmlDocument(string url, Encoding encoding)
        {
            HttpWebResponse response = (HttpWebResponse)WebRequest.CreateHttp(url).GetResponse();
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();

            using (StreamReader sr = new StreamReader(response.GetResponseStream(), encoding))
            {
                htmlDocument.Load(sr);
            }

            response.Close();

            return htmlDocument;
        }

        public static StockMarketTypes checkMarketType(string stockID)
        {
            Regex regexForChinaSZ = new Regex("^00[0-9]{4}$");
            Regex regexForChinaSH = new Regex("^60[0-9]{4}$");
            Regex regexForHK = new Regex("^0[0-9]{4}$");

            if (regexForChinaSZ.IsMatch(stockID))
            {
                return StockMarketTypes.CHINA_SZ_EXCHANGE_MARKET;
            }
            else if (regexForChinaSH.IsMatch(stockID))
            {
                return StockMarketTypes.CHINA_SH_EXCHANGE_MARKET;
            }
            else if (regexForHK.IsMatch(stockID))
            {
                return StockMarketTypes.HK_EXCHANGE_MARKET;
            }
            else
            {
                return StockMarketTypes.UNKNOWN;
            }
        }

        public static string[] readPreferStockIDList()
        {
            List<string> resultList = new List<string>();
            if (File.Exists("PreferStockList.csv"))
            {
                foreach (string line in File.ReadAllLines("PreferStockList.csv"))
                {
                    resultList.Add(line.Split(',')[0]);
                }
            }
            return resultList.ToArray();
        }

        public static HtmlNode findNodeByText(HtmlNode parentNode, string xpath, string compareValue, int offset)
        {
            int count = 0;
            bool foundMatch = false;
            foreach (HtmlNode subNode in parentNode.SelectNodes(xpath))
            {
                if (subNode.InnerText.Equals(compareValue, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    foundMatch = true;
                }
                if (foundMatch)
                {
                    if(count == offset)
                    {
                        return subNode;
                    }
                    else
                    {
                        count += 1;
                    }
                }
            }

            return null;
        }
    }
}
