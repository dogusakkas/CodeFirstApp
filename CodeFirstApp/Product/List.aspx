<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Page.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CodeFirstApp.Product.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <h2 class="page-header">Product List</h2>

    <div class="row placeholders">

        <asp:ListView ID="ListViewProduct" runat="server">
            <ItemTemplate>
                <div class="col-xs-6 col-sm-3 placeholder">
                    <img data-src="holder.js/200x200/auto/sky" class="img-responsive" alt="Generic placeholder thumbnail">
                    <h4><%# Eval("UnitPrice") %></h4>
                    <span class="text-muted"> <a href="Details.aspx?ID=<%# Eval("ProductID") %>"><%# Eval("ProductName") %></a></span>
                </div>
            </ItemTemplate>
        </asp:ListView>

        <%--<asp:Repeater ID="RepeaterProduct" runat="server">
            <ItemTemplate>
                <div class="col-xs-6 col-sm-3 placeholder">
                    <img data-src="holder.js/200x200/auto/sky" class="img-responsive" alt="Generic placeholder thumbnail">
                    <h4><%# Eval("UnitPrice") %></h4>
                    <span class="text-muted"><%# Eval("ProductName") %></span>
                </div>
            </ItemTemplate>
        </asp:Repeater>--%>
    </div>

</asp:Content>
