#pragma warning disable 1591
using System.Web.Optimization;

namespace WidgetTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/template").Include(
                "~/Scripts/jquery.themepunch.tools.min.js",
                "~/Scripts/jquery.themepunch.revolution.min.js",
                "~/Scripts/masonry.pkgd.min.js",
                "~/Scripts/imagesloaded.pkgd.min.js",
                "~/Scripts/jquery.cycle.all.js",
                "~/Scripts/jquery.flot.min.js",
                "~/Scripts/jquery.flot.resize.min.js",
                "~/Scripts/jquery.countTo.js",
                "~/Scripts/waypoints.min.js",
                "~/Scripts/jquery.prettyPhoto.js",
                "~/Scripts/respond.min.js",
                "~/Scripts/html5shiv.js",
                "~/Scripts/custom.js",
                "~/Scripts/jquery.themepunch.*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/template").Include(
                "~/Content/animate.min.css",
                "~/Content/settings.css",
                "~/Content/prettyPhoto.css",
                "~/Content/font-awesome.min.css",
                "~/Content/style.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css"));
        }
    }
}
