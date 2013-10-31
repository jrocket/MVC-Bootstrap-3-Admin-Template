using System.Web;
using System.Web.Optimization;

namespace MvcAdminTemplate
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/bootstrap.js"
                     , "~/Scripts/js/twitter-bootstrap-hover-dropdown.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
    "~/Content/Theme/vendors/uniform/jquery.uniform.min.js"
    , "~/Content/Theme/vendors/chosen.jquery.min.js"
    , "~/Content/Theme/vendors/bootstrap-datepicker/js/bootstrap-datepicker.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/wysihtml5.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/core-b3.js"
    , "~/Content/Theme/vendors/twitter-bootstrap-wizard/jquery.bootstrap.wizard-for.bootstrap3.js"
    , "~/Content/Theme/vendors/boostrap3-typeahead/bootstrap3-typeahead.min.js"
    , "~/Content/Theme/vendors/easypiechart/jquery.easy-pie-chart.js"
    , "~/Content/Theme/vendors/ckeditor/ckeditor.js"
    , "~/Content/Theme/vendors/tinymce/js/tinymce/tinymce.min.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/wysihtml5.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/core-b3.js"
    , "~/Content/Theme/vendors/jGrowl/jquery.jgrowl.js"
    , "~/Content/Theme/vendors/bootstrap-datepicker/js/bootstrap-datepicker.js"

                   ));




            bundles.Add(new StyleBundle("~/Content/Theme").Include(
                      "~/Content/Theme/css/bootstrap.css",
                      "~/Content/Theme/css/bootstrap-theme.css",
                      "~/Content/Theme/css/bootstrap-admin-theme.css",
                       "~/Content/Theme/css/site.css"));

            bundles.Add(new StyleBundle("~/Content/Vendors").Include(
                "~/Content/Theme/vendors/bootstrap-datepicker/css/datepicker.css"
   , "~/Content/Theme/css/datepicker.fixes.css"
   , "~/Content/Theme/vendors/uniform/themes/default/css/uniform.default.min.css"
   , "~/Content/Theme/css/uniform.default.fixes.css"
   , "~/Content/Theme/vendors/chosen.min.css"
   , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/stylesheets/bootstrap-wysihtml5/core-b3.css"
   , "~/Content/Theme/vendors/easypiechart/jquery.easy-pie-chart.css"
   , "~/Content/Theme/vendors/easypiechart/jquery.easy-pie-chart_custom.css"
   , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/stylesheets/bootstrap-wysihtml5/core-b3.css"
   , "~/Content/Theme/vendors/jGrowl/jquery.jgrowl.css"
   , "~/Content/Theme/vendors/bootstrap-datepicker/css/datepicker.css"

   ));




        }
    }
}
