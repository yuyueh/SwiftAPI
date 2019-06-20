using System.Web;

namespace Swift.API
{
    public class HttpControllerHandler  : IHttpHandler
    {
        public bool IsReusable
        { 
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Hello World!");
        }
    }
}
