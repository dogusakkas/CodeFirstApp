<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CodeFirstApp.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <div class="form-group">
        <label for="Email">Email address</label>
        <asp:TextBox ID="Email" runat="server" type="email" class="form-control" aria-describedby="emailHelp" placeholder="Enter email"></asp:TextBox>
        <small id="FullName1" class="form-text text-muted">We'll never share your email with anyone else.</small>
    </div>

    <div class="form-group">
        <label for="Password">Password</label>
        <asp:TextBox ID="Password" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
    </div>

     <asp:Button ID="BtnRegister" runat="server" Text="Log In" CssClass="btn btn-primary" OnClick="BtnLogin_Click" />
    <br />
    <asp:TextBox ID="ErrorMesage" runat="server" type="text" class="form-control" aria-describedby="emailHelp" placeholder="Error is Coming"></asp:TextBox>

</asp:Content>
