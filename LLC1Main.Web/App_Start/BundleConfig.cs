using System;
using System.Web.Optimization;
using System.Web.SessionState;

namespace LLC1Main.Web.App_Start
{
     public static class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               //Bootstrap style
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Vendor/css/bootstrap.min.css", new CssRewriteUrlTransform()));

               //Material Icon
               bundles.Add(new StyleBundle("~/bundles/materialdesignicons/css").Include("~/Vendor/css/materialdesignicons.min.css", new CssRewriteUrlTransform()));

               //pe-icon-7 Icon
               bundles.Add(new StyleBundle("~/bundles/peicon7stroke/css").Include("~/Vendor/css/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

               //Custom  css
               bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Vendor/css/style.css", new CssRewriteUrlTransform()));

               //Content Site
               bundles.Add(new StyleBundle("~/bundles/site/css").Include("~/Content/Site.css", new CssRewriteUrlTransform()));

               //Scripts
               bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include("~/Vendor/js/jquery.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Vendor/js/bootstrap.bundle.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jqueryeasing/js").Include("~/Vendor/js/jquery.easing.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/scrollspy/js").Include("~/Vendor/js/scrollspy.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/counter/js").Include("~/Vendor/js/counter.init.js"));
               bundles.Add(new ScriptBundle("~/bundles/app/js").Include("~/Vendor/js/app.js"));

          }
     }
}