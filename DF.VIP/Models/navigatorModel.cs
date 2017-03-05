using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DF.VIP.Models
{
    public class NavigatorModel
    {
        public string Href { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public Int16 Order { get; set; }

        public List<NavigatorModel> Children { get; set; }

    }
}