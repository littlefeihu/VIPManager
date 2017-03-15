using DF.VIP.AppService.Resources;
using DF.VIP.AppService.Vip;
using DF.VIP.Infrastructure.Authentication;
using DF.VIP.Infrastructure.Entity;
using DF.VIP.Infrastructure.Model;
using DF.VIP.Infrastructure.Models;
using DF.VIP.Infrastructure.Repository;
using DF.VIP.Infrastructure.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class VIPController : Controller
    {
        IResourceService resourceService;
        IVipService vipService;
        IWebContext webContext;
       

        public VIPController(IResourceService resourceService, IVipService vipService, IWebContext webContext)
        {
            this.resourceService = resourceService;
            this.vipService = vipService;
            this.webContext = webContext;
        }



        // GET: VIP
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VipList()
        {
            return View();
        }


        public JsonResult Members(JqGridSearchRequest searchRequest)
        {
            var model = this.vipService.SearchVipMembers(searchRequest, this.webContext.CurrentUser.Company.ID);

            return Json(model, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Detail(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("VipList");
            }
            var vip = this.vipService.GetVipDetail(id.Value);
            return View(vip);
        }

        public string Add(CreateVipRequest request)
        {
            request.CompanyID = this.webContext.CurrentUser.Company.ID;
            this.vipService.CreateVip(request);
            return "";
        }

        [ChildActionOnly]
        public ActionResult Navigator()
        {
            var navigatorModels = this.resourceService.GetAuthorisedNavigator(webContext.CurrentUser);

            return PartialView("_PartialNavigator", navigatorModels);
        }

    }
}