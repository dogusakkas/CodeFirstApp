<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CodeFirstApp.Admin.Account.Role.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

        <h2 class="sub-header">Role</h2>
    <div class="form-group">
        <label for="NewRole">Role Name</label>
        <asp:TextBox ID="NewRole" runat="server" CssClass="form-control" placeholder="Role Name"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NewRole" Display="Dynamic" ForeColor="Red" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>

    </div>
    <asp:Button ID="BtnSave" runat="server" Text="Submit" CssClass="btn btn-default" OnClick="AddRole" />
    <asp:Label ID="ErrorMessage" runat="server" CssClass="text-danger"></asp:Label>


</asp:Content>
