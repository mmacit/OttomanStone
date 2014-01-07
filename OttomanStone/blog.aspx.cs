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
    public partial class blog : System.Web.UI.Page
    {
        OttomanStoneEntities os = new OttomanStoneEntities();

        public int p, her_sayfada_kac_item, total_sayfa;
        public string ilk_sayfa, son_sayfa, simdiki_sayfa, sonraki_sayfa, onceki_sayfa;

        protected void Page_Load(object sender, EventArgs e)
        {
            string sayfa = Tools.SaltPageLink();
            try
            {
                p = int.Parse(Page.RouteData.Values["p"].ToString());
            }
            catch
            {
                p = 0;
            }

            her_sayfada_kac_item = 10;

            string kategori = Convert.ToString(Page.RouteData.Values["kategori"]);
            int blogk = os.Kategoriler.FirstOrDefault(ka => ka.KategoriAdi_Kucuk == "blog").KategoriID;

            if (kategori != "" & kategori != null)
            {
                int katid = os.Kategoriler.FirstOrDefault(ka => ka.KategoriAdi_Kucuk == kategori && ka.OwnerID == blogk).KategoriID;

                var blog_list = (from cl in os.contents
                                 join bl in os.ContentImage on cl.Id equals bl.ContentId
                                 where cl.Yayin == 0 && cl.CatId == katid
                                 orderby cl.Id descending
                                 select new
                                 {
                                     cl.Id,
                                     cl.Link,
                                     cl.Title,
                                     cl.Contents,
                                     bl.ContentId,
                                     bl.ContentImage1
                                 }).Skip(p * her_sayfada_kac_item)
                                 .Take(her_sayfada_kac_item)
                                 .ToList();

                StringBuilder sb = new StringBuilder();
                foreach (var item in blog_list)
                {
                    sb.AppendLine("<div class='item-blog'>");
                    sb.AppendLine("<h2><a href='/blog/" + kategori + "/" + item.Id + "/" + item.Link + "'>" + item.Title + "</a></h2>");
                    sb.AppendLine("<a class='alignleft text photo highslide' href='/files/images/" + item.ContentId + "/" + item.ContentImage1 + "' onclick='return hs.expand(this, galleryOptions)'>");
                    sb.AppendLine("<img alt='" + item.Title + "' src='/files/images/" + item.ContentId + "/" + item.ContentImage1 + "' height='202' /></a>");
                    sb.AppendLine("<p>" + CropContent(item.Contents, 800) + "</p>");
                    sb.AppendLine("<a href='/blog/" + kategori + "/" + item.Id + "/" + item.Link + "' class='button' title='" + item.Title + "'><span><i class='more'></i>Detaylar</span></a></div>");
                }

                lt_bloglist.Text = sb.ToString();

                sb.Clear();

                simdiki_sayfa = (p + 1).ToString();

                total_sayfa = blog_list.Count;
                int sayfa_sayisi = total_sayfa / her_sayfada_kac_item;

                if (sayfa_sayisi % her_sayfada_kac_item != 0)
                    sayfa_sayisi++;

                son_sayfa = sayfa + "/blog/" + kategori + "/" + sayfa_sayisi;
                ilk_sayfa = sayfa + "/blog/" + kategori + "/0";

                if (p < sayfa_sayisi)
                    sonraki_sayfa = sayfa + "/blog/" + kategori + "/" + (p + 1);
                else
                    sonraki_sayfa = sayfa + "/blog/" + kategori + "/" + son_sayfa;

                if (p > 0)
                    onceki_sayfa = sayfa + "/blog/" + kategori + "/" + (p - 1);
                else
                    onceki_sayfa = sayfa + "/blog/" + kategori + "/0";

                if (sayfa_sayisi == 0)
                    paging.Visible = false;
            }
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
    }
}