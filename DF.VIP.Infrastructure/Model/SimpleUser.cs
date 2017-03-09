using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Model
{
    public class SimpleUser
    {
        public SimpleUser()
        {
            this.Roles = new List<string>();
        }
        public string UserName { get; set; }
        public int UserID { get; set; }
        public List<string> Roles { get; set; }

     
    }
}
