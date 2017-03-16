using DF.VIP.AppService.Authentication;
using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure;
using DF.VIP.Infrastructure.Authentication;
using DF.VIP.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DF.VIP.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        IAuthenticationService authenticationService;
        private readonly HttpContextBase httpContext;
        public AdminController(IAuthenticationService authenticationService, HttpContextBase httpContext)
        {
            this.authenticationService = authenticationService;
            this.httpContext = httpContext;
        }
        [HttpGet]
        public ActionResult Company()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCompany()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser()
        {
            return View();
        }
     
    }
}