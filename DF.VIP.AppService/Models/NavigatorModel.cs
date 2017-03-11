using DF.VIP.Infrastructure.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DF.VIP.AppService.Models
{
    public class NavigatorModel
    {
        public NavigatorModel()
        {
            Children = new List<NavigatorModel>();
        }

        public string Href { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public int Order { get; set; }

        public List<NavigatorModel> Children { get; set; }


        public static List<NavigatorModel> CreateNavigator(List<Resource> resources)
        {
           var firstLevelResources=resources.Where(o => o.ParentID == 0);
            List<NavigatorModel> models = new List<NavigatorModel>();
            foreach (var firstLevelResource in firstLevelResources)
            {
                var model = new NavigatorModel { Href = firstLevelResource.ResourceValue, Icon = firstLevelResource.Icon, Order = firstLevelResource.DisplayOrder, Title = firstLevelResource.ResourceName };

                models.Add(model);

                var children = resources.FindAll(o => o.ParentID == firstLevelResource.ID);
                if(children!=null)
                {
                    foreach (var child in children)
                    {
                        model.Children.Add(new NavigatorModel { Href = child.ResourceValue, Icon = child.Icon, Order = child.DisplayOrder, Title = child.ResourceName });
                    }
                }
            }
            return models;
        }

    }
}