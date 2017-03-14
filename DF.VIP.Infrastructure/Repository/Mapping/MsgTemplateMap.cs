

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class MsgTemplateMap : NopEntityTypeConfiguration<MsgTemplate>
    {
        public MsgTemplateMap()
        {
            this.ToTable("MsgTemplate");
            this.HasRequired(o => o.Company).WithMany(o => o.MsgTemplates).HasForeignKey(o => o.CompanyID);
        }
    }
}
