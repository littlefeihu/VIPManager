using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DF.VIP.Infrastructure
{
    public interface IWebHelper
    {
        bool IsStaticResource(HttpRequest request);
    }
    public class WebHelper : IWebHelper
    {
        private readonly string[] _staticFileExtensions;

        public WebHelper()
        {
            this._staticFileExtensions = new[] { ".axd", ".ashx", ".bmp", ".css", ".gif", ".htm", ".html", ".ico", ".jpeg", ".jpg", ".js", ".png", ".rar", ".zip" };
        }

        public virtual bool IsStaticResource(HttpRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            string path = request.Path;
            string extension = VirtualPathUtility.GetExtension(path);

            if (extension == null) return false;

            return _staticFileExtensions.Contains(extension);
        }
    }

}
