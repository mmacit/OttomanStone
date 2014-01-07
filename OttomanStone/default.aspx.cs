using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using OttomanStone.DataModel;

namespace OttomanStone
{
    public partial class _default : System.Web.UI.Page
    {
        OttomanStoneEntities os = new OttomanStoneEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUstSlider();
            Load4Item();
            Load8Item();
        }

        private void LoadUstSlider()
        {
            StringBuilder sb = new StringBuilder();
            List<Banner> br = (from b in os.Banner
                               where b.BannerAdi == "AnasayfaUstBanner"
                               select b).ToList();
            foreach (var item in br)
            {

                List<BannerReklam> ban = (from b in os.BannerReklam
                                          where b.BannerReklamBannerID == item.BannerAlanID
                                          select b).ToList();
                int say = 0;
                foreach (var items in ban)
                {

                    sb.Append("<li><img src=\"/files/images/banner/" + items.BannerReklamDeger + "\" alt=\"Ametist Cilt Hastalıklarına iyi gelir\" width=\"950\" height=\"420\" />");
                    sb.Append("<div class=\"html-caption\">");
                    sb.Append("<div class=\"caption-head\">" + items.BannerReklamBaslik + ".</div>");
                    sb.Append("<div class=\"text-capt\">");
                    sb.Append("<p>" + items.BannerReklamDetay + "</p>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</li>");
                }

            }
            lt_ust.Text = sb.ToString();
        }

        private void Load4Item()
        {
            StringBuilder sb = new StringBuilder();
            List<Banner> br = (from b in os.Banner
                               where b.BannerAdi == "Anasayfa4Item"
                               select b).ToList();
            foreach (var item in br)
            {

                List<BannerReklam> ban = (from b in os.BannerReklam
                                          where b.BannerReklamBannerID == item.BannerAlanID
                                          select b).ToList();

                foreach (var items in ban)
                {
                    sb.Append("<div class='textwidget one-fourth'>");
                    sb.Append("<div class='textwidget-photo'>");
                    sb.Append("<a class='photo highslide' href='/files/images/banner/" + items.BannerReklamDeger + "' onclick='return hs.expand(this, galleryOptions)'>");
                    sb.Append("<img alt='" + items.BannerReklamBaslik + "' src='/files/images/banner/" + items.BannerReklamDeger + "' width='215' height='122'><i style='opacity: 0; height: 122px;'></i></a>");
                    sb.Append("<a class='like'><span>Oda</span></a></div>");
                    sb.Append("<div class='info one-fourth'>");
                    sb.Append("<a class='head-capt'>" + items.BannerReklamBaslik + "</a>");
                    sb.Append("<p>" + items.BannerReklamDetay + "</p>");
                    sb.Append("</div></div>");
                }
            }

            lt_4item.Text = sb.ToString();
        }

        private void Load8Item()
        {
            StringBuilder sb = new StringBuilder();
            List<Banner> br = (from b in os.Banner
                               where b.BannerAdi == "Anasayfa8Item"
                               select b).ToList();


            foreach (var item in br)
            {

                List<BannerReklam> ban = (from b in os.BannerReklam
                                          where b.BannerReklamBannerID == item.BannerAlanID
                                          select b).ToList();


                int say = 0;
                int sayac = 1;
                foreach (var items in ban)
                {
                    if (say == 0)
                    {
                        sb.Append("<li>");
                    }

                    sb.Append("<div class='textwidget block_no_" + sayac + "'>");
                    sb.Append("<div class='textwidget-photo'>");
                    sb.Append("<a class='photo highslide' href='/files/images/banner/" + items.BannerReklamDeger + "' onclick='return hs.expand(this, galleryOptions)' >");
                    sb.Append("<img alt='" + items.BannerReklamBaslik + "' src='/files/images/banner/" + items.BannerReklamDeger + "' width='217' height='122'><i style='opacity: 0; height: 122px;'></i></a> <a class='like'><span></span></a></div></div>");
                    say++;

                    if (say == 2)
                    {
                        sb.Append("</li>");
                        say = 0;
                    }
                    sayac++;
                } lt_8item.Text = sb.ToString();

                sb.Clear();

                say = 0;
                sayac = 1;
                foreach (var items in ban)
                {
                    sb.Append("<div class='widget-info block_no_" + sayac + "' style='top: 2128px; left: 786.5px; width: 217px; display: none;'>");
                    sb.Append("<div class='textwidget-photo'>");
                    sb.Append("<a class='photo highslide' href='/files/images/banner/" + items.BannerReklamDeger + "' onclick='return hs.expand(this, galleryOptions)'><img alt='' src='/files/images/banner/" + items.BannerReklamDeger + "' width='217' height='122'><i style='opacity: 0; height: 122px;'></i></a> <a class='like'><span>02</span></a></div>");
                    sb.Append("<a href='' class='head'>" + items.BannerReklamBaslik + "</a>");
                    sb.Append("<p>" + items.BannerReklamDetay + "</p></div>");

                    sayac++;
                }
                lt_8item2.Text = sb.ToString();

            }


        }
    }
}