using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using OttomanStone.DataModel;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.Web.Services;
using iTextSharp.text.html.simpleparser;

namespace NewsPortal.Controls.Contents
{
    public partial class Contents : System.Web.UI.UserControl
    {
        OttomanStoneEntities idc = new OttomanStoneEntities();

        public string Sayfa, AltSayfa, EnAltSayfa, Icerik, dil;

        private void Page_Error(object sender, EventArgs e)
        {
            try
            {
                dil = Page.RouteData.Values["SayfaDili"].ToString();
            }
            catch
            {
                dil = "tr";
            }

            //Response.Redirect("/" + dil + "/hata-404");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Sayfa = Convert.ToString(Page.RouteData.Values["Sayfa"]);
            AltSayfa = Convert.ToString(Page.RouteData.Values["AltSayfa"]);
            EnAltSayfa = Convert.ToString(Page.RouteData.Values["EnAltSayfa"]);
            Icerik = Convert.ToString(Page.RouteData.Values["Icerik"]);

            //bool ok = checklink();
            //if (ok)
            //{
            int say = 0;
            if (Sayfa != "")
                say++;
            if (AltSayfa != "")
                say++;
            if (EnAltSayfa != "")
                say++;
            if (Icerik != "")
                say++;

            GetPage(say);
        }

        public bool checklink()
        {
            bool devam = true;
            string link = (from li in idc.contents
                           where li.Link == Sayfa
                           select li.Title).FirstOrDefault();
            if (link == null || link == "")
                devam = false;

            return devam;
        }

        public void GetPage(int deep)
        {
            switch (deep)
            {
                case 1:
                    {
                        GetValues(Sayfa);
                        break;
                    }
                case 2:
                    {
                        GetValues(AltSayfa);
                        break;
                    }
                case 3:
                    {
                        GetValues(EnAltSayfa);
                        break;
                    }
                case 4:
                    {
                        GetValues(Icerik);
                        break;
                    }
            }
        }

        public void GetValues(string link)
        {
            li_content.Text = "";

            int? cat_id = (from sa in idc.contents
                           where sa.Link == link
                           select sa.CatId).FirstOrDefault();

            var sayfalar = (from sa in idc.contents
                            where sa.CatId == cat_id && sa.Link == link
                            select sa).ToArray();

            if (sayfalar.Length > 0)
            {
                Page.Title = "Ottoman Stone  - " + sayfalar[0].Title;
                li_content.Text += HttpUtility.HtmlDecode(sayfalar[0].Contents);
            }
            else
            {
                Page.Title = "Ottoman Stone  - " + sayfalar[0].Title;
                sayfalar = (from sa in idc.contents
                            where sa.Link == link
                            select sa).ToArray();

                if (sayfalar.Length > 0)
                {
                    li_content.Text += HttpUtility.HtmlDecode(sayfalar[0].Contents);
                }
            }
        }
    }
}