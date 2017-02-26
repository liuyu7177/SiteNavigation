using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SiteNavigation.Code
{
    public class SiteNavigationObject
    {
        private static string baseDic = ConfigurationManager.AppSettings["DomainName"];

        public static int StatisticalCode()
        {
            switch (baseDic)
            {
                case "jmkaola":
                    return 1;
                case "zuori":
                    return 2;
                default: break;
            }
            return 0;
        }
    }
}