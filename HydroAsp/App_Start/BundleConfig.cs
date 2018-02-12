using System.Web;
using System.Web.Optimization;

namespace HydroAsp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/otherjs").Include(
                        "~/Scripts/owl.carousel.js",
                        "~/Scripts/jquery.fitvids.js",
                        "~/Scripts/smoothscroll.js",
                        "~/Scripts/jquery.parallax-1.1.3.js",
                        "~/Scripts/jquery.prettyPhoto.js",
                        "~/Scripts/jjquery.ajaxchimp.min.js",
                        "~/Scripts/jquery.ajaxchimp.langs.js",
                        "~/Scripts/wow.min.js",
                        "~/Scripts/waypoints.min.js",
                        "~/Scripts/jquery.counterup.min.js",
                        "~/Scripts/script.js",
                        "~/Scripts/respond.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.theme.css",
                      "~/Content/Pe-icon-7-stroke.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/prettyPhoto.css",
                      "~/Content/style.css",
                      "~/Content/animate.css",
                      "~/Content/responsive.css",
                      "~/Content/site.css"));
        }
    }
}
