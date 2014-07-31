using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FantasyFootball
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      UnityConfig.RegisterComponents();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      var formatters = GlobalConfiguration.Configuration.Formatters;
      var jsonFormatter = formatters.JsonFormatter;
      var settings = jsonFormatter.SerializerSettings;
      settings.Formatting = Formatting.Indented;
      settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    }
  }
}
