﻿using System.Web.Optimization;

namespace PaginationTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://code.jquery.com/jquery-2.2.4.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryTableSorter", "https://cdnjs.cloudflare.com/ajax/libs/jquery.tablesorter/2.27.6/js/jquery.tablesorter.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryTableSorterWidgets", "https://cdnjs.cloudflare.com/ajax/libs/jquery.tablesorter/2.27.6/js/jquery.tablesorter.widgets.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryUI", "https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.0/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/jqueryUI", "https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.0/jquery-ui.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}