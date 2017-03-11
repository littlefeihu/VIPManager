using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.Infrastructure.Model;
using DF.VIP.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.VIP.Infrastructure.ExtensionMethod;
namespace DF.VIP.AppService.Resources
{
    public class ResourceService: IResourceService
    {
 
        IQueryRepository<RoleAuthority> roleAuthorityQ;
        public ResourceService(IQueryRepository<RoleAuthority> roleAuthorityQ)
        {
          
            this.roleAuthorityQ = roleAuthorityQ;
        }
         public List<NavigatorModel> GetAuthorisedNavigator(SimpleUser user)
        {
           
            var resources = this.roleAuthorityQ.Entities.Where(o=>o.IsActive).WhereIn(o => o.RoleID, user.Roles.Select(o => o.ID)).Select(o=>o.Resource).ToList();
           return  NavigatorModel.CreateNavigator(resources);
        }
    }
}
