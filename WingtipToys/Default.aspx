<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WingtipToys._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="BlogPosts" runat="server">
        <ItemTemplate>
            <a href="PostInfo.aspx?id=<%#Eval("PostId")%>">
            <div class="container post-preview" style="border:1px solid black; border-radius:15px; margin-bottom: 20px; cursor:pointer">
                
            <div class="form-group h2" style="text-align:center">
                <asp:Label ID="lblCustomerId" style="color: black" runat="server" CssClass="post-title" Text='<%#Eval("title")%>' />

            </div>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Cssclass="text-justify mb-0"  Text='<%#Eval("text")%>' />
            </div>
            <div style="text-align:right">
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("date")%>' />
            </div>
</div>
                </a>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
