namespace DF.VIP.Infrastructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

 
    public partial class ProductUsage:BaseEntity
    {
        public int CompanyID { get; set; }

        public int ProductID { get; set; }

        public int VipID { get; set; }

        public int Quantity { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Company Company { get; set; }

        public virtual Product Product { get; set; }

        public virtual VIPMember VIPMember { get; set; }
    }
}
