using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Configuration;
namespace SiteNavigation.Framework.Extension
{
    public static class HtmlExtension
    {
        private static string baseDic = ConfigurationManager.AppSettings["baseDic"]?? "/Content/";
        private static string isCompressionStr = ConfigurationManager.AppSettings["baseDic"] ?? "true";
        private static bool isCompression = false;
        private static string _version = "20160101";
        static HtmlExtension()
        {
            if(isCompressionStr == "true")
            {
                isCompression = true;
            }
        }
        public static string ImageInclude(this HtmlHelper html,string url)
        {
            return baseDic + url+"?"+ _version;
        }
        public static string StaticSource(this HtmlHelper html, string url)
        {
            return baseDic + url + "?" + _version; ;
        }

        public static string CssSource(this HtmlHelper html, string url)
        {
            if (isCompression)
            {
                return baseDic + "css/compression/" + url + "?" + _version; ;
            }
            else
            {
                return baseDic + "css/source/" + url + "?" + _version; ;
            }            
        }
        public static string JsSource(this HtmlHelper html, string url)
        {
            if (isCompression)
            {
                return baseDic + "Js/compression/" + url + "?" + _version; ;
            }
            else
            {
                return baseDic + "Js/source/" + url + "?" + _version; ;
            }
        }
    }
}
