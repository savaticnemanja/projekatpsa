using System.Web.Optimization;

namespace ProjekatPsa
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Content/layout.css",
                "~/Content/forms.css"
            ));
        }
    }
}
