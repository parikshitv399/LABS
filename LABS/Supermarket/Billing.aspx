<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="Supermarket.Billing" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
&nbsp;&nbsp;&nbsp;
    <asp:Table ID="Table1" runat="server" Height="156px" Width="700px">
        <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
            <asp:TableCell runat="server">Model</asp:TableCell>
            <asp:TableCell runat="server">Price</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server" BackColor="White" BorderColor="#FF3300" BorderStyle="Double" HorizontalAlign="Center" VerticalAlign="Middle">
            <asp:TableCell runat="server">Realme 9 Pro +</asp:TableCell>
            <asp:TableCell runat="server">25000</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Place Order</asp:LinkButton>
</asp:Content>
