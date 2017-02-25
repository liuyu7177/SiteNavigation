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
        public static string ImageInclude(this HtmlHelper html,string url)
        {
            return baseDic + url;
        }
    }
}
