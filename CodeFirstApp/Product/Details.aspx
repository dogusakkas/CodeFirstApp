<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="CodeFirstApp.Product.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <div class="row">
        <div class="col-md-4">
            <img data-src="holder.js/400x400/auto/sky" class="img-responsive" alt="Generic placeholder thumbnail">
        </div>
        <div class="col-md-8">
            <h3><asp:Label ID="LblProductName" runat="server"></asp:Label></h3><br />
            <asp:Label ID="LblUnitPrice" runat="server"></asp:Label><br />
            <asp:Label ID="LblStock" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
