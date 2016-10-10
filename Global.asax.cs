using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WatermarkWebRole.Controllers;
using WatermarkWebRole.Models.Core.Utility.Logging;
//using System.Web.Http;
//using System.Threading;
//using WatermarkWebRole.Models.Core.Handlers;

namespace WatermarkWebRole
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Logger.Instance.Info("Application start.");
            AreaRegistration.RegisterAllAreas();
            //ThreadPool.SetMaxThreads(50, 50);
            //GlobalConfiguration.Configuration.MessageHandlers.Add(new BearerTokenHandler());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Logger.Instance.Info("Application end.");
        }
    }
}
