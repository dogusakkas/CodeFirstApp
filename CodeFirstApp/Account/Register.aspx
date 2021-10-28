<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CodeFirstApp.Account.Register" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <p class="form-group">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </p>
    <form>
        <div class="form-group">
            <label for="FullName">Full Name</label>
            <asp:TextBox ID="FullName" runat="server" type="text" class="form-control" placeholder="Full Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Your name cannot null"
             ControlToValidate="FullName" CssClass="text-danger"></asp:RequiredFieldValidator>
            
        </div>
        <div class="form-group">
            <label for="Email">Email address</label>
            <asp:TextBox ID="Email" runat="server" type="email" class="form-control" aria-describedby="emailHelp" placeholder="Enter email"></asp:TextBox>
            <small id="Email1" class="form-text text-muted">We'll never share your email with anyone else.</small><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Your email cannot null"
             ControlToValidate="Email" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="Password1">Password</label>
            <asp:TextBox ID="Password1" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Your new password cannot be left blank"
             ControlToValidate="Password1" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="PasswordAgain">Password Again</label>
            <asp:TextBox ID="PasswordAgain" runat="server" type="password" class="form-control" placeholder="Password Again"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Your verification password cannot be left blank"
             ControlToValidate="PasswordAgain" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>

        <asp:Button ID="BtnRegister" runat="server" Text="Sign Up" CssClass="btn btn-primary" OnClick="BtnRegister_Click" />


        
    </form>

</asp:Content>
