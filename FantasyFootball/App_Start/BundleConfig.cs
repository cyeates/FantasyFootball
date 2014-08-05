using System.Web;
using System.Web.Optimization;

namespace FantasyFootball
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {

      bundles.Add(new Bundle("~/bundles/jquery", "//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js")
              .Include("~/Scripts/jquery-{version}.js"));

      bundles.UseCdn = true;

      bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
        "~/Scripts/angular.js",
        "~/Scripts/angular-resource.js",
        "~/Scripts/kendo/2014.1.318/kendo.core.min.js",
        "~/Scripts/kendo/2014.1.318/kendo.data.min.js",
        "~/Scripts/kendo/2014.1.318/kendo.pager.min.js",
        "~/Scripts/kendo/2014.1.318/kendo.tabstrip.min.js",
        "~/Scripts/kendo/2014.1.318/kendo.sortable.min.js",
        "~/Scripts/kendo/2014.1.318/kendo.grid.min.js",
        "~/Scripts/kendo/2014.1.318/kendo.validator.min.js",
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
