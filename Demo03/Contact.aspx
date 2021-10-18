<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Demo03.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Get View State" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="GetSessonState" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <div>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get Cookie" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <div>
            </div>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="GetApplicationState" />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>
