using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Routing;

namespace PathologyWebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            //add customerHeader
            GlobalConfiguration.Configuration.Filters.Add(new AddCustomHeaderFilter());
        }
    }

    public class AddCustomHeaderFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //actionExecutedContext.Response.Headers.Add("customHeader", "custom value date time");
            actionExecutedContext.Response.Headers.Add("customHeader1", "Access-Control-Allow-Origin: http://localhost");
            actionExecutedContext.Response.Headers.Add("customHeader2", "Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS");
            actionExecutedContext.Response.Headers.Add("customHeader3", "Access-Control-Allow-Headers: X-Requested-With, Content-Type, Accept");
            //header('Access-Control-Allow-Origin: http://base.com');
            //header('Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS');
            //header('Access-Control-Allow-Headers: X-Requested-With, Content-Type, Accept')
        }
    }
}
