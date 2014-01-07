<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="summary.aspx.cs" Inherits="icebear_v2.ContentMenagement.summary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="girisalani">
        <div class="welcome1">
            <h5>Hoşgeldiniz, sitenizi yönetmek için bir menü seçin </h5>
        </div>
        <a href="../ContentMenagement/kategoriler.aspx">
            <div class="boxes" style="margin-left:200px;">
                <img src="../images/icons/kategoriler.jpg" width="120" height="120" />
            </div>
        </a>
        <a href="../ContentMenagement/content.aspx">
            <div class="boxes">
                <img src="../images/icons/sayfalar.jpg" width="120" height="120" />
            </div>
        </a>
        <a href="../ContentMenagement/banner.aspx">
            <div class="boxes">
                <img src="../images/icons/banner.jpg" width="120" height="120" />
            </div>
        </a>
        <a href="../ContentMenagement/users.aspx">
            <div class="boxes">
                <img src="../images/icons/kullanici.jpg" width="120" height="120" />
            </div>
        </a>
        <div style="clear: left"></div>
    </div>
</asp:Content>
