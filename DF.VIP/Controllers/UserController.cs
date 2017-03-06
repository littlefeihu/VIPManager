using DF.VIP.AppService.Authentication;
using DF.VIP.AppService.Models;
using DF.VIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Controllers
{
    public class UserController : Controller
    {
        IAuthenticationService authenticationService;
        public UserController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }
        [HttpGet]
        public ActionResult Signin()
        {
            AccountItem item = new AccountItem();
            return View(item);
        }
        [HttpPost]
        public ActionResult Signin(AccountItem item)
        {
            if (ModelState.IsValid)
            {
                if (!this.authenticationService.Login(item.Login))
                {
                    ModelState.AddModelError("login", "登陆失败");
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Register(AccountItem item)
        {
            if (ModelState.IsValid)
            {
                this.authenticationService.Register(item.Register);
            }
            return RedirectToAction("Signin");
        }
        [HttpPost]
        public ActionResult ForgetPassword(AccountItem item)
        {
            if (ModelState.IsValid)
            {

            }
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