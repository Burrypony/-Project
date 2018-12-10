<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WingtipToys._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="BlogPosts" runat="server">
        <ItemTemplate>
            <div class="container" style="border:1px solid black; border-radius:15px; margin-bottom: 20px; cursor:pointer">
            <div class="form-group"">
                <asp:Label ID="lblCustomerId" runat="server" Text='<%#Eval("title")%>' />

            </div>
            <div class="form-group"">
                <asp:Label ID="Label1" runat="server" Cssclass="text-justify"  Text='<%#Eval("text")%>' />
            </div>
            <div class="form-group"">
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("date")%>' />
            </div>
</div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
