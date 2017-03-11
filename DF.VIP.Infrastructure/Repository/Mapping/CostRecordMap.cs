using DF.VIP.Infrastructure.Entity.VipUser;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class CostRecordMap : NopEntityTypeConfiguration<CostRecord>
    {
        public CostRecordMap()
        {
            this.ToTable("CostRecord");

            this.HasKey(o => o.ID).HasRequired(o => o.VipMember).WithMany(o => o.CostRecords).HasForeignKey(o => o.VipID);

            this.HasRequired(o => o.CostType).WithMany(o => o.CostRecords).HasForeignKey(o => o.CostTypeID);
        }
    }
}
