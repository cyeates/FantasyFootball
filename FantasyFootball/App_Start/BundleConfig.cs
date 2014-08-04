using System.Web;
using System.Web.Optimization;

namespace FantasyFootball
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
     
      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
               ));

      bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
        "~/Scripts/jquery-{version}.js",
        "~/Scripts/bootstrap.js",
        "~/Scripts/respond.js",
        "~/Scripts/angular.js",
        "~/Scripts/angular-resource.js",
        "~/Scripts/kendo/2014.1.318/kendo.web.min.js",
        "~/Scripts/angular-kendo.js",
        "~/Scripts/app/*.js"
        ));



      bundles.Add(new StyleBundle("~/bundles/css")
              .Include("~/Content/css/bootstrap.css")
              .Include("~/Content/css/business-casual.css", new CssRewriteUrlTransform())
              .Include("~/Content/kendo/2014.1.318/kendo.common.min.css")
              .Include("~/Content/kendo/2014.1.318/kendo.black.min.css", new CssRewriteUrlTransform()));
    }
  }
}
