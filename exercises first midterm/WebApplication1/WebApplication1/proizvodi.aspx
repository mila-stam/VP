<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="proizvodi.aspx.cs" Inherits="WebApplication1.proizvodi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblKategorija" runat="server" Text=" "></asp:Label>
    </div>
    <div>
        <asp:ListBox ID="lbNaslovi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbNaslovi_selectedIndex"></asp:ListBox>
    </div>

    <div>
        <asp:ListBox ID="lbCeni" runat="server" AutoPostBack="True"></asp:ListBox>
    </div>

    <asp:Button ID="btnDodadi" runat="server" Text="Dodadi" OnClick="btnDodadi_Click" />

    <div>
        <asp:ListBox ID="lbKorpa" runat="server"></asp:ListBox>

    </div>
    <div>
        Total selektirani:
        <asp:Label ID="lblSelected" runat="server" Text=" "></asp:Label>
    </div>

    <div>
        Vkupen total:
        <asp:Label ID="lblVkupno" runat="server" Text=" "></asp:Label>
    </div>


    <div>
        <asp:Button ID="btnBack" runat="server" Text="nazad" OnClick="btnBack_Click" />
    </div>
</asp:Content>
