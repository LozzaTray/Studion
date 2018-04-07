﻿using System.Web;
using System.Web.Optimization;

namespace Studion
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.dataTables.min.js")); // addition

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/moment.min.js",
                      "~/Scripts/bootstrap-sortable.js",
                      "~/Scripts/star-rating.js",
                      "~/Scripts/dataTables.bootstrap.min.js")); // addition

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/bootstrap-sortable.css",
                      "~/Content/site.css",
                      "~/Content/star-rating.css",
                      "~/Content/jquery.dataTables.min.css")); // addition

            //added star rating css and js files to bootstrap bundles
        }
    }
}
