
using DF.VIP.Infrastructure.Binder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DF.VIP.Infrastructure.Models
{
    [ModelBinder(typeof(JqGridSearchBinder))]
    public class JqGridSearchRequest
    {
 
        int page;
        int rows;
        string sidx ;
        string sord;
        bool _search;
        string phone;

        public JqGridSearchRequest(int page, int rows, string sidx, string sord, bool search,string phone)
        {
            this.page = page;
            this.rows = rows;
            this.sidx = sidx;
            this.sord = sord;
            this.Phone = phone;
            _search = search;
        }
        /// <summary>
        /// 第几页
        /// </summary>
        public int Page { get => page; set => page = value; }
        /// <summary>
        /// PageSie每页有多少条记录
        /// </summary>
        public int Rows { get => rows; set => rows = value; }
        public string Sidx { get => sidx; set => sidx = value; }
        public string Sord { get => sord; set => sord = value; }
        public bool Search { get => _search; set => _search = value; }

    

        public int SkipNum
        {
            get
            {
               return (Page - 1) * Rows;
            }
        }

        public string Phone { get => phone; set => phone = value; }
    }
}