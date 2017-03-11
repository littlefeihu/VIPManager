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
    public class UserController : Controller
    {
        IAuthenticationService authenticationService;
        private readonly HttpContextBase httpContext;
        public UserController(IAuthenticationService authenticationService, HttpContextBase httpContext)
        {
            this.authenticationService = authenticationService;
            this.httpContext = httpContext;
        }
        [HttpGet]
        public ActionResult Signin()
        {
            LoginItem item = new LoginItem();
            return View(item);
        }
        [HttpPost]
        public ActionResult Signin(LoginItem item)
        {
            if (ModelState.IsValid)
            {
                var userRoles = this.authenticationService.Login(item);
                if (userRoles == null)
                {
                    ModelState.AddModelError("login", "登陆失败");
                    return View();
                }
            }
            return RedirectToAction("Index", "VIP");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View(new RegisterItem());
        }
        [HttpPost]
        public ActionResult Register(RegisterItem item)
        {
            if (ModelState.IsValid)
            {
                if (item.Password1 != item.Password2)
                {
                    ModelState.AddModelError("password confirm", "两次输入密码不一致");
                }
                try
                {
                    this.authenticationService.Register(item);
                    return RedirectToAction("Signin");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("register error", "注册过程发生错误");
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult ForgetPassword()
        {
            return View(new ForgetPasswordItem());
        }
        [HttpPost]
        public ActionResult ForgetPassword(ForgetPasswordItem item)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        public ActionResult SignOut()
        {
          
            this.authenticationService.SignOut();
            return RedirectToAction("Signin");
        }
    }
}