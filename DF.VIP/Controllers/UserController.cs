using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Controllers
{
    public class UserController : Controller
    {
        // GET: Account
        public ActionResult Signin()
        {
            return View();
        }
    }
}