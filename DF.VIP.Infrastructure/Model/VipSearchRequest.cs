using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Model
{
    public class VipSearchRequest : JqGridSearchRequest
    {
        public VipSearchRequest(int page, int rows, string sidx, string sord, bool search,string phone):base(page,rows,sidx,sord,search)
        {
            this.Phone = phone;
        }
        public string Phone { get; set; }
    }
}
