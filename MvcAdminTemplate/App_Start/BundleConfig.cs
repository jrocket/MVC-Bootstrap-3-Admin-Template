using System.Web;
using System.Web.Optimization;

namespace MvcAdminTemplate
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js"
                   , "~/Scripts/twitter-bootstrap-hover-dropdown.js"
                    ));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Theme/base/css").Include(
                        "~/Content/Theme/base/jquery.ui.core.css",
                        "~/Content/Theme/base/jquery.ui.resizable.css",
                        "~/Content/Theme/base/jquery.ui.selectable.css",
                        "~/Content/Theme/base/jquery.ui.accordion.css",
                        "~/Content/Theme/base/jquery.ui.autocomplete.css",
                        "~/Content/Theme/base/jquery.ui.button.css",
                        "~/Content/Theme/base/jquery.ui.dialog.css",
                        "~/Content/Theme/base/jquery.ui.slider.css",
                        "~/Content/Theme/base/jquery.ui.tabs.css",
                        "~/Content/Theme/base/jquery.ui.datepicker.css",
                        "~/Content/Theme/base/jquery.ui.progressbar.css",
                        "~/Content/Theme/base/jquery.ui.theme.css"));



              bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
    "~/Content/Theme/vendors/uniform/jquery.uniform.js"
    , "~/Content/Theme/vendors/chosen.jquery.js"
    , "~/Content/Theme/vendors/bootstrap-datepicker/js/bootstrap-datepicker.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/wysihtml5.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/core-b3.js"
    , "~/Content/Theme/vendors/twitter-bootstrap-wizard/jquery.bootstrap.wizard-for.bootstrap3.js"
    , "~/Content/Theme/vendors/boostrap3-typeahead/bootstrap3-typeahead.js"
    , "~/Content/Theme/vendors/easypiechart/jquery.easy-pie-chart.js"
    , "~/Content/Theme/vendors/ckeditor/ckeditor.js"
    , "~/Content/Theme/vendors/tinymce/js/tinymce/tinymce.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/wysihtml5.js"
    , "~/Content/Theme/vendors/bootstrap-wysihtml5-rails-b3/vendor/assets/javascripts/bootstrap-wysihtml5/core-b3.js"
    , "~/Content/Theme/vendors/jGrowl/jquery.jgrowl.js"
    , "~/Content/Theme/vendors/bootstrap-datepicker/js/bootstrap-datepicker.js"
    , "~/Content/Theme/vendors/sparkline/jquery.sparkline.js"
    , "~/Content/Theme/vendors/tablesorter/js/jquery.tablesorter.js"
    , "~/Content/Theme/vendors/flot/jquery.flot.js"
    , "~/Content/Theme/vendors/flot/jquery.flot.selection.js"
    , "~/Content/Theme/vendors/flot/jquery.flot.resize.js"
    , "~/Content/Theme/vendors/fullcalendar/fullcalendar.js"
                   ));



            bundles.Add(new StyleBundle("~/Content/Theme").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
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
    , "~/Content/Theme/vendors/fullcalendar/fullcalendar.css"));


        }
    }
}