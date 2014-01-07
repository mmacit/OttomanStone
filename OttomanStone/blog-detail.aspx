<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/ottoman.Master" AutoEventWireup="true" CodeBehind="blog-detail.aspx.cs" Inherits="OttomanStone.blog_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #home-bg {
            background-position-y: -485px !important;
        }

        .get-in-touch {
            float: none;
        }

        .gallery .textwidget {
            margin: 0 0px 18px 0;
        }

        .entry #container {
            float: left;
            width: 960px !important;
        }

        .navigation.blog {
            margin: 20px 0 0 0;
            width: 950px;
        }
    </style>
    <div class="entry">
        <div id="container">
            <div class="double-header">
                <span class="first-head"><%= baslik %></span>
            </div>
            <div class="entry-content">
                <a class="alignleft highslide" href="/files/images/<%= id.ToString() %>/<%= resim %>" onclick="return hs.expand(this, galleryOptions)">
                    <img src="/files/images/<%= id.ToString() %>/<%= resim %>" height="272" alt="Highslide JS"
                        title="Click to enlarge" /></a>
                
                <%= yazi %>
            </div>

            <div class="related-post">
       				<h2>İlgili Yazılar</h2>
                <asp:Literal ID="lt_ilgiliyazi" runat="server"></asp:Literal>
     			</div>
        </div>
    </div>
</asp:Content>
