

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class CostRecordMap : NopEntityTypeConfiguration<CostRecord>
    {
        public CostRecordMap()
        {
            this.ToTable("CostRecord");
       
            this.HasKey(o => o.ID).HasRequired(o => o.VIPMember).WithMany(o => o.CostRecords).HasForeignKey(o => o.VipID);
          
        }
    }
}
