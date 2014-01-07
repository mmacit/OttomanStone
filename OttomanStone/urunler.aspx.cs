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
    public partial class urunler : System.Web.UI.Page
    {
        OttomanStoneEntities os = new OttomanStoneEntities();

        public int p, her_sayfada_kac_item;
        public string sayfa_tipi, sayfalink;
        public string kategori, baslik;

        protected void Page_Load(object sender, EventArgs e)
        {
            sayfa_tipi = Convert.ToString(Request.QueryString["mod"]);

            try
            {
                p = Convert.ToInt32(Page.RouteData.Values["p"]);
            }
            catch { p = 0; }

            try
            {
                kategori = Convert.ToString(Page.RouteData.Values["kategori"]);
                p = Convert.ToInt32(Page.RouteData.Values["p"]);
                baslik = os.Kategoriler.FirstOrDefault(b => b.KategoriAdi_Kucuk == kategori).KategoriAciklama;
            }
            catch { kategori = ""; }

            her_sayfada_kac_item = 10;

            sayfalink = Request.Url.ToString().Split('/')[0] + "/" + Request.Url.ToString().Split('/')[1] + "/" + Request.Url.ToString().Split('/')[2];

            int katid = os.Kategoriler.FirstOrDefault(k => k.KategoriAdi_Kucuk == "urunler").KategoriID;

            if (kategori != "")
                katid = os.Kategoriler.FirstOrDefault(k => k.KategoriAdi_Kucuk == kategori).KategoriID;

            List<content> kats = (from ka in os.contents
                                  where ka.CatId == katid && ka.UrunSayfasi == true
                                  orderby ka.Id ascending
                                  select ka).Skip(p * her_sayfada_kac_item).Take(her_sayfada_kac_item).ToList();

            switch (sayfa_tipi)
            {
                case "yeni-urunler":
                    kats = (from ka in os.contents
                            where ka.OzellikYeniUrun == true && ka.OzellikOzelTasarimUrun == false && ka.CatId == katid && ka.UrunSayfasi == true
                            orderby ka.Id ascending
                            select ka).Skip(p * her_sayfada_kac_item).Take(her_sayfada_kac_item).ToList();
                    break;
                case "ozel-tasarim":
                    kats = (from ka in os.contents
                            where ka.OzellikOzelTasarimUrun == true && ka.OzellikYeniUrun == false && ka.CatId == katid && ka.UrunSayfasi == true
                            orderby ka.Id ascending
                            select ka).Skip(p * her_sayfada_kac_item).Take(her_sayfada_kac_item).ToList();
                    break;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in kats)
            {
                string resim = "";
                try
                {
                    resim = os.ContentImage.FirstOrDefault(ci => ci.ContentId == item.Id).ContentImage1;
                }
                catch { }

                string mod, tx;
                mod = ""; tx = "";

                if (item.OzellikYeniUrun == true)
                {
                    mod = "yeni"; tx = "YENİ";
                }

                if (item.OzellikUrunSatildi == true)
                {
                    mod = "satildi"; tx = "SATILDI";
                }

                sb.Append("<div class='textwidget-photo'>");
                sb.Append("<a class='photo highslide' href='/files/images/" + item.Id + "/" + resim + "' onclick='return hs.expand(this)'>");
                sb.Append("<img alt='" + item.Title + "' src=/files/images/" + item.Id + "/" + resim + "' width='337' height='202' /></a> <a class='" + mod + "'><span>" + tx + "</span></a></div>");
                sb.Append("<div class='info half'><h2><a href=''>" + item.Title + "</a> - " + item.UrunKodu + "</h2>");
                sb.Append(HttpUtility.HtmlDecode(item.Contents));
                sb.Append("<li>Fiyatlarımıza K.D.V. Dahil Değildir.</li>");
                sb.Append("<li>Bu Siparişinizi mağazadan Teslim almanızda %15 İndirim</li>");
                sb.Append("<li>Sipariş hattından Stok Sorunuz</li>");
                sb.Append("</ul><a title='' class='button' href='" + sayfalink + "/siparis-ver?uk=" + item.Id + "'><span>Sipariş Ver</span></a></div><div class='temizle'></div>");
            }
            lt_uruns.Text = sb.ToString();

            sb.Clear();
            int total_item = (from ka in os.contents
                              where ka.CatId == katid && ka.UrunSayfasi == true
                              orderby ka.Id ascending
                              select ka).Count();


            switch (sayfa_tipi)
            {
                case "yeni-urunler":
                    total_item = (from ka in os.contents
                                  where ka.OzellikOzelTasarimUrun == false && ka.OzellikYeniUrun == true && ka.CatId == katid && ka.UrunSayfasi == true
                                  select ka).ToList().Count();
                    break;
                case "ozel-tasarim":
                    total_item = (from ka in os.contents
                                  where ka.OzellikYeniUrun == false && ka.OzellikOzelTasarimUrun == true && ka.CatId == katid && ka.UrunSayfasi == true
                                  select ka).ToList().Count();
                    break;
            }

            int toplam_sayfa = total_item / her_sayfada_kac_item;

            if (toplam_sayfa % her_sayfada_kac_item != 0)
                toplam_sayfa++;

            for (int i = 0; i < toplam_sayfa; i++)
            {
                string aktif = "";
                string sayfa = "";

                if (i + 1 == p)
                    aktif = " class='act' ";

                if (sayfa_tipi != "" && sayfa_tipi != null)
                    sayfa = "?mod=" + sayfa_tipi;

                if (kategori != "")
                    sb.AppendLine("<li " + aktif + "><a href='" + sayfalink + "/urunler/" + kategori + "/" + i + sayfa + "' class='button' title='Amethyst-Ametist Doğal Taşlar'><span>" + (i + 1) + "</span></a></li>");
                else
                {
                    sb.AppendLine("<li " + aktif + "><a href='" + sayfalink + "/urunler/" + i + sayfa + "' class='button' title='Amethyst-Ametist Doğal Taşlar'><span>" + (i + 1) + "</span></a></li>");
                }
            }

            li_dots.Text = sb.ToString();
        }
    }
}