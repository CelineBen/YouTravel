<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserMain.aspx.cs" Inherits="WebApplication1.AccountFolder.UserMain" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="subcontent">
        <h2> Welcome to your profile page.</h2>
        <div style="text-align:center;">
        <asp:Calendar ID="ProfileCalendar" runat="server" BorderStyle="Ridge" 
        BorderColor="#0000CC" ></asp:Calendar>

           <h3>Your visited places</h3>

            <p>
                <asp:Image ID="MountainImage" runat="server" Width="80px" Height="60px" 
                    ImageUrl="~/Images3/taj_mahal.jpg" />
                <asp:Image ID="Image1" runat="server" Width="80px" Height="60px" 
                    ImageUrl="~/Images3/playa.jpg" ImageAlign="Top" />
                <asp:Image ID="BeachImage" runat="server" Width="80px" Height="60px" 
                    ImageUrl="~/Images3/lago.jpg" ImageAlign="Top" />
            </p>
                 
            <p>
                <asp:Image ID="DesertImage" runat="server" Width="80px" Height="60px" 
                    ImageUrl="~/Images3/Spain/Monuments/teatro romano merida.jpg" />
                <asp:Image ID="TownImage" runat="server" Width="80px" Height="60px" 
                    ImageUrl="~/Images3/cascada.jpg" ImageAlign="Top"/>
                <asp:Image ID="Image2" runat="server" Width="80px" Height="60px" 
                    ImageUrl="~/Images3/castillo.jpg" ImageAlign="Top" />
            </p>
        </div>
    </div>
</asp:Content>
