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
            LoginItem item = new LoginItem();
            return View(item);
        }
        [HttpPost]
        public ActionResult Signin(LoginItem item)
        {
            if (ModelState.IsValid)
            {
                if (!this.authenticationService.Login(item))
                {
                    ModelState.AddModelError("login", "登陆失败");
                }
            }
          return  RedirectToAction("Index", "VIP");
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
     
    }
}