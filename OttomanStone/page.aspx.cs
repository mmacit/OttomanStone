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
    public partial class page : System.Web.UI.Page
    {
        OttomanStoneEntities os = new OttomanStoneEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Load4Item();
        }
        private void Load4Item()
        {
            StringBuilder sb = new StringBuilder();
            List<Banner> br = (from b in os.Banner
                               where b.BannerAdi == "IcSayfaDikeySlider"
                               select b).ToList();
            foreach (var item in br)
            {

                List<BannerReklam> ban = (from b in os.BannerReklam
                                          where b.BannerReklamBannerID == item.BannerAlanID
                                          select b).ToList();

                foreach (var items in ban)
                {
                    sb.AppendLine("<div class='ps-album' style='opacity: 0;'>");
                    sb.AppendLine("<img src='/files/images/banner/" + items.BannerReklamDeger + "' alt='' />");
                    sb.AppendLine("<div class='ps-desc'>");
                    sb.AppendLine("<div class='ps-head'>");
                    sb.AppendLine("<h3>" + items.BannerReklamBaslik + "</h3>");
                    sb.AppendLine("</div>");
                    sb.AppendLine("<div class='ps-cont'>");
                    sb.AppendLine("<span>" + items.BannerReklamDetay + "</span>");
                    sb.AppendLine("</div>");
                    sb.AppendLine("</div>");
                    sb.AppendLine("</div>");
                }
            }

            lt_ametist.Text = sb.ToString();
        }

    }
}