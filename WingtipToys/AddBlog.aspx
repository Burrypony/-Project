<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBlog.aspx.cs" Inherits="WingtipToys.AddBlog" %>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


    <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>


    <asp:TextBox ID="titlePost" runat="server" Height="18px" Width="237px"></asp:TextBox><br />

    <asp:Label ID="Label2" runat="server" Text="Main text"></asp:Label>
     
     <asp:TextBox ID="textPost" runat="server" Height="17px" Width="211px"></asp:TextBox><br />

    <asp:Button ID="postPost" runat="server" Text="Button" OnClick="AddPost" Height="26px" />


</asp:Content>
