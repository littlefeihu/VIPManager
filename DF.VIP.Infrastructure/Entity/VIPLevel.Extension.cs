using System.Collections.Generic;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class VIPLevel : BaseEntity
    {
        public virtual ICollection<VIPMember> VIPMembers { get; set; }

        public virtual Company Company { get; set; }
    }
}
