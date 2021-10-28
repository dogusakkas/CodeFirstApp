<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="CodeFirstApp.Account.Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage"></asp:Literal>
        <asp:Literal runat="server" ID="SuccessfulMessage"></asp:Literal>
    </p>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label ID="LblEmail" runat="server" AssociatedControlID="TxtEmail" CssClass="col-md-2 control-label">E Mail</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" placeholder="Current Password" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="LblFullName" runat="server" AssociatedControlID="TxtFullName" CssClass="col-md-2 control-label">Full Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="TxtFullName" runat="server" CssClass="form-control" placeholder="Current Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="The full name cannot be left blank"
                    ControlToValidate="TxtFullName" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>


        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="BtnNewPassword" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="BtnSave_Click" />
            </div>
        </div>
    </div>





</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ManageContentPlaceHolder" runat="server">

    <ul class="nav nav-sidebar">
        <li class="active"><a href="/Manage">Profile</a></li>
        <li><a href="/ChangePassword">Change Password</a></li>
    </ul>

</asp:Content>
