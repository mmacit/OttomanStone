using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace catimajans
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            YonetimRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        void YonetimRoutes(RouteCollection routes)
        {
            routes.Ignore("Files/{*pathInfo}");
            routes.Ignore("Admin/{*pathInfo}");
            routes.Ignore("css/{*pathInfo}");
            routes.Ignore("js/{*pathInfo}");
            routes.Ignore("images/{*pathInfo}");
            routes.Ignore("{*allaxd}", new { allaxd = @".*\.axd(/.*)?" });

            routes.MapPageRoute("ka1", "kullanim-alanlari", "~/kullanim-alanlari.aspx", true);
            routes.MapPageRoute("ka", "kullanim-alanlari/{Item}", "~/kullanim-alanlari.aspx", true);
            routes.MapPageRoute("sv", "siparis-ver", "~/siparis-ver.aspx", true);

            routes.MapPageRoute("uu2", "urunler/{kategori}/{p}", "~/urunler.aspx", true); ;
            routes.MapPageRoute("uu1", "urunler/{p}", "~/urunler.aspx", true); ;
            routes.MapPageRoute("uu", "urunler", "~/urunler.aspx", true);

            routes.MapPageRoute("bl", "blog", "~/blog.aspx", true);
            routes.MapPageRoute("bl11", "blog/{kategori}/{p}", "~/blog.aspx", true);
            routes.MapPageRoute("bl1", "blog/{kategori}/{Id}/{Item}", "~/blog-detail.aspx", true);

            routes.MapPageRoute("icerik", "{Sayfa}", "~/page.aspx", true);
            routes.MapPageRoute("alt-icerik", "{Sayfa}/{AltSayfa}", "~/page.aspx", true);
            routes.MapPageRoute("en-alt-icerik", "{Sayfa}/{AltSayfa}/{EnAltSayfa}", "~/page.aspx", true);
            routes.MapPageRoute("link", "{Sayfa}/{AltSayfa}/{EnAltSayfa}/{Icerik}", "~/page.aspx", true);
        }
    }
}