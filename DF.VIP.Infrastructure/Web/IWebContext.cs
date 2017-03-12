using DF.VIP.Infrastructure.Model;

namespace DF.VIP.Infrastructure.Web
{
    public interface IWebContext
    {
        SimpleUser CurrentUser { get; }
    }
}