<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CodeFirstApp.Admin.Category.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <h2 class="sub-header">Add Category</h2>
    <div class="form-group">
        <asp:Label for="TxtCategoryName" runat="server">Category Name</asp:Label>
        <asp:TextBox ID="TxtCategoryName" runat="server" CssClass="form-control" placeholder="Category Name"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtCategoryName" Display="Dynamic" ForeColor="Red" >Required</asp:RequiredFieldValidator>
    </div>
    <asp:Button ID="BtnSave" runat="server" Text="Submit" CssClass="btn btn-default" OnClick="BtnSave_Click" />
    <p><asp:Literal ID="ErrorMessage" runat="server"></asp:Literal></p>

</asp:Content>
