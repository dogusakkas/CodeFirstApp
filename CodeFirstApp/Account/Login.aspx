<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CodeFirstApp.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <p class="text-danger">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </p>

    <div class="form-group">
        <label for="Email">Email address</label>
        <asp:TextBox ID="Email" runat="server" type="email" class="form-control" aria-describedby="emailHelp" placeholder="Enter email"></asp:TextBox>
        <small id="Email1" class="form-text text-muted">We'll never share your email with anyone else.</small><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Email incorrect please try again"
            CssClass="text-danger" ControlToValidate="Email"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" CssClass="text-danger" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" ErrorMessage="Incorrect email address"></asp:RegularExpressionValidator>
    </div>

    <div class="form-group">
        <label for="Password">Password</label>
        <asp:TextBox ID="Password" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="Password cannot left blank"></asp:RequiredFieldValidator>
    </div>

     <asp:Button ID="BtnRegister" runat="server" Text="Log In" CssClass="btn btn-primary" OnClick="BtnLogin_Click" />
    <br />
    <asp:TextBox ID="ErrorMesage" runat="server" type="text" class="form-control" aria-describedby="emailHelp" placeholder="Error is Coming"></asp:TextBox>

</asp:Content>
