

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class MsgTraceMap : NopEntityTypeConfiguration<MsgTrace>
    {
        public MsgTraceMap()
        {
            this.ToTable("MsgTrace");
            this.HasRequired(o => o.MsgFrom).WithMany(o => o.MsgTraces).HasForeignKey(o => o.FromUserID);

        }
    }
}
