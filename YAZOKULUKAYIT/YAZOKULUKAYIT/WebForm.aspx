<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="YAZOKULUKAYIT.WebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <a href="WebForm.aspx"></a>
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <strong>
                <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numarası:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <strong>
                <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifresi:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <strong>
                <asp:Label for="TxtFotograf" runat="server" Text="Öğrenci Fotograf:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="BtnKaydet" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>
