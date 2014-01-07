using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using OttomanStone.DataModel;
using icebear_v2.Class;

namespace OttomanStone
{
    public partial class kullanim_alanlari : System.Web.UI.Page
    {
        OttomanStoneEntities os = new OttomanStoneEntities();
        public string pitem;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                pitem = Page.RouteData.Values["Item"].ToString();
            }
            catch
            {

            }

            LoadItems(pitem);
            LoadButtons();
        }

        private string CropContent(string deger, int uzunluk)
        {
            if (deger.Length > uzunluk)
            {
                deger = HttpUtility.HtmlDecode(deger);
                deger = Tools.StripHtml(deger);

                deger = deger.Substring(0, uzunluk) + "...";
            }
            return deger;
        }

        private string GetContentImage(int id)
        {
            string resim = "";

            try
            {
                resim = os.ContentImage.FirstOrDefault(ci => ci.ContentId == id).ContentImage1;
            }
            catch
            {

            }

            return resim;
        }

        private void LoadItems(string tm)
        {
            StringBuilder sb = new StringBuilder();
            List<Kategoriler> kats = new List<Kategoriler>();

            int katid = os.Kategoriler.FirstOrDefault(k => k.KategoriAdi_Kucuk == "kullanim-alanlari").KategoriID;

            if (tm == null || tm == "")
            {
                kats = (from ka in os.Kategoriler
                        where ka.OwnerID == katid
                        select ka).ToList();

                foreach (var item in kats)
                {

                    List<content> conts = (from co in os.contents
                                           where co.CatId == item.KategoriID
                                           select co).ToList();

                    sb.Append("<div><h3>" + item.KategoriAciklama + "</h3></div>");
                    foreach (var items in conts)
                    {
                        sb.Append("<div class='textwidget one-fourth'>");
                        sb.Append("<div class='textwidget-photo'>");
                        sb.Append("<a class='photo highslide' href='/files/images/" + items.Id + "/" + GetContentImage(items.Id) + "' onclick='return hs.expand(this, galleryOptions)'>");
                        sb.Append("<img alt='' src='/files/images/" + items.Id + "/_" + GetContentImage(items.Id) + "' width='215' height='122' /></a>");
                        sb.Append("<a class='like'><span>03</span></a></div>");
                        sb.Append("<div class='info one-fourth'>");
                        sb.Append("<a class='head-capt'>" + items.Title + "</a>");
                        sb.Append("<p>" + CropContent(items.Contents, 200) + "</p></div></div>");
                    }

                }
            }
            else
            {
                katid = os.Kategoriler.FirstOrDefault(k => k.KategoriAdi_Kucuk == tm).KategoriID;
                string kaciklama = os.Kategoriler.FirstOrDefault(k => k.KategoriAdi_Kucuk == tm).KategoriAciklama;

                List<content> conts = (from co in os.contents
                                       where co.CatId == katid
                                       select co).ToList();
                sb.Append("<div><h3>" + kaciklama + "</h3></div>");
                foreach (var items in conts)
                {
                    sb.Append("<div class='textwidget one-fourth'>");
                    sb.Append("<div class='textwidget-photo'>");
                    sb.Append("<a class='photo highslide' href='/files/images/" + items.Id + "/" + GetContentImage(items.Id) + "' onclick='return hs.expand(this, galleryOptions)'>");
                    sb.Append("<img alt='' src='/files/images/" + items.Id + "/" + GetContentImage(items.Id) + "' width='215' height='122' /></a>");
                    sb.Append("<a class='like'><span>03</span></a></div>");
                    sb.Append("<div class='info one-fourth'>");
                    sb.Append("<a class='head-capt'>" + items.Title + "</a>");
                    sb.Append("<p>" + CropContent(items.Contents, 200) + "</p></div></div>");
                }

            }

            lt_kalan.Text = sb.ToString();
        }

        private void LoadButtons()
        {
            string sayfalink = Request.Url.ToString().Split('/')[0] + "/" + Request.Url.ToString().Split('/')[1] + "/" + Request.Url.ToString().Split('/')[2] + "/";

            int katid = os.Kategoriler.FirstOrDefault(k => k.KategoriAdi_Kucuk == "kullanim-alanlari").KategoriID;

            List<Kategoriler> kats = (from ka in os.Kategoriler
                                      where ka.OwnerID == katid
                                      select ka).ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var item in kats)
            {
                sb.AppendLine("<a class='button' href='" + sayfalink + "kullanim-alanlari/" + item.KategoriAdi_Kucuk + "'><span>" + item.KategoriAdi + "</span></a>");
            }
            lt_buttons.Text = sb.ToString();
        }
    }
}