<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Demo02.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Product List</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" ItemType="Demo02.Product" SelectMethod="GetProducts" >
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>

            <ItemTemplate>

                <td runat="server">
                    <table>
                        <tr>
                            <td>

                                <a href="<%#:GetRouteUrl("ProductByNameRoute",new  {Name=Item.Name })   %>">
                                <image src="<%#: Item.ImagePath%>"  width="100" height="75" border="1" />
                                </a>

                            </td>

                        </tr>
                                 <tr>
                            <td>

                                <a href="<%#:GetRouteUrl("ProductByNameRoute",new  {Name=Item.Name })   %>">
                                    <%#:Item.Name%><br />
                                    <span>Price</span> <%#:Item.Price%>
                                </a>

                            </td>

                        </tr>

                    </table>

                </td>


            </ItemTemplate>

        </asp:ListView>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
