<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBlog.aspx.cs" Inherits="WingtipToys.AddBlog" %>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="container">
        <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Title:"></asp:Label>


        <asp:TextBox ID="titlePost" runat="server" CssClass="form-control"></asp:TextBox><br />

            </div>
        <div class="form-group">

        <asp:Label ID="Label2" runat="server" Text="Main text:"></asp:Label>
     
         <asp:TextBox ID="textPost" runat="server" CssClass="form-control"></asp:TextBox><br />
        </div>
        <asp:Button ID="postPost" runat="server" Text="Add post" OnClick="AddPost"  CssClass="btn btn-primary"  />
    </div>

</asp:Content>
