<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Supermarket.Dashboard" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        WELCOME TO ONLINE SUPERMARKET!</p>
    <p>
        What would you want to shop for today?</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>--Select--</asp:ListItem>
            <asp:ListItem>Mobile Phone</asp:ListItem>
            <asp:ListItem>Power Bank</asp:ListItem>
            <asp:ListItem>Earphones</asp:ListItem>
            <asp:ListItem>Laptops</asp:ListItem>
            <asp:ListItem>Bluetooth Speakers</asp:ListItem>
        </asp:DropDownList>
    </p>
    <hr />
    <p>
        What is the price range you are going for?</p>
    <p>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>--Select--</asp:ListItem>
            <asp:ListItem>1000-2000</asp:ListItem>
            <asp:ListItem>2000-3000</asp:ListItem>
            <asp:ListItem>3000-4000</asp:ListItem>
            <asp:ListItem>4000-5000</asp:ListItem>
            <asp:ListItem>6000-7000</asp:ListItem>
            <asp:ListItem>7000-8000</asp:ListItem>
            <asp:ListItem>8000-9000</asp:ListItem>
            <asp:ListItem>9000-10000</asp:ListItem>
        </asp:DropDownList>
    </p>
    <hr />
    <asp:Button ID="dshbrdBtn" runat="server" Text="Submit" OnClick="dshbrdBtn_Click" />
    <br />
</asp:Content>
