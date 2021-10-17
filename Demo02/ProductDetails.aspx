<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Demo02.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:FormView ID="FormView1" runat="server" ItemType="Demo02.Product" SelectMethod="GetProduct" RenderOuterTable="false">
         <ItemTemplate>
                    <div>
                    <h1><%#:Item.Name %> </h1>
                </div>
                <br />
             <table>
                 <tr>
                     <td>
                        <image src="<%#:Item.ImagePath%>"  width="300" height="75" border="1"  alt="<%#:Item.Name %>"/>

                     </td>
                     <td style="vertical-align:top;text-align:left">
                         <b>Description: </b><br />
                         <%#:Item.Desciption %><br />
                          <b>Price: </b>
                          <%#:Item.Price %><br />
                     </td>

                 </tr>
        
             </table>
             <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Add To Cart" />
         </ItemTemplate>





    </asp:FormView>



</asp:Content>
