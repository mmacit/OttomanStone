using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OttomanStone.DataModel;
using System.Text;

namespace OttomanStone
{

    public partial class blog_detail : System.Web.UI.Page
    {
        public string baslik, yazi, resim;
        public int id;
        OttomanStoneEntities os = new OttomanStoneEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            string kategori = Page.RouteData.Values["kategori"].ToString();

            int katid_1 = os.Kategoriler.FirstOrDefault(ka => ka.KategoriAdi_Kucuk == "blog").KategoriID;

            string items = Page.RouteData.Values["item"].ToString();

            int katid = os.Kategoriler.FirstOrDefault(ka => ka.KategoriAdi_Kucuk == kategori && ka.OwnerID == katid_1).KategoriID;

            int katid_2 = os.contents.FirstOrDefault(ka => ka.Link == items && ka.CatId == katid).Id;

            id = int.Parse(Page.RouteData.Values["id"].ToString());

            content icerik = os.contents.FirstOrDefault(co => co.Id == id);

            baslik = icerik.Title;
            yazi = HttpUtility.HtmlDecode(icerik.Contents);

            ContentImage cimage = os.ContentImage.FirstOrDefault(co => co.ContentId == id);

            resim = cimage.ContentImage1;

            List<content> ilgili_yazi = (from iy in os.contents
                                         where iy.Yayin == 0
                                         && iy.CatId == katid
                                         orderby iy.Id descending
                                         select iy).ToList();
            StringBuilder sb = new StringBuilder();

            int say = 0;
            string sayfalink = Request.Url.ToString().Split('/')[0] + "/" + Request.Url.ToString().Split('/')[1] + "/" + Request.Url.ToString().Split('/')[2] + "/";

            foreach (var item in ilgili_yazi)
            {
                string ilk = "";
                if (say == 0)
                    ilk = "first";

                sb.Append("<div class=\"type-post " + ilk + "\"><a class=\"post-common\" href=\"" + sayfalink + "/blog/" + kategori + "/" + id + "/" + items + "\">" + item.Title + "</a></div>");

                say++;
            }

            lt_ilgiliyazi.Text = sb.ToString();
        }
    }
}