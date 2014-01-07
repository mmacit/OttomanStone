using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.Services;
using OttomanStone.DataModel;
using Admin.Class;

namespace OttomanStone
{
    public partial class siparis_ver : System.Web.UI.Page
    {
        [WebMethod]
        public static string GetUrunFiyat(int id)
        {
            OttomanStoneEntities oss = new OttomanStoneEntities();
            string fiyat = oss.contents.FirstOrDefault(fi => fi.Id == id).UrunFiyat;
            return fiyat;
        }

        OttomanStoneEntities os = new OttomanStoneEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            a_siparis_ver.ServerClick += a_siparis_ver_ServerClick;
            AllProduct();

            var urun_kodu = Convert.ToString(Request.QueryString["uk"]);
            drp_urun.SelectedValue = urun_kodu;

            var mod = Convert.ToString(Request.QueryString["mod"]);

            if (mod == "ok")
            {
                dv_bilgilendirme.Visible = true;
                lt_bilgi.Text = "Sipariş Bilgileriniz Tarafımıza Ulaşmıştır. Size En Kısa Sürede Dönüş Yapılacaktır.";
            }
            else
            {
                dv_bilgilendirme.Visible = false;
            }
        }

        public void AllProduct()
        {
            if (!IsPostBack)
            {
                int catid_urun = os.Kategoriler.FirstOrDefault(ka => ka.KategoriAdi_Kucuk == "urunler").KategoriID;

                List<Kategoriler> kats = (from kk in os.Kategoriler
                                          where kk.OwnerID == catid_urun
                                          select kk).ToList();
                int say = 0;
                foreach (var item in kats)
                {
                    drp_urun.Items.Insert(say, new ListItem("-" + item.KategoriAdi, item.KategoriID.ToString()));

                    List<content> uruns = (from uu in os.contents
                                           where uu.CatId == item.KategoriID
                                           select uu).ToList();

                    foreach (var itemu in uruns)
                    {
                        say++;
                        drp_urun.Items.Insert(say, new ListItem("--" + itemu.Title + "(" + itemu.UrunKodu + ")", itemu.Id.ToString()));
                    }
                }
            }
        }

        void a_siparis_ver_ServerClick(object sender, EventArgs e)
        {
            MailWorks mw = new MailWorks();
            mw.IsHTML = true;
            mw.Password = "";
            mw.Port = 587;
            mw.RecipientMailAdress = "";
            mw.RecipientName = "Bedrettin Gör";
            mw.SenderName = "Ottoman Stone [SİPARİŞ TALEBİ]";
            mw.SenderMailAdress = "no-reply@ottomanstone.com";
            mw.SmtpAddress = "";
            mw.Username = "";
            mw.Header = "Ottoman Stone [SİPARİŞ TALEBİ]";
            mw.EnableSSL = false;
            mw.Body = "<table><tr><td>Adı Soyadı</td><td>" + ad_soyad.Value + "</td></tr><tr><td>Telefon</td><td>" + telefon.Value + "</td></tr><tr><td>E-Mail</td><td>" + email.Value + "</td></tr><tr><td>Adres 1</td><td>" + adres1.Value + "</td></tr><tr><td>Adres 2</td><td>" + adres2.Value + "</td><td>Ülke</td></tr><tr><td>" + ulke.Value + "</td></tr><tr><td>Şehir</td><td>" + sehir.Value + "</td></tr><tr><td>İlçe</td><td>" + ilce.Value + "</td></tr><tr><td>Posta Kodu</td></tr><tr><td>" + posta_kodu.Value + "</td></tr><tr><td>Mesaj</td><td>" + message1.InnerHtml + "</td></tr><tr><td>Ürün</td><td>" + drp_urun.SelectedItem.Text + "</td></tr><tr><td></td>Ödeme Şekli<td></td><td>" + odeme_sekli.Items[odeme_sekli.SelectedIndex].Text + "</td></tr><tr><td>Fiyat</td><td>" + fiyat + "</td></tr></table>";

            mw.mailSend();

            mw = new MailWorks();
            mw.IsHTML = true;
            mw.Password = "";
            mw.Port = 587;
            mw.RecipientMailAdress = email.Value;
            mw.RecipientName = ad_soyad.Value;
            mw.SenderName = "Ottoman Stone [SİPARİŞ TALEBİ]";
            mw.SenderMailAdress = "no-reply@ottomanstone.com";
            mw.SmtpAddress = "";
            mw.Username = "";
            mw.Header = "Ottoman Stone [BİLGİLENDİRME]";
            mw.EnableSSL = false;
            mw.Body = "";


            mw.Body = "Merhaba " + ad_soyad.Value + ",<br><br>Sitemizden vermiş olduğunuz sipariş bilgileri aşağıdak gibidir. Sizinle en kısa sürede iletişime geçeceğiz.İlginize teşekkür ederiz. <br><br> <table><tr><td>Adı Soyadı</td><td>" + ad_soyad.Value + "</td></tr><tr><td>Telefon</td><td>" + telefon.Value + "</td></tr><tr><td>E-Mail</td><td>" + email.Value + "</td></tr><tr><td>Adres 1</td><td>" + adres1.Value + "</td></tr><tr><td>Adres 2</td><td>" + adres2.Value + "</td><td>Ülke</td></tr><tr><td>" + ulke.Value + "</td></tr><tr><td>Şehir</td><td>" + sehir.Value + "</td></tr><tr><td>İlçe</td><td>" + ilce.Value + "</td></tr><tr><td>Posta Kodu</td></tr><tr><td>" + posta_kodu.Value + "</td></tr><tr><td>Mesaj</td><td>" + message1.InnerHtml + "</td></tr><tr><td>Ürün</td><td>" + drp_urun.SelectedItem.Text + "</td></tr><tr><td></td>Ödeme Şekli<td></td><td>" + odeme_sekli.Items[odeme_sekli.SelectedIndex].Text + "</td></tr><tr><td>Fiyat</td><td>" + fiyat + "</td></tr></table>";
            mw.mailSend();

            Response.Redirect(Request.Url.ToString() + "?mod=ok");
        }
    }
}