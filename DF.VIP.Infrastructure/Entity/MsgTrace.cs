namespace DF.VIP.Infrastructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MsgTrace:BaseEntity
    {
        public int FromUserID { get; set; }

        public string ToVipID { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual LoginUser MsgFrom { get; set; }
    }
}
