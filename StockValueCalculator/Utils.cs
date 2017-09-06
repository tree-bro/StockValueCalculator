using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

            if (regexForChinaSZ.IsMatch(stockID))
            {
                return StockMarketTypes.CHINA_SZ_EXCHANGE_MARKET;
            }
            else if (regexForChinaSH.IsMatch(stockID))
            {
                return StockMarketTypes.CHINA_SH_EXCHANGE_MARKET;
            }
            else
            {
                return StockMarketTypes.UNKNOWN;
            }
        }
    }
}
