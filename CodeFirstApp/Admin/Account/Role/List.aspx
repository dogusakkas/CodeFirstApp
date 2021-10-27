<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CodeFirstApp.Admin.Account.Role.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

        <asp:Label ID="ErrorMessage" runat="server" Text="Label" CssClass="text-danger"></asp:Label>

    <asp:ListView ID="UserRoles" runat="server">
        <LayoutTemplate>
            <div class="table-responsive">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Role Name</th>
                            <th>User Count </th>
                            <th>Delete Role</th>
                        </tr>
                    </thead>
                </table>
                <tbody>
                    <asp:PlaceHolder ID="itemplaceholder" runat="server"></asp:PlaceHolder>
                </tbody>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td></td>
                <td><%# Eval("RoleName") %></td>
                <td><%# Eval("UserCount") %></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Delete" OnCommand="DeleteRole" CommandName="DeleteRole" CommandArgument='<%# Eval("RoleName") %>' CssClass="btn btn-danger" OnClientClick="return confirm('The role will be deleted, are you sure?')" />
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>


</asp:Content>
