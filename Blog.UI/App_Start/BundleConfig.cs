using System;
using System.Web;
using System.Web.Optimization;

namespace Blog.UI.App_Start
{
    public class BundleConfig
    {
        //Bundle Config 
        // Projedeki script ve css dosyalarını tek dosya olarak göstermeyi sağlar
        // (güvenlik,dosyalar tek bir dosya halinde olduğu için daha çabuk yüklenir) 
        public static void RegisterBundles(BundleCollection bundles)
        {

            //1) Css Dosyaları "~/bundles/css" adı ile çağrılacktır 
            bundles.Add(new StyleBundle("~/bundles/StyleCss").Include(
                  "~/Content/UI/css/style.css")
            );

            bundles.Add(new ScriptBundle("~/bundles/CssTheme").Include(
              "~/Content/UI/css/theme-responsive.css"));

            //1) Javascript Dosyaları "~/bundles/js" adı ile çağrılacktır 
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                   "~/Content/UI/js/jquery.js",
                   "~/Content/UI/js/jquery.js",
                   "~/Content/UI/js/nav/tinynav.js",
                   "~/Content/UI/js/nav/superfish.js",
                   "~/Content/UI/js/nav/hoverIntent.js",
                   "~/Content/UI/js/nav/jquery.sticky.js",
                   "~/Content/UI/js/totop/jquery.ui.totop.js",
                   "~/Content/UI/js/rs-plugin/js/jquery.themepunch.tools.min.js",
                   "~/Content/UI/js/rs-plugin/js/jquery.themepunch.revolution.min.js",
                   "~/Content/UI/js/fancybox/jquery.fancybox.js",
                   "~/Content/UI/js/carousel/carousel.js",
                   "~/Content/UI/js/twitter/jquery.tweet.js",
                   "~/Content/UI/js/flickr/jflickrfeed.min.js",
                   "~/Content/UI/js/scrollbar/jquery.mCustomScrollbar.concat.min.js",
                   "~/Content/UI/js/maps/gmap3.js",
                   "~/Content/UI/js/filters/jquery.isotope.js",
                   "~/Content/UI/js/parallax/jquery.inview.js",
                   "~/Content/UI/js/parallax/nbw-parallax.js",
                   "~/Content/UI/js/theme-options/theme-options.js",
                   "~/Content/UI/js/theme-options/jquery.cookies.js",
                   "~/Content/UI/js/bootstrap/bootstrap.js",
                   "~/Content/UI/js/main.js"
                ));



        }
    }

  
}