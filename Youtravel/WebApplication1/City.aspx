<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="City.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
    <h3>
        <asp:Label ID="LabelCountry" runat="server" Text=""></asp:Label>
    </h3>
        <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                <div class="cities">
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div class="cities">
                <a href='<%# String.Concat("City.aspx?Country="+Eval("countryName")+"&City="+Eval("cityNane")).Replace(" ", "") %>' >
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("cityNane") %>'/>
                    </a>
                </div>
            </ItemTemplate>
        </asp:ListView>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="subcontent">
            <h2>
                <asp:Label ID="LabelCity" runat="server" Text=""></asp:Label>
                <asp:ImageButton ID="favoriteImage" runat="server"
                DescriptionUrl="Add to favorites" ImageUrl="~/Images3/favoritos.png" 
                    Width="30" Height="30" onclick="ImageButton1_Click1"/>
            </h2>
            <div class="element">                  
                <div class="elementTitle">
                    <span class="number">#</span>
                    <a href="">Things to do</a>
                </div>
                <ul class="wheretogo">
                    <asp:ListView ID="ListView2" runat="server">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li><a href=""><%#Eval("name") %></a></li>
                    </ItemTemplate>
                    </asp:ListView>
                </ul>   
                <p class="more"><a href="">More...</a></p>
            </div>
            <div class="element">
                <div class="elementTitle">
                    <span class="number">#</span>
                    <a href="">Restaurants</a>
                </div>      
                <ul class="wheretogo">
                    <asp:ListView ID="ListView3" runat="server">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li><a href=""><%#Eval("name") %></a></li>
                    </ItemTemplate>
                    </asp:ListView>
                </ul>   
                <p class="more"><a href="">More...</a></p>
            </div>
            <div class="element">
                <div class="elementTitle">
                    <span class="number">#</span>
                    <a href="">Hotels</a>
                </div> 
                <ul class="wheretogo">
                    <asp:ListView ID="ListView4" runat="server">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li><a href=""><%#Eval("name") %></a></li>
                    </ItemTemplate>
                    </asp:ListView>
                </ul>  
                <p class="more"><a href="">More...</a></p> 
            </div>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
