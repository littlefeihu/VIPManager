
using DF.VIP.Infrastructure.Model;
using DF.VIP.Infrastructure.Models;
using DF.VIP.Infrastructure.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Infrastructure.Binder
{
    public class CreateVipRequestBinder : IModelBinder
    {

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var phone = controllerContext.HttpContext.Request["phone"];
            var nickname = controllerContext.HttpContext.Request["nickname"];
            var gender = controllerContext.HttpContext.Request["gender"]=="1";
            var level = int.Parse(controllerContext.HttpContext.Request["level"]);
            var month = controllerContext.HttpContext.Request["month"];
            var day = controllerContext.HttpContext.Request["day"];
            var remark = controllerContext.HttpContext.Request["remark"];


            return new CreateVipRequest { Phone=phone, Birthday=month+day, Gender=gender, Levelid=level, Nickname=nickname, Remark=remark };
        }
    }
}