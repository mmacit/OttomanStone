using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OttomanStone.DataModel;
using System.Text;

namespace Genar.Controls.Menu
{
    public partial class Menu : System.Web.UI.UserControl
    {
        public string sayfa, altsayfa, enaltsayfa, icerik;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                sayfa = Page.RouteData.Values["Sayfa"].ToString();
                altsayfa = Page.RouteData.Values["AltSayfa"].ToString();
                enaltsayfa = Page.RouteData.Values["EnAltSayfa"].ToString();
                icerik = Page.RouteData.Values["Icerik"].ToString();
            }
            catch (Exception)
            {

                if (sayfa == null)
                {
                    sayfa = Request.Url.ToString().Split('/')[Request.Url.ToString().Split('/').Length - 1];
                }

            }

            string sayfalink = Request.Url.ToString().Split('/')[0] + "/" + Request.Url.ToString().Split('/')[1] + "/" + Request.Url.ToString().Split('/')[2] + "/";

            OttomanStoneEntities ge = new OttomanStoneEntities();
            List<Kategoriler> kateogiler = (from ka in ge.Kategoriler
                                            where ka.OwnerID == 0 && ka.KategoriDurum == true
                                            orderby ka.KategoriSira ascending
                                            select ka).ToList();
            StringBuilder sb = new StringBuilder();
            int say = 0;
            foreach (var item in kateogiler)
            {
                string cls = "";
                string js = "";

                int icerik_sayi = ge.contents.Where(co => co.CatId == item.KategoriID).Count();
                int alt_kategori_sayi = ge.Kategoriler.Where(co => co.OwnerID == item.KategoriID).Count();

                string ok = "";
                if (icerik_sayi > 1 || alt_kategori_sayi > 0 || (alt_kategori_sayi > 0 && item.KategoriAdi_Kucuk == "urunler"))
                {
                    ok = "<span></span>";
                    js = " onClick='return false;' ";
                }

                sb.Append("<li><a "+ js +" href=\"" + sayfalink + item.KategoriAdi_Kucuk + "\">" + item.KategoriAdi + ok + "</a>");
                if (icerik_sayi > 1 && item.KategoriAdi_Kucuk != "urunler")
                {
                    List<content> iceriks = (from ic in ge.contents
                                             where ic.Yayin == 0
                                             && ic.CatId == item.KategoriID
                                             orderby ic.Queue ascending
                                             select ic).ToList();
                    sb.Append("<div><ul>");
                    foreach (var items in iceriks)
                    {
                        sb.Append("<li class='first'><a href='" + sayfalink + item.KategoriAdi_Kucuk + "/" + items.Link + "'>" + items.Title + "</a></li>");
                    }
                    sb.Append("</ul><i></i></div>");
                }

                if (alt_kategori_sayi > 0 || (alt_kategori_sayi > 0 && item.KategoriAdi_Kucuk == "urunler"))
                {
                    string p = "";

                    if (item.KategoriAdi_Kucuk == "urunler" || item.KategoriAdi_Kucuk == "blog")
                    {
                        p = "0";
                    }

                    List<Kategoriler> iceriks = (from ic in ge.Kategoriler
                                                 where ic.KategoriDurum == true
                                                 && ic.OwnerID == item.KategoriID
                                                 orderby ic.KategoriSira ascending
                                                 select ic).ToList();
                    sb.Append("<div><ul>");
                    foreach (var items in iceriks)
                    {
                        sb.Append("<li class='first'><a href='" + sayfalink + item.KategoriAdi_Kucuk + "/" + items.KategoriAdi_Kucuk + "/" + p + "'>" + items.KategoriAdi + "</a></li>");
                    }
                    sb.Append("</ul><i></i></div>");
                }
                sb.Append("</li>");
                say++;
            }
            li_menu.Text = sb.ToString();
        }
    }
}