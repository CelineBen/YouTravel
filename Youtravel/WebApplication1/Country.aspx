<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="WebApplication1.Country" %>
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
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("cityNane") %>' />
                    </a>
                </div>
            </ItemTemplate>
        </asp:ListView>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server"> 
    <h2>Most Visited</h2>
    <div class="subcontent">
    <asp:ListView ID="ListView2" runat="server">
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
     </LayoutTemplate>
     <ItemTemplate>
        <div class="style2">
            <p><strong><asp:Label runat="server" Text='<%# Eval("Description") %>'></asp:Label></strong></p>
            <div class="visit">
                <asp:Image ID="Image1" runat="server" Height="99px" Width="138px" 
                    ImageUrl='<%# "~/Images3/"+Eval("Country")+"/"+Eval("Description")+"/"+Eval("Foto1") %>' /></div>
            <div class="visit">
                <asp:Image ID="Image2" runat="server" Height="99px" Width="138px" 
                    ImageUrl='<%# "~/Images3/"+Eval("Country")+"/"+Eval("Description")+"/"+Eval("Foto2") %>' /></div>
            <div class="visit">
                <asp:Image ID="Image3" runat="server" Height="99px" Width="138px" 
                    ImageUrl='<%# "~/Images3/"+Eval("Country")+"/"+Eval("Description")+"/"+Eval("Foto3") %>' /></div>
        </div>
    </ItemTemplate>
    </asp:ListView>
    </div>

    <!--We don't know why, but when we compile on our navigator without this list of br, the
    layout is not what it's supposed to be. -->

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