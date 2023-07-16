<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YAZOKULUKAYIT.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordored table-hover ">
        <tr>
            <th>Öğrenci Id</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id")%></td>
                        <td><%#Eval("ad") %></td>
                        <td><%#Eval("soyad") %></td>
                        <td><%#Eval("numara") %></td>
                        <td><%#Eval("sifre") %></td>
                        <td><%#Eval("fotograf") %></td>
                        <td><%#Eval("bakiye") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID="+ Eval("id")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OGRID="+ Eval("id")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>

                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
