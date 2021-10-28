<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CodeFirstApp.Account.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage"></asp:Literal>
    </p>
    <div class="form-group">
        <label for="CurrentPassword">Password</label>
        <asp:TextBox ID="CurrentPassword" runat="server" type="password" class="form-control" placeholder="Current Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Your current password cannot be left blank"
            ControlToValidate="CurrentPassword" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="NewPassword">Password</label>
        <asp:TextBox ID="NewPassword" runat="server" type="password" class="form-control" placeholder="New Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="The new password cannot be left blank"
            ControlToValidate="NewPassword" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="ConfirmNewPassword">Password</label>
        <asp:TextBox ID="ConfirmNewPassword" runat="server" type="password" class="form-control" placeholder="Confim New Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="The new password cannot be left blank"
            ControlToValidate="ConfirmNewPassword" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>

    <asp:Button ID="BtnNewPassword" runat="server" Text="Save New Password" CssClass="btn btn-primary" OnClick="BtnNewPassword_Click" />
    <br />
    

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ManageContentPlaceHolder" runat="server">

    <ul class="nav nav-sidebar">
        <li><a href="/Manage">Profile</a></li>
        <li class="active"><a href="/ChangePassword">Change Password</a></li>
    </ul>

</asp:Content>
