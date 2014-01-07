using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;
using System.Net.Mail;
using System.Net;

    public partial class ik : System.Web.UI.UserControl
    {
        public string lang;
        public string az;
        public string iyi;
        public string orta;
        public string yuksek;
        public string secin;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lang = Page.RouteData.Values["SayfaDili"].ToString();
            }
            catch
            {
                lang = "tr";
            }
            selectLang();
        }

        private void selectLang()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("/Controls/ik/lang/lang.xml"));
            string[] levels = new string[5];

            switch (lang)
            {
                case "tr":
                    {
                        levels[0] = xdoc.ChildNodes[0].ChildNodes[0].ChildNodes[0].Attributes["az"].InnerText;
                        levels[1] = xdoc.ChildNodes[0].ChildNodes[0].ChildNodes[0].Attributes["orta"].InnerText;
                        levels[2] = xdoc.ChildNodes[0].ChildNodes[0].ChildNodes[0].Attributes["iyi"].InnerText;
                        levels[3] = xdoc.ChildNodes[0].ChildNodes[0].ChildNodes[0].Attributes["yuksek"].InnerText;

                        lb_ad.Text = "Adınız";
                        lb_adres.Text = "Adres";
                        lb_asker.Text = "Askerlik Durumu";
                        lb_bitirme.Text = "Bitirme Yılı";
                        lb_bolum.Text = "Bölüm";
                        lb_cep.Text = "Gsm";
                        lb_cins.Text = "Cinsiyet";
                        lb_d_bolum.Text = "Bölüm";
                        lb_d_sure.Text = "Süre";
                        lb_deneyim.Text = "Deneyim";
                        lb_dil.Text = "Dil";
                        lb_dilbil.Text = "Bildiğiniz Diller";
                        lb_dtarih.Text = "Doğum Tarihi";
                        lb_dyer.Text = "Doğum Yeri";
                        lb_ilet.Text = "İletişim Bilgileri";
                        lb_kan.Text = "Kan Grubu";
                        lb_konu.Text = "Konu";
                        lb_konus.Text = "Konuşma";
                        lb_kisi.Text = "Kişisel Bilgiler";
                        lb_kurum.Text = "Kurum";
                        lb_mail.Text = "E-Posta";
                        lb_medeni.Text = "Medeni Hal";
                        lb_ogren.Text = "Öğrenim Bilgisi";
                        lb_oku.Text = "Okuma";
                        lb_okul.Text = "Okul";
                        lb_r_ad.Text = "Adı";
                        lb_r_telefon.Text = "Telefonu";
                        lb_r_unvan.Text = "Ünvan";
                        lb_ref.Text = "Referanslar";
                        lb_s_sure.Text = "Süre";
                        lb_sirket.Text = "Şirket";
                        lb_staj.Text = "Staj";
                        lb_tel.Text = "Telefon";
                        lb_uyruk.Text = "Uyruğunuz";
                        lb_yaz.Text = "Yazma";

                        rad_asker.Items[0].Text = "Yaptı";
                        rad_asker.Items[1].Text = "Yapmadı";
                        rad_asker.Items[2].Text = "Muaf";

                        rad_cins.Items[0].Text = "Erkek";
                        rad_cins.Items[1].Text = "Kadın";

                        rad_medeni.Items[0].Text = "Bekar";
                        rad_medeni.Items[1].Text = "Evli";


                        rq_ad.ErrorMessage = "Bu Alan Boş Bırakılamaz.";
                        rq_cep.ErrorMessage = "Bu Alan Boş Bırakılamaz.";
                        rq_dtarih.ErrorMessage = "Bu Alan Boş Bırakılamaz.";
                        rq_kan.ErrorMessage = "Bu Alan Boş Bırakılamaz.";
                        rq_tel.ErrorMessage = "Bu Alan Boş Bırakılamaz.";
                        rq_uyruk.ErrorMessage = "Bu Alan Boş Bırakılamaz.";
                        rq_yer.ErrorMessage = "Bu Alan Boş Bırakılamaz.";

                        chk_onay.Text = "Yukarıdaki Bilgilerin Doğruluğunu Onaylıyorum";
                        btn_gonder.Text = "Gönder";
                        break;
                    }
                case "en":
                    {
                        levels[0] = xdoc.ChildNodes[0].ChildNodes[1].ChildNodes[0].Attributes["az"].InnerText;
                        levels[1] = xdoc.ChildNodes[0].ChildNodes[1].ChildNodes[0].Attributes["orta"].InnerText;
                        levels[2] = xdoc.ChildNodes[0].ChildNodes[1].ChildNodes[0].Attributes["iyi"].InnerText;
                        levels[3] = xdoc.ChildNodes[0].ChildNodes[1].ChildNodes[0].Attributes["yuksek"].InnerText;

                        lb_ad.Text = "Name";
                        lb_adres.Text = "Address";
                        lb_asker.Text = "Military Status";
                        lb_bitirme.Text = "Ending Year";
                        lb_bolum.Text = "State";
                        lb_cep.Text = "Gsm";
                        lb_cins.Text = "Sex";
                        lb_d_bolum.Text = "State";
                        lb_d_sure.Text = "Time";
                        lb_deneyim.Text = "Experiment";
                        lb_dil.Text = "Language";
                        lb_dilbil.Text = "Known Languages";
                        lb_dtarih.Text = "Born Date";
                        lb_dyer.Text = "Born Place";
                        lb_ilet.Text = "Contact Info";
                        lb_kan.Text = "Blood Group";
                        lb_konu.Text = "Subject";
                        lb_konus.Text = "Talking";
                        lb_kisi.Text = "Personal Info";
                        lb_kurum.Text = "Corporation";
                        lb_mail.Text = "E-Mail";
                        lb_medeni.Text = "Civil Status";
                        lb_ogren.Text = "Education Info";
                        lb_oku.Text = "Reading";
                        lb_okul.Text = "School";
                        lb_r_ad.Text = "Name";
                        lb_r_telefon.Text = "Phone";
                        lb_r_unvan.Text = "Title";
                        lb_ref.Text = "References";
                        lb_s_sure.Text = "Time";
                        lb_sirket.Text = "Corporation";
                        lb_staj.Text = "Internship";
                        lb_tel.Text = "Phone";
                        lb_uyruk.Text = "Nationality";
                        lb_yaz.Text = "Writing";

                        rad_asker.Items[0].Text = "Done";
                        rad_asker.Items[1].Text = "Not";
                        rad_asker.Items[2].Text = "Exempt";

                        rad_cins.Items[0].Text = "Man";
                        rad_cins.Items[1].Text = "Woman";

                        rad_medeni.Items[0].Text = "Single";
                        rad_medeni.Items[1].Text = "Married";

                        chk_onay.Text = "I agree the accuracy of information";
                        btn_gonder.Text = "Send";

                        rq_ad.ErrorMessage = "This Field Cannot Be Empty.";
                        rq_cep.ErrorMessage = "This Field Cannot Be Empty.";
                        rq_dtarih.ErrorMessage = "This Field Cannot Be Empty.";
                        rq_kan.ErrorMessage = "This Field Cannot Be Empty.";
                        rq_tel.ErrorMessage = "This Field Cannot Be Empty.";
                        rq_uyruk.ErrorMessage = "This Field Cannot Be Empty.";
                        rq_yer.ErrorMessage = "This Field Cannot Be Empty.";

                        break;
                    }
                case "fr":
                    {
                        levels[0] = xdoc.ChildNodes[0].ChildNodes[2].ChildNodes[0].Attributes["az"].InnerText;
                        levels[1] = xdoc.ChildNodes[0].ChildNodes[2].ChildNodes[0].Attributes["orta"].InnerText;
                        levels[2] = xdoc.ChildNodes[0].ChildNodes[2].ChildNodes[0].Attributes["iyi"].InnerText;
                        levels[3] = xdoc.ChildNodes[0].ChildNodes[2].ChildNodes[0].Attributes["yuksek"].InnerText;

                        lb_ad.Text = "Nom";
                        lb_adres.Text = "Adresse";
                        lb_asker.Text = "statut militaire";
                        lb_bitirme.Text = "Fin année";
                        lb_bolum.Text = "Etat";
                        lb_cep.Text = "Téléphone";
                        lb_cins.Text = "sexe";
                        lb_d_bolum.Text = "Etat";
                        lb_d_sure.Text = "Temps";
                        lb_deneyim.Text = "Expérience";
                        lb_dil.Text = "Langue";
                        lb_dilbil.Text = "Langues connus";
                        lb_dtarih.Text = "Né date";
                        lb_dyer.Text = "Placer Né";
                        lb_ilet.Text = "Contact Info";
                        lb_kan.Text = "groupe sanguin";
                        lb_konu.Text = "Sujet";
                        lb_konus.Text = "Parler";
                        lb_kisi.Text = "Infos personnelles";
                        lb_kurum.Text = "Société";
                        lb_mail.Text = "E-Mail";
                        lb_medeni.Text = "Etat civil";
                        lb_ogren.Text = "Info éducation";
                        lb_oku.Text = "lecture";
                        lb_okul.Text = "école";
                        lb_r_ad.Text = "Nom";
                        lb_r_telefon.Text = "Téléphone";
                        lb_r_unvan.Text = "Titre";
                        lb_ref.Text = "Références";
                        lb_s_sure.Text = "Temps";
                        lb_sirket.Text = "Société";
                        lb_staj.Text = "stage";
                        lb_tel.Text = "Téléphone";
                        lb_uyruk.Text = "nationalité";
                        lb_yaz.Text = "Ecriture";

                        rad_asker.Items[0].Text = "Terminé";
                        rad_asker.Items[1].Text = "Note";
                        rad_asker.Items[2].Text = "exonérées";

                        rad_cins.Items[0].Text = "Man";
                        rad_cins.Items[1].Text = "Femme";

                        rad_medeni.Items[0].Text = "Célibataire";
                        rad_medeni.Items[1].Text = "Marié";

                        chk_onay.Text = "J'accepte l'exactitude de l'information";
                        btn_gonder.Text = "submit";

                        rq_ad.ErrorMessage = "Ceci ne peut être le champ vide.";
                        rq_cep.ErrorMessage = "Ceci ne peut être le champ vide.";
                        rq_dtarih.ErrorMessage = "Ceci ne peut être le champ vide.";
                        rq_kan.ErrorMessage = "Ceci ne peut être le champ vide.";
                        rq_tel.ErrorMessage = "Ceci ne peut être le champ vide.";
                        rq_uyruk.ErrorMessage = "Ceci ne peut être le champ vide.";
                        rq_yer.ErrorMessage = "Ceci ne peut être le champ vide.";

                        break;
                    }
                case "ru":
                    {
                        levels[0] = xdoc.ChildNodes[0].ChildNodes[3].ChildNodes[0].Attributes["az"].InnerText;
                        levels[1] = xdoc.ChildNodes[0].ChildNodes[3].ChildNodes[0].Attributes["orta"].InnerText;
                        levels[2] = xdoc.ChildNodes[0].ChildNodes[3].ChildNodes[0].Attributes["iyi"].InnerText;
                        levels[3] = xdoc.ChildNodes[0].ChildNodes[3].ChildNodes[0].Attributes["yuksek"].InnerText;

                        lb_ad.Text = "Имя";
                        lb_adres.Text = "Адрес";
                        lb_asker.Text = "Военно Статус";
                        lb_bitirme.Text = "Завершение года";
                        lb_bolum.Text = "государства";
                        lb_cep.Text = "Телефон";
                        lb_cins.Text = "секс";
                        lb_d_bolum.Text = "государства";
                        lb_d_sure.Text = "Время";
                        lb_deneyim.Text = "Эксперимент";
                        lb_dil.Text = "Язык";
                        lb_dilbil.Text = "Известные Языки";
                        lb_dtarih.Text = "Дата рождения";
                        lb_dyer.Text = "Место рождения";
                        lb_ilet.Text = "Связь";
                        lb_kan.Text = "Группа крови";
                        lb_konu.Text = "Тема";
                        lb_konus.Text = "Talking";
                        lb_kisi.Text = "Личная информация";
                        lb_kurum.Text = "Корпорация";
                        lb_mail.Text = "E-Mail";
                        lb_medeni.Text = "гражданского состояния";
                        lb_ogren.Text = "Образование Info";
                        lb_oku.Text = "Чтение";
                        lb_okul.Text = "школа";
                        lb_r_ad.Text = "Имя";
                        lb_r_telefon.Text = "Телефон";
                        lb_r_unvan.Text = "Title";
                        lb_ref.Text = "Ссылки";
                        lb_s_sure.Text = "Время";
                        lb_sirket.Text = "Корпорация";
                        lb_staj.Text = "Стажировка";
                        lb_tel.Text = "Телефон";
                        lb_uyruk.Text = "национальность";
                        lb_yaz.Text = "Написание";

                        rad_asker.Items[0].Text = "Готово";
                        rad_asker.Items[1].Text = "Примечание";
                        rad_asker.Items[2].Text = "Освобождение";

                        rad_cins.Items[0].Text = "Человек";
                        rad_cins.Items[1].Text = "женщина";

                        rad_medeni.Items[0].Text = "Единый";
                        rad_medeni.Items[1].Text = "Молодожены";

                        chk_onay.Text = "Я согласен с тем точность информации";
                        btn_gonder.Text = "Отправить";

                        rq_ad.ErrorMessage = "Это не может быть пустым полем.";
                        rq_cep.ErrorMessage = "Это не может быть пустым полем.";
                        rq_dtarih.ErrorMessage = "Это не может быть пустым полем.";
                        rq_kan.ErrorMessage = "Это не может быть пустым полем.";
                        rq_tel.ErrorMessage = "Это не может быть пустым полем.";
                        rq_uyruk.ErrorMessage = "Это не может быть пустым полем.";
                        rq_yer.ErrorMessage = "Это не может быть пустым полем.";

                        break;
                    }
            }

            ListItem[] li = new ListItem[4];
            for (int i = 0; i < 4; i++)
            {
                string deger = levels[i];
                s1.Items.Add(deger);
                s2.Items.Add(deger);
                s3.Items.Add(deger);
                s4.Items.Add(deger);
                s5.Items.Add(deger);
                s6.Items.Add(deger);
                s7.Items.Add(deger);
                s9.Items.Add(deger);
                s8.Items.Add(deger);
            }
        }

        protected void btn_gonder_Click(object sender, EventArgs e)
        {
            if (chk_onay.Checked)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<style type=\"text/css\"> table {  } </style><table cellpadding=\"3\" cellspacing=\"3\" border=\"0\"> <thead style=\"background-color:#E2E1E7;paddig:3px;\"> <div class=\"hr-head\"> <div> </div> <span id=\"ctl00_cp1_ik1_lb_kisi\">Kişisel Bilgiler</span></div> </thead> <tr> <td> Adınız</span> </td> <td>");
                sb.Append(tx_ad.Text + "</td> <td> <span id=\"ctl00_cp1_ik1_rq_ad\" style=\"color:Red;visibility:hidden;\">Bu Alan Boş Bırakılamaz.</span></td> </tr> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_cins\">Cinsiyet</span> </td>  <td> <table id=\"ctl00_cp1_ik1_rad_cins\" type=\"radio\" border=\"0\"> <tr> <td> " + rad_cins.SelectedItem.Text + " </td> </tr> </table> </td> <td></td> </tr> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_dtarih\">Doğum Tarihi</span> </td> <td> " + tx_dtarih.Text + " </td>");
                sb.Append("<td><span id=\"ctl00_cp1_ik1_rq_dtarih\" style=\"color:Red;visibility:hidden;\">Bu Alan Boş Bırakılamaz.</span></td> </tr> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_dyer\">Doğum Yeri</span> </td> <td> " + tx_dyer.Text + " </td>");
                sb.Append("<td><span id=\"ctl00_cp1_ik1_rq_yer\" style=\"color:Red;visibility:hidden;\">Bu Alan Boş Bırakılamaz.</span></td> </tr> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_medeni\">Medeni Hal</span> </td> <td> <table id=\"ctl00_cp1_ik1_rad_medeni\" border=\"0\"> <tr> <td> " + rad_medeni.SelectedItem.Text + " </TD>");
                sb.Append("</tr> </table> </td> </tr> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_uyruk\">Uyruğunuz</span> </td> <td> " + tx_uyruk.Text + " </td> <td></td> </tr>  <tr>");
                sb.Append("<td> <span id=\"ctl00_cp1_ik1_lb_asker\">Askerlik Durumu</span> </td> <td> <table id=\"ctl00_cp1_ik1_rad_asker\" border=\"0\"> <tr> <td>" + rad_asker.SelectedItem.Text + "</td>  </tr> </table> ");
                sb.Append("</td>  </tr> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_kan\">Kan Grubu</span> </td>  <td> " + tx_kan.Text + " </td> <td>");
                sb.Append("<span id=\"ctl00_cp1_ik1_rq_kan\" style=\"color:Red;visibility:hidden;\">Bu Alan Boş Bırakılamaz.</span></td> </tr> </table> <table cellpadding=\"3\" cellspacing=\"3\" border=\"0\"> <thead style=\"paddig:3px;background-color:#E2E1E7;\"> <div class=\"hr-head\">  <div></div>");
                sb.Append("<span id=\"ctl00_cp1_ik1_lb_ilet\">İletişim Bilgileri</span></div> </thead> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_adres\">Adres</span> </td> <td> " + tx_adres.Text + " </td> ");
                sb.Append("</tr> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_tel\">Telefon</span> </td> <td> " + tx_tel.Text + " </td> <td><span id=\"ctl00_cp1_ik1_rq_tel\" style=\"color:Red;visibility:hidden;\">Bu Alan Boş Bırakılamaz.</span></td>");
                sb.Append("</tr> <tr> <td>  <span id=\"ctl00_cp1_ik1_lb_cep\">Gsm</span> </td> <td> " + tx_cep.Text + " </td> <td><span id=\"ctl00_cp1_ik1_rq_cep\" style=\"color:Red;visibility:hidden;\">Bu Alan Boş Bırakılamaz.</span></td> </tr> <tr>  <td> <span id=\"ctl00_cp1_ik1_lb_mail\">E-Posta</span> </td> <td> " + tx_mail.Text + " </td>");
                sb.Append("</tr> </table> <table cellpadding=\"3\" cellspacing=\"3\" border=\"0\">  <thead style=\"paddig:3px;background-color:#E2E1E7;\"> <div class=\"hr-head\"> <div> </div> <span id=\"ctl00_cp1_ik1_lb_ogren\">Öğrenim Bilgisi</span></div> </thead> <tr> <td>  <span id=\"ctl00_cp1_ik1_lb_okul\">Okul</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_bolum\">Bölüm</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_bitirme\">Bitirme Yılı</span>  </td> </tr> ");
                sb.Append("<tr> <td> " + tx_okul1.Text + " </td> <td> " + tx_bolum1.Text + " </td>  <td> " + tx_bitirme1.Text + " </td> </tr> <tr> <td> " + tx_okul2.Text + " </td> <td> " + tx_bolum2.Text + " </td> <td> " + tx_bitirme2.Text + "  </td> </tr> <tr> <td> " + tx_okul3.Text + " </td> ");
                sb.Append(" <td> " + tx_bolum3.Text + " </td> <td> " + tx_bitirme3.Text + "  </td> </tr> </table>  <table cellpadding=\"3\" cellspacing=\"3\" border=\"0\"> <thead style=\"paddig:3px;background-color:#E2E1E7;\"> <div class=\"hr-head\"> <div> </div> <span id=\"ctl00_cp1_ik1_lb_dilbil\">Bildiğiniz Diller</span></div> </thead> <tr>  <td> <span id=\"ctl00_cp1_ik1_lb_dil\">Dil</span> </td> ");
                sb.Append("<td> <span id=\"ctl00_cp1_ik1_lb_oku\">Okuma</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_yaz\">Yazma</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_konus\">Konuşma</span> </td> </tr> <tr> <td> " + tx_dil1.Text + " </td> <td> " + s1.Items[s1.SelectedIndex].Text + " </td> <td> " + s2.Items[s2.SelectedIndex].Text  + " </td> <td> " + s3.Items[s3.SelectedIndex].Text  + " </td> </tr> <tr> <td> " + tx_dil2.Text + " </td>");
                sb.Append(" <td> " + s4.Items[s4.SelectedIndex].Text + " </td> <td>  " + s5.Items[s5.SelectedIndex].Text + " </td>  <td> " + s6.Items[s6.SelectedIndex].Text + "  </td> </tr> <tr> <td> " + tx_dil3.Text + " </td> <td> " + s7.Items[s7.SelectedIndex].Text + " </td> <td> " + s8.Items[s8.SelectedIndex].Text + " </td> <td> " + s9.Items[s9.SelectedIndex].Text + " </td> </tr> </table> <table cellpadding=\"3\" cellspacing=\"3\" border=\"0\"> <thead style=\"paddig:3px;background-color:#E2E1E7;\">  <div class=\"hr-head\"> <div> </div> <span id=\"ctl00_cp1_ik1_lb_staj\">Staj</span></div> ");
                sb.Append("</thead> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_kurum\">Kurum</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_konu\">Konu</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_s_sure\">Süre</span> </td> </tr>  <tr> <td> " + tx_kurum1.Text + " </td> <td> " + tx_konu1.Text + " </td> <td> " + tx_s_sure1.Text + " </td> </tr>");
                sb.Append(" <tr> <td> " + tx_kurum2.Text + " </td> <td> " + tx_konu2.Text + " </td>  <td> " + tx_s_sure2.Text + " </td> </tr> <tr> <td> " + tx_kurum3.Text + " </td> <td>  " + tx_konu3.Text + " </td> <td> " + tx_s_sure3.Text + " </td> </tr> </table> <table cellpadding=\"3\" cellspacing=\"3\" border=\"0\"> ");
                sb.Append("<thead style=\"background-color:#E2E1E7;\"> <div class=\"hr-head\">  <div> </div> <span id=\"ctl00_cp1_ik1_lb_deneyim\">Deneyim</span></div> </thead> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_sirket\">Şirket</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_d_bolum\">Bölüm</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_d_sure\">Süre</span> </td>");
                sb.Append("</tr>  <tr> <td> " + tx_sirket1.Text + " </td> <td> " + tx_d_bolum1.Text + " </td> <td> " + tx_d_bolum1.Text + " </td> </tr> <tr> <td> " + tx_sirket2.Text + " </td> <td> " + tx_d_bolum2.Text + " </td>  <td> " + tx_d_sure2.Text + " </td> </tr> <tr> <td> " + tx_sirket3.Text + " </td> <td>  " + tx_d_bolum3.Text + " </td> <td> " + tx_d_sure3.Text + " </td> </tr> </table> <table cellpadding=\"3\" cellspacing=\"3\" border=\"0\"> <thead style=\"paddig:3px;background-color:#E2E1E7;\"> <div class=\"hr-head\">  ");
                sb.Append("<div> </div> <span id=\"ctl00_cp1_ik1_lb_ref\">Referanslar</span></div> </thead> <tr> <td> <span id=\"ctl00_cp1_ik1_lb_r_ad\">Adı</span>  </td> <td> <span id=\"ctl00_cp1_ik1_lb_r_unvan\">Ünvan</span> </td> <td> <span id=\"ctl00_cp1_ik1_lb_r_telefon\">Telefonu</span> </td> </tr>  <tr> <td> ");
                sb.Append(tx_r_ad.Text + "</td> <td> " + tx_r_unvan1.Text + " </td> <td> " + tx_r_tel1 + "  </td> </tr> <tr> <td> " + tx_r_ad1.Text + " </td> <td> " + tx_r_unvan2.Text + " </td>  <td> " + tx_r_tel2.Text + " </td> </tr> <tr> <td> " + tx_r_ad3.Text + " </td> <td> " + tx_r_unvan3.Text + " </td> <td> " + tx_r_ad3.Text + " </td> </tr> </table>");

                SmtpClient smtpCli = new SmtpClient();
                smtpCli.Host = "smtp.gmail.com";
                smtpCli.Port = 587;
                smtpCli.Credentials = new NetworkCredential("webdestek06@gmail.com", "33seairsea-");
                smtpCli.EnableSsl = true;

                MailAddress gonderen = new MailAddress("webdestek06@gmail.com");
                MailAddress alici = new MailAddress("vurallarpeynicilik@hotmail.com");
                string konu = "İş Başvurusu - www.vurallarpeynircilik.com Adresinden";
                string icerik = sb.ToString();

                MailMessage mesaj = new MailMessage(gonderen.ToString(), alici.ToString(), konu, icerik);
                mesaj.IsBodyHtml = true;
                smtpCli.Send(mesaj);
            }
            else
            {
                if (lang == "tr")
                {
                    getMessage("Lütfen Bilgilerin Doğruluğunu Onaylayın.");
                }
                else
                {
                    getMessage("Please confirm the accuracy of the information.");
                }
            }
        }

        private void getMessage(string message)
        {
            lb_info.Text = message;
        }
    }