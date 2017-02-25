using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteNavigation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Test()
        {
            return null;
        }
        public ActionResult KaoLa()
        {
            string url = "http://m.kaola.com/activity/h5/20960.shtml?from=appshare&isWechatBiz=1&sharer=fAroIEnpY+PMzDpxlFJ3iIr359kyMQAbHh7dT9AMSzXEcXMQMmXVFtXpfg0NFhP+cTD36FxU4TaMnnF7Vj7jXQ==#wechatBiz";
            return Redirect(url);
        }
    }
}