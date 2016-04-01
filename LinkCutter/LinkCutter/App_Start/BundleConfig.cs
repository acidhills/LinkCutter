using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace LinkCutter.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jQuery").Include("~/Scripts/jquery-1.*"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/angular/angular.js")
                                                             .IncludeDirectory("~/Scripts/angular", "*.js")
                                                             .Include("~/Scripts/angular/application/app.js")
                                                             .IncludeDirectory("~/Scripts/angular/application", "*.js",true));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap*"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/*.css"));
        }

    }
}