<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="katalog.aspx.cs" Inherits="WebApplication1.katalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListBox ID="lbKategorii" runat="server" AutoPostBack="True"></asp:ListBox>
    <asp:Button ID="btOdberi" runat="server" Text="Odberi" OnClick="btOdberi_Click" />
</asp:Content>
