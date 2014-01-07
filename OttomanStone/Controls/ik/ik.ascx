<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ik.ascx.cs" Inherits="ik" %>

<style>
    td {
        padding: 3px;
        width: 100px;
        text-align: left;
        font-size: 11px;
    }

    .span {
        color: Red;
    }

    .baslik-ik {
        width: 99%;
        background-color: #DA251C;
        text-align: left;
        font-weight: bold;
        font-size: 12px;
        padding: 5px;
        margin: 5px;
        color: #FFF;
    }

    ._text {
    }
</style>

<b>
    <asp:Label ID="lb_info" runat="server" ForeColor="Red"></asp:Label></b>
<table cellpadding="3" cellspacing="3" border="0">
    <thead>
        <div class="baslik-ik">
            <asp:Label ID="lb_kisi" runat="server" Text="lb_kisi"></asp:Label></div>
    </thead>
    <tr>
        <td>
            <asp:Label ID="lb_ad" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_ad" runat="server" CssClass="_text" ValidationGroup="infos"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rq_ad" runat="server" ValidationGroup="infos" CssClass="span" ControlToValidate="tx_ad"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_cins" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rad_cins" runat="server" RepeatDirection="Horizontal" type="radio">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_dtarih" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_dtarih" runat="server" CssClass="_text" ValidationGroup="infos"></asp:TextBox>
            <%--<asp:CalendarExtender ID="dt_tarih" runat="server" TargetControlID="tx_dtarih" DefaultView="Years"
                Enabled="True" Animated="true">
            </asp:CalendarExtender>--%>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rq_dtarih" runat="server" ErrorMessage="" ControlToValidate="tx_dtarih"
                ValidationGroup="infos" CssClass="span"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_dyer" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_dyer" runat="server" CssClass="_text" ValidationGroup="infos"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rq_yer" runat="server" ErrorMessage="" ControlToValidate="tx_dyer"
                ValidationGroup="infos" CssClass="span"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_medeni" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rad_medeni" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_uyruk" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_uyruk" runat="server" CssClass="_text" ValidationGroup="infos"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rq_uyruk" runat="server" ErrorMessage="" ControlToValidate="tx_uyruk"
                ValidationGroup="infos" CssClass="span"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_asker" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rad_asker" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_kan" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_kan" runat="server" CssClass="_text" ValidationGroup="infos"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rq_kan" runat="server" ErrorMessage="" ControlToValidate="tx_kan"
                ValidationGroup="infos" CssClass="span"></asp:RequiredFieldValidator>
        </td>
    </tr>
</table>
<table cellpadding="3" cellspacing="3" border="0">
    <thead>
        <div class="baslik-ik">
            <asp:Label ID="lb_ilet" runat="server" Text="lb_kisi"></asp:Label></div>
    </thead>
    <tr>
        <td>
            <asp:Label ID="lb_adres" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_adres" TextMode="MultiLine" runat="server" Rows="5" Columns="80"
                CssClass="uniform"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_tel" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_tel" runat="server" CssClass="_text" ValidationGroup="infos"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rq_tel" runat="server" ErrorMessage="" ControlToValidate="tx_tel"
                ValidationGroup="infos" CssClass="span"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_cep" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_cep" runat="server" CssClass="_text" ValidationGroup="infos"></asp:TextBox>
        </td>
        <td colspan="5">
            <asp:RequiredFieldValidator ID="rq_cep" runat="server" ErrorMessage="" ControlToValidate="tx_cep"
                ValidationGroup="infos" CssClass="span"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lb_mail" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tx_mail" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
</table>
<table cellpadding="3" cellspacing="3" border="0">
    <thead>
        <div class="baslik-ik">
            <asp:Label ID="lb_ogren" runat="server" Text="lb_kisi"></asp:Label></div>
    </thead>
    <tr>
        <td>
            <asp:Label ID="lb_okul" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_bolum" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_bitirme" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_okul1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_bolum1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_bitirme1" runat="server" CssClass="_text"></asp:TextBox>
            <%--<asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tx_bitirme1"
                DefaultView="Years" Enabled="True" Animated="true">
            </asp:CalendarExtender>--%>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_okul2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_bolum2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_bitirme2" runat="server" CssClass="_text"></asp:TextBox>
            <%--<asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="tx_bitirme2"
                DefaultView="Years" Enabled="True" Animated="true">
            </asp:CalendarExtender>--%>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_okul3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_bolum3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_bitirme3" runat="server" CssClass="_text"></asp:TextBox>
            <%--<asp:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="tx_bitirme3"
                DefaultView="Years" Enabled="True" Animated="true">
            </asp:CalendarExtender>--%>
        </td>
    </tr>
</table>
<table cellpadding="3" cellspacing="3" border="0">
    <thead>
        <div class="baslik-ik">
            <asp:Label ID="lb_dilbil" runat="server" Text="lb_kisi"></asp:Label></div>
    </thead>
    <tr>
        <td>
            <asp:Label ID="lb_dil" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_oku" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_yaz" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_konus" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_dil1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <select runat="server" id="s1">
            </select>
        </td>
        <td>
            <select runat="server" id="s2">
            </select>
        </td>
        <td>
            <select runat="server" id="s3">
            </select>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_dil2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <select runat="server" id="s4">
            </select>
        </td>
        <td>
            <select runat="server" id="s5">
            </select>
        </td>
        <td>
            <select runat="server" id="s6">
            </select>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_dil3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <select runat="server" id="s7">
            </select>
        </td>
        <td>
            <select runat="server" id="s8">
            </select>
        </td>
        <td>
            <select runat="server" id="s9">
            </select>
        </td>
    </tr>
</table>
<table cellpadding="3" cellspacing="3" border="0">
    <thead>
        <div class="baslik-ik">
            <asp:Label ID="lb_staj" runat="server" Text="lb_kisi"></asp:Label></div>
    </thead>
    <tr>
        <td>
            <asp:Label ID="lb_kurum" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_konu" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_s_sure" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_kurum1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_konu1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_s_sure1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_kurum2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_konu2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_s_sure2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_kurum3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_konu3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_s_sure3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
</table>
<table cellpadding="3" cellspacing="3" border="0">
    <thead>
        <div class="baslik-ik">
            <asp:Label ID="lb_deneyim" runat="server" Text="lb_kisi"></asp:Label></div>
    </thead>
    <tr>
        <td>
            <asp:Label ID="lb_sirket" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_d_bolum" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_d_sure" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_sirket1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_d_bolum1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_d_sure1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_sirket2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_d_bolum2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_d_sure2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_sirket3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_d_bolum3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_d_sure3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
</table>
<table cellpadding="3" cellspacing="3" border="0">
    <thead>
        <div class="baslik-ik">
            <asp:Label ID="lb_ref" runat="server" Text="lb_kisi"></asp:Label></div>
    </thead>
    <tr>
        <td>
            <asp:Label ID="lb_r_ad" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_r_unvan" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lb_r_telefon" runat="server" Text="lb_ad" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_r_ad1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_r_unvan1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_r_tel1" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_r_ad" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_r_unvan2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_r_tel2" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tx_r_ad3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_r_unvan3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tx_r_tel3" runat="server" CssClass="_text"></asp:TextBox>
        </td>
    </tr>
</table>
<asp:CheckBox ID="chk_onay" runat="server" CssClass="checked" />
<br />
<br />
<asp:Button ID="btn_gonder" runat="server" Text="Gönder" CssClass="button" ValidationGroup="infos"
    OnClick="btn_gonder_Click" />