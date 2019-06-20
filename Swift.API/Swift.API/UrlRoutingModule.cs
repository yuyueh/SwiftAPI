using System;
using System.Web;

namespace Swift.API
{
    public class UrlRoutingModule : IHttpModule
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Init(HttpApplication app)
        {
            app.PostResolveRequestCache += app_PostResolveRequestCache;
        }

        void app_PostResolveRequestCache(object sender, EventArgs e)
        {
            var app = (HttpApplication)sender;

            app.Context.RemapHandler(new HttpControllerHandler());
        }
    }
}
