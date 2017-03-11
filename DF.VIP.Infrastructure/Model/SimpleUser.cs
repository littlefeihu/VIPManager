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
       
        public string Name { get; set; }
        public int ID { get; set; }
        public List<SimpleRole> Roles { get; set; }

       public static SimpleUser CreateUser(int userid,string username,List<SimpleRole> roles)
       {
            return new SimpleUser { ID=userid, Name=username, Roles=roles };
       }
    }

    public class SimpleRole
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public static SimpleRole CreateRole(int roleid, string rolename)
        {
            return new SimpleRole { ID = roleid, Name = rolename };
        }
    }
}
