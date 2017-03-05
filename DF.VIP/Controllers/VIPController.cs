using DF.VIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Controllers
{
    public class VIPController : Controller
    {

        public VIPController()
        {

        }
        // GET: VIP
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Navigator()
        {
            IList<NavigatorModel> navigatorModels = new List<NavigatorModel>();

            return View("_PartialNavigator", navigatorModels);
        }
    }
}