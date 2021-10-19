<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="CodeFirstApp.Supplier.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

  <h2> Company Name : <asp:Label ID="LblCompanyName" runat="server" Text="Label"></asp:Label></h2>
    <hr />

    <address>
        <strong><asp:Label ID="LblContactName" runat="server" Text="Label"></asp:Label></strong><br>
        <asp:Label ID="LblAddress" runat="server" Text="Label"></asp:Label><br>
        <asp:Label ID="LblCity" runat="server" Text="Label"></asp:Label>, <asp:Label ID="LblPostalCode" runat="server" Text="Label"></asp:Label><br>
        <abbr title="Phone"><asp:Label ID="LblPhone" runat="server" Text="Label"></asp:Label></abbr>
    </address>

    <address>
        <strong><asp:Label ID="LblHomePage" runat="server" Text="Label"></asp:Label></strong>

    </address>

</asp:Content>
