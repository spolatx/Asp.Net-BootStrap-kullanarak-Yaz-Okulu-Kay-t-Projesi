<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="YAZOKULUKAYIT.Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label><br />
            <asp:DropDownList ID="DdlDersler" runat="server" CssClass="form-control"></asp:DropDownList>

        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label><br />
            <asp:TextBox ID="TxtOgrenci" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <asp:Button ID="BtnTalep" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" OnClick="BtnTalep_Click" />
        <br />
    </form>
</asp:Content>
