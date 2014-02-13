<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFavorite.aspx.cs" Inherits="WebApplication1.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="subcontent">
        <h2>My Favorites</h2>
        <table align="center">
                <th>
                        <td width="50%">
            <div class="favorite">
                    <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
            </LayoutTemplate>
            <ItemTemplate>
                <div class="cities">
                <a href='<%# String.Concat("../City.aspx?Country="+Eval("country")+"&City="+Eval("city")).Replace(" ", "") %>' >
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("city") %>'/>
                    </a>
                </div>
            </ItemTemplate>
        </asp:ListView>        
          </div>
   </th>
    <th>
        <div class="favoriteAdd">
            <!-- Pick the continent and the city of favorite destination-->
            <br />
            <asp:Label ID="FavoriteContinentLabel" runat="server" CssClass="favoritelabel" >Country</asp:Label>
            <br />
            <asp:DropDownList ID="FavoriteCountryList" runat="server" 
                CssClass="destCountry" Width="15em"
                AutoPostBack="true" EnableViewState="true" onselectedindexchanged="FavoriteCountryList_SelectedIndexChanged"
                >
            </asp:DropDownList>
            <br />
            <asp:Label ID="FavoriteCityLabel" runat="server" CssClass="favoritelabel" >City</asp:Label>
            <br />
            <asp:DropDownList ID="FavoriteCityList" runat="server" CssClass="destCity" Width="15em"
                AutoPostBack="true" EnableViewState="true" onselectedindexchanged="FavoriteCityList_SelectedIndexChanged" 
                > 
                
            </asp:DropDownList>
            <!-- Saves favorite -->
            <br />
            <br />
            <asp:Button ID="SaveFavorite" runat="server" CssClass="save" Text="Add" 
                onclick="SaveFavorite_Click"/>         
        </div>
        </th>
</tr>
        </table>
     </div>
</asp:Content>
