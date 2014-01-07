using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CodeCarvings.Piczard;
using System.Drawing;
using System.IO;
using icebear_v2.Class;
using OttomanStone.DataModel;
using System.Text;
using CodeCarvings.Piczard.Filters.Watermarks;

namespace icebear_v2.ContentMenagement
{
    public partial class pictures : System.Web.UI.Page
    {
        OttomanStoneEntities idc = new OttomanStoneEntities();

        public string icerik_adi, mode;
        public int id, cid;

        protected void Page_Load(object sender, EventArgs e)
        {
            All_Images();
            //if (!this.IsPostBack)
            //{
            //    this.SimpleImageUpload1.AutoOpenImageEditPopupAfterUpload = true;
            //    this.SimpleImageUpload1.CropConstraint = new FixedCropConstraint(800, 600);
            //    this.SimpleImageUpload1.CropConstraint.DefaultImageSelectionStrategy = CropConstraintImageSelectionStrategy.WholeImage;
            //    this.SimpleImageUpload1.PreviewFilter = new FixedResizeConstraint(400, 300);


            //    ImageProcessingFilterCollection filter = new ImageProcessingFilterCollection();
            //    filter.Add(new ImageWatermark("~/Images/watermark.png",ContentAlignment.MiddleCenter));
            //    this.SimpleImageUpload1.PostProcessingFilter = filter;
            //}

            mode = Convert.ToString(Request.QueryString["mode"]);
            id = Convert.ToInt32(Request.QueryString["id"]);
            cid = Convert.ToInt32(Request.QueryString["cid"]);

            icerik_adi = (from ic in idc.contents
                          where ic.Id == cid
                          select ic.Title).Single();

            switch (mode)
            {
                case "delete":
                    {
                        var silinecek = (from img in idc.ContentImage
                                         where img.Id == id
                                         select img).Single();
                        string resim_ismi = silinecek.ContentImage1;
                        idc.ContentImage.Remove(silinecek);
                        idc.SaveChanges();
                        try
                        {
                            File.Delete(Server.MapPath("~/Files/Images/" + resim_ismi));
                            foreach (var item in Directory.GetDirectories(Server.MapPath("~/Files/Images/")))
                            {
                                File.Delete(item + "/" + resim_ismi);
                            }
                        }
                        catch (Exception)
                        {

                        }
                        Response.Redirect(Request.Url.ToString().Replace("mode=delete&", ""));
                        break;
                    }
                case "edit":
                    {
                        break;
                    }
                case null:
                    {
                        break;
                    }
            }
        }

        protected void img_uploader_ValueChanged(object sender, CodeCarvings.Piczard.Web.PictureTrimmerValueChangedEventArgs e)
        {
            string frnrmr = "asdad";
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            //if (this.SimpleImageUpload1.HasNewImage)
            //{
            //    string dosyaadi = Tools.make_FileName(SimpleImageUpload1.SourceImageClientFileName.Substring(0, SimpleImageUpload1.SourceImageClientFileName.Length - 4), Path.GetExtension(SimpleImageUpload1.SourceImageClientFileName));
            //    this.SimpleImageUpload1.SaveProcessedImageToFileSystem("~/Files/Images/" + dosyaadi, new JpegFormatEncoderParams(92));
            //    
            //    Save_Image();
            //}

            bool OK = Directory.Exists(Server.MapPath("~/files/images/" + cid));
            if (!OK)
            {
                Directory.CreateDirectory(Server.MapPath("~/files/images/" + cid));
            }

            if (fu_img.HasFile)
            {
                string dosyaadi = Tools.make_FileName(fu_img.FileName, Path.GetExtension(fu_img.FileName));
                fu_img.SaveAs(Server.MapPath("~/files/images/" + cid + "/" + dosyaadi));
                resimUfalt(dosyaadi, "~/Files/Images/" + cid, 150);
                hd_Resim.Value = dosyaadi;
                Save_Image();
            }
        }

        private void resimUfalt(string dosyaAdi, string yukleme_adresi, int boyutu)
        {
            int hedefGenislik = boyutu;

            Bitmap bmpp = new Bitmap(Server.MapPath("~/Files/Images/" + cid + "/" + dosyaAdi));
            Size boyut = new Size();
            boyut.Height = Convert.ToInt32(bmpp.Height);
            boyut.Width = Convert.ToInt32(bmpp.Width);

            double yuksOran = (double)boyut.Width / (double)hedefGenislik;
            double yukseklik = (double)boyut.Height / (double)yuksOran;

            boyut.Height = Convert.ToInt32(yukseklik);
            boyut.Width = hedefGenislik;
            bmpp.Dispose();

            Bitmap bitmap = new Bitmap(System.Drawing.Image.FromFile(Server.MapPath("~/Files/Images/" + cid + "/" + dosyaAdi)), boyut);
            bitmap.SetResolution((float)96, (float)96);

            if (!Directory.Exists(Server.MapPath("~/Files/Images/" + cid + "/" + boyutu.ToString())))
            {
                Directory.CreateDirectory(Server.MapPath("~/Files/Images/" + cid + "/" + boyutu.ToString()));
            }

            bitmap.Save(Server.MapPath(yukleme_adresi + "/_" + dosyaAdi));
            bitmap.Dispose();

            hd_Resim.Value = dosyaAdi;
        }

        private void Save_Image()
        {
            ContentImage imgs = new ContentImage();
            imgs.ContentId = int.Parse(Request.QueryString["cid"]);
            imgs.ContentImage1 = hd_Resim.Value;

            idc.ContentImage.Add(imgs);
            idc.SaveChanges();
            Response.Redirect(Request.Url.ToString());
        }

        private void All_Images()
        {
            int cid = int.Parse(Request.QueryString["cid"]);
            if (cid != null)
            {
                
                StringBuilder sb = new StringBuilder();

                List<ContentImage> resimler = (from img in idc.ContentImage
                                                where img.ContentId == cid
                                                select img).ToList();

                foreach (var item in resimler)
                {
                    sb.Append("<div class=\"content-images\"><a rel='delete' title='Silme Onayı' mesaj='Bu İçerik Kalıcı Olarak Silinecek.<br>Devam Edilsin Mi ?' href=\"?mode=delete&cid=" + Request.QueryString["cid"].ToString() + "&id=" + item.Id + "\"><div class=\"delete-image\"></div></a><br><img src=\"/Files/Images/" + cid + "/" + item.ContentImage1 + "\" /></div>");
                }

                lt_images.Text = sb.ToString();
            }
        }
    }
}