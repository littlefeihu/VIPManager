using DF.VIP.AppService.Resources;
using DF.VIP.Infrastructure.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class VIPController : Controller
    {
        IResourceService resourceService;
        HttpContextBase httpContextBase;

        public VIPController(IResourceService resourceService, HttpContextBase httpContextBase)
        {
            this.resourceService = resourceService;
            this.httpContextBase = httpContextBase;
        }
        // GET: VIP
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Navigator()
        {
            var currentUser = this.httpContextBase.User as VipFormPrincipal;

            var navigatorModels = this.resourceService.GetAuthorisedNavigator(currentUser.UserData);

            return PartialView("_PartialNavigator", navigatorModels);
        }

    }
}