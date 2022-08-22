<%@ Page Language="C#" MasterPageFile="~/Error.Master" AutoEventWireup="true" CodeBehind="GenericException.aspx.cs" Inherits="Supermarket.GenericException" %>

<asp:Content runat="server" ContentPlaceHolderID="ErrorID">
    <h3>Something went wrong...</h3>
    <hr />
    <h5>Your ticket ID for further reference is <%= Guid.NewGuid() %></h5>
    <p>
        Please contact support at <a href="https://www.youtube.com/watch?v=dQw4w9WgXcQ">parikshitverma@kpmg.com</a>
    </p>

</asp:Content>
