<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CodeFirstApp.Admin.Category.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <a href="/AddCategory" class="btn btn-success">Add New Item</a>
    <hr />
    <asp:GridView ID="CategoryList" runat="server" AutoGenerateColumns="False" CssClass="table table-hover">
        <Columns>
            <asp:BoundField DataField="CategoryID" HeaderText="ID" />
            <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
            <asp:BoundField DataField="ProductCount" HeaderText="Product Count" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="/DetailsCategory?id=<%# Eval("CategoryID") %>" class="btn btn-primary">Details</a>
                    <a href="/DeleteCategory?id=<%# Eval("CategoryID") %>" class="btn btn-danger" commandname="Delete" commandargument='<%# Eval("CategoryID") %>' onclientclick="return confirm('The Category will be deleted, are you sure?')">Delete</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>

</asp:Content>
