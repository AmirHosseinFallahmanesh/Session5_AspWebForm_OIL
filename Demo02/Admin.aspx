<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Demo02.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Product Name : <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    </div>
        <div>
        Product Detail : <asp:TextBox ID="DetailTextBox" mode="multiline" runat="server"></asp:TextBox>
    </div>
    <div>
        Product Price : <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
    </div>

        <div>
       Image: <asp:FileUpload ID="FileUpload1" runat="server" />
    </div>
    <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Add Product" />
</asp:Content>
