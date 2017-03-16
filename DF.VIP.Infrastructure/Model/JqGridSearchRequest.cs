
using DF.VIP.Infrastructure.Binder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Infrastructure.Model
{
    [ModelBinder(typeof(JqGridSearchBinder))]
    public class JqGridSearchRequest
    {

        public JqGridSearchRequest(int page, int rows, string sidx, string sord, bool search)
        {
            this.Page = page;
            this.Rows = rows;
            this.Sidx = sidx;
            this.Sord = sord;
            this.Search = search;
        }
        /// <summary>
        /// 第几页
        /// </summary>
        public int Page { get;set; }
        /// <summary>
        /// PageSie每页有多少条记录
        /// </summary>
        public int Rows { get;set; }
        public string Sidx { get;set; }
        public string Sord { get;set; }
        public bool Search { get;set; }

    

        public int SkipNum
        {
            get
            {
               return (Page - 1) * Rows;
            }
        }
    }
}