
using DF.VIP.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Infrastructure.Binder
{
    public class JqGridSearchBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var page = controllerContext.HttpContext.Request["page"];
            var rows = controllerContext.HttpContext.Request["rows"];
            var sidx = controllerContext.HttpContext.Request["sidx"];
            var sord = controllerContext.HttpContext.Request["sord"];
            var _search = controllerContext.HttpContext.Request["_search"];
            var phone = controllerContext.HttpContext.Request["phone"];
            return new JqGridSearchRequest (int.Parse(page),int.Parse(rows),sidx,sord,bool.Parse(_search),phone);
        }
    }
}