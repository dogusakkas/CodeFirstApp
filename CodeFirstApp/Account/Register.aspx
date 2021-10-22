<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CodeFirstApp.Account.Register" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <form>
        <div class="form-group">
            <label for="FullName">Full Name</label>
            <asp:TextBox ID="FullName" runat="server" type="text" class="form-control" placeholder="Full Name"></asp:TextBox>
            
        </div>
        <div class="form-group">
            <label for="Email">Email address</label>
            <asp:TextBox ID="Email" runat="server" type="email" class="form-control" aria-describedby="emailHelp" placeholder="Enter email"></asp:TextBox>
            <small id="FullName1" class="form-text text-muted">We'll never share your email with anyone else.</small>
        </div>
        <div class="form-group">
            <label for="Password1">Password</label>
            <asp:TextBox ID="Password1" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="PasswordAgain">Password Again</label>
            <asp:TextBox ID="PasswordAgain" runat="server" type="password" class="form-control" placeholder="Password Again"></asp:TextBox>
        </div>

        <asp:Button ID="BtnRegister" runat="server" Text="Sign Up" CssClass="btn btn-primary" OnClick="BtnRegister_Click" />


        <asp:TextBox ID="ErrorMesage" runat="server" type="text" class="form-control" aria-describedby="emailHelp" placeholder="test"></asp:TextBox>
    </form>

</asp:Content>
