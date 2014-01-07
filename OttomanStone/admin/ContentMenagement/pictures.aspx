<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Masterpage/admin.Master" AutoEventWireup="true"
    CodeBehind="pictures.aspx.cs" Inherits="icebear_v2.ContentMenagement.pictures" %>

<%@ Register Assembly="CodeCarvings.Piczard" Namespace="CodeCarvings.Piczard.Web"
    TagPrefix="ccPiczard" %>
<%@ Register Src="/Admin/Controls/piczardUserControls/simpleImageUploadUserControl/SimpleImageUpload.ascx"
    TagName="SimpleImageUpload" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hd_Resim" runat="server" />
   <h5><%= icerik_adi %> İÇİN RESİM YÜKLE</h5> 
    <%--<uc1:SimpleImageUpload ID="SimpleImageUpload1" runat="server" AutoOpenImageEditPopupAfterUpload="False"
        CropShadowMode="Standard" EnableCancelUpload="True" EnableEdit="True" EnableRemove="True"
        EnableUpload="True" StatusMessage_InvalidImage="Hatalı Dosya" StatusMessage_InvalidImageSize="Resim Boyutu Çok Büyük"
        StatusMessage_NoImageSelected="Dosya Seçilmedi" StatusMessage_UploadError="Yükleme Hatası"
        StatusMessage_Wait="Lütfen Bekleyiniz" Text_BrowseButton="Gözat" Text_CancelUploadButton="İptal"
        Text_EditButton="Düzenle" Text_RemoveButton="Kaldır"></uc1:SimpleImageUpload>--%>
    <asp:FileUpload ID="fu_img" runat="server" />
    <asp:Button ID="btn_kaydet"  CssClass="greyishBtn bt14" runat="server" Text="Kaydet" style="float:right;" 
        onclick="btn_kaydet_Click" /><br /><br />
    <h5>
       <%= icerik_adi %> İÇİN YÜKLENMİŞ RESİMLER</h5>
    <asp:Literal ID="lt_images" runat="server"></asp:Literal>
        <link href="../Css/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.9.1/jquery-ui.js"></script>
    <style>
        label {
            display: inline-block;
            width: 5em;
            font-size: 11px;
        }
    </style>
    <script>
        jQuery(function () {
            jQuery(document).tooltip({
                track: true
            });
        });
    </script>
</asp:Content>
