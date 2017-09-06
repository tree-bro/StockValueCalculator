using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockValueCalculator
{
    class URLTemplates
    {
        //public static string szseURLTemplateByID = @"http://www.szse.cn/szseWeb/ShowReport.szse?SHOWTYPE=xlsx&CATALOGID=1815_stock&txtDMorJC=[_STOCK_ID_]&txtBeginDate=[_BEGIN_DATE_]&txtEndDate=[_END_DATE_]&tab1PAGENO=1&ENCODE=1&TABKEY=tab1";
        public static string szseURLTemplateByID =
            @"http://www.szse.cn/szseWeb/ShowReport.szse?CATALOGID=1815_stock&txtDMorJC=[_STOCK_ID_]&txtBeginDate=[_BEGIN_DATE_]&txtEndDate=[_END_DATE_]&tab1PAGENO=1&ENCODE=1&TABKEY=tab1";

        public static string szseURLTemplateListAll =
            @"http://www.szse.cn/szseWeb/ShowReport.szse?CATALOGID=1815_stock&txtBeginDate=[_BEGIN_DATE_]&txtEndDate=[_END_DATE_]&tab1PAGENO=1&ENCODE=1&TABKEY=tab1";

        public static string sseURLTemplateByID =
            @"http://www.sse.com.cn/assortment/stock/list/info/turnover/index.shtml?COMPANY_CODE=[_STOCK_ID_]";

        public static string sseURLTemplateListAll =
            @"http://query.sse.com.cn/security/stock/downloadStockListFile.do?csrcCode=&stockCode=&areaName=&stockType=1";
    }
}
