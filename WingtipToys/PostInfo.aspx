<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostInfo.aspx.cs" Inherits="WingtipToys.PostInfo" %>
<asp:Content ID="PostContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group h2" style="text-align:center; ">
        <asp:Label class="form-group h2" style="color: black " ID ="Label1" runat="server" />
    </div>
        
        <p class="h4">
            <asp:Label ID="TextBox1" style="color:black" runat="server" />
        </p>
        <p class="text-right">
            <asp:Label ID="Label2"  runat="server" Text='<%= data %>' />
        </p>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Add comment :"/>
        <asp:TextBox ID="writeCommentText" runat="server" CssClass="form-control"/> <br />
        <asp:Button ID="postComment" runat="server" Text="Add comment" OnClick="AddComment" CssClass="btn btn-primary" />
    </div>
        <asp:Repeater ID="CommentPost" runat="server">
        <ItemTemplate>
            <div style="border:1px solid black; border-radius:15px; margin-bottom: 10px; width:50%; margin: 10px auto;">
                
            <div class="h4" style="text-align:center">
                <asp:Label ID="CommentText" style="color: black" runat="server" CssClass="post-title" Text='<%#Eval("CommentText")%>' />

            </div>
            <div style="text-align:center">
                <asp:Label ID="Label1" runat="server" Cssclass="text-justify mb-0"  Text='<%#Eval("CommentUserName")%>' />
            </div>
            <div style="text-align:right; margin-right:10px;">
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("CommentData")%>' />
            </div>
</div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
