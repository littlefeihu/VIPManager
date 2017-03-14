
namespace DF.VIP.Infrastructure.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        public virtual ICollection<LoginUser> LoginUsers { get; set; }
        public virtual ICollection<MsgTemplate> MsgTemplates { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PrePaid> PrePaids { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<ProductStock> ProductStocks { get; set; }

        public virtual ICollection<ProductUsage> ProductUsages { get; set; }

        public virtual ICollection<Setting> Settings { get; set; }

        public virtual ICollection<VIPLevel> VIPLevels { get; set; }

        public virtual ICollection<VIPMember> VIPMembers { get; set; }
    }
}
