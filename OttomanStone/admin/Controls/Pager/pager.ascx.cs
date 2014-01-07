using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using OttomanStone.DataModel;

namespace icebear_v2.Admin.Controls.Pager
{

    public partial class pager : System.Web.UI.UserControl
    {
        OttomanStoneEntities idc = new OttomanStoneEntities();

        public string sayfa;
        public string _sayfa
        {
            get { return sayfa; }
            set { sayfa = value; }
        }

        public string count;
        public string _count
        {
            get { return count; }
            set { count = value; }
        }

        public int? sub_id;
        public int? _sub_id
        {
            get { return sub_id; }
            set { sub_id = value; }
        }

        public string p, clas, mode, id, h, by, field;

        protected void Page_Load(object sender, EventArgs e)
        {

            mode = Convert.ToString(Request.QueryString["mode"]);
            id = Convert.ToString(Request.QueryString["id"]);
            p = Convert.ToString(Request.QueryString["p"]);
            h = Convert.ToString(Request.QueryString["h"]);
            by = Convert.ToString(Request.QueryString["by"]);
            field = Convert.ToString(Request.QueryString["field"]);

            if (p == null)
                p = "1";

            string link = Request.Url.AbsolutePath + "?";
            if (mode != null)
                link += "mode=" + mode + "&";
            if (id != null)
                link += "id=" + id + "&";
            if (h != null)
                link += "h=" + h + "&";
            if (by != null)
                link += "by=" + by + "&";
            if (field != null)
                link += "field=" + field + "&";

            StringBuilder sb = new StringBuilder();
            sb.Append("<div id='dv_geri' class='page' style='background-color:#434750;'>Geri</div><div class='dv_page'><div class='dv_inner'>");
            switch (sayfa)
            {
                case "banner":
                    {
                        var siparis_Sayisi = (from si in idc.Banner
                                              select si).ToArray();
                        int sayfalar = siparis_Sayisi.Length / int.Parse(count);
                        if (siparis_Sayisi.Length % int.Parse(count) != 0)
                        {
                            sayfalar++;
                        }
                        if (sayfalar > 1)
                        {
                            for (int i = 0; i < sayfalar; i++)
                            {
                                if ((i + 1).ToString() == p)
                                    clas = "page_hover";
                                else
                                    clas = "page";

                                sb.Append("<a href='" + link + "p=" + (i + 1) + "'><div class='" + clas + "'>" + (i + 1) + "</div></a>");
                            }
                        }
                        else
                        {
                            lt_pager.Visible = false;
                        }
                        break;
                    }
                case "banner_sub":
                    {
                        var siparis_Sayisi = (from si in idc.BannerReklam
                                              where si.BannerReklamBannerID == sub_id
                                              select si).ToArray();
                        int sayfalar = siparis_Sayisi.Length / int.Parse(count);
                        if (siparis_Sayisi.Length % int.Parse(count) != 0)
                        {
                            sayfalar++;
                        }
                        if (sayfalar > 1)
                        {
                            for (int i = 0; i < sayfalar; i++)
                            {
                                if ((i + 1).ToString() == p)
                                    clas = "page_hover";
                                else
                                    clas = "page";

                                sb.Append("<a href='" + link + "p=" + (i + 1) + "'><div class='" + clas + "'>" + (i + 1) + "</div></a>");
                            }
                        }
                        else
                        {
                            lt_pager.Visible = false;
                        }
                        break;
                    }
                case "kategoriler":
                    {
                        var siparis_Sayisi = (from si in idc.Kategoriler
                                              select si).ToArray();
                        int sayfalar = siparis_Sayisi.Length / int.Parse(count);
                        if (siparis_Sayisi.Length % int.Parse(count) != 0)
                        {
                            sayfalar++;
                        }
                        if (sayfalar > 1)
                        {
                            for (int i = 0; i < sayfalar; i++)
                            {
                                if ((i + 1).ToString() == p)
                                    clas = "page_hover";
                                else
                                    clas = "page";

                                sb.Append("<a href='" + link + "p=" + (i + 1) + "'><div class='" + clas + "'>" + (i + 1) + "</div></a>");
                            }
                        }
                        else
                        {
                            lt_pager.Visible = false;
                        }
                        break;
                    }
            }
            sb.Append("</div></div><div id='dv_ileri' class='page' style='background-color:#434750;'>İleri</div>");
            lt_pager.Text = sb.ToString();
        }
    }
}