<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CodeFirstApp.Admin.Category.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <asp:GridView ID="CategoryList" runat="server" AutoGenerateColumns="False" CssClass="table table-hover">
        <Columns>
            <asp:BoundField DataField="CategoryID" HeaderText="ID" />
            <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="/Details?id=<%# Eval("CategoryID") %>" class="btn btn-danger">Details</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>

</asp:Content>
