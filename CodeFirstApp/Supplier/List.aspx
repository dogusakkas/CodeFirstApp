<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CodeFirstApp.Supplier.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

        <h2 class="sub-header">Supplier List</h2>

    <asp:ListView ID="SupplierListView" runat="server">
        <LayoutTemplate>
            <div class="table-responsive">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>Company Name</th>
                            <th>Contact Name</th>
                            <th>Details</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
        </LayoutTemplate>
        <ItemTemplate>
            <tr id="itemPlaceHolder" runat="server">
                <td><%# Eval("CompanyName") %></td>
                <td><%# Eval("ContactName") %></td>
                <td><a href='Details.aspx?id=<%# Eval("SupplierID") %>' class="btn btn-primary">Details</a></td>
            </tr>
        </ItemTemplate>
    </asp:ListView>


</asp:Content>
