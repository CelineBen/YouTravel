<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
        <h3> Advice </h3>
        <asp:AdRotator ID="AdRotator1" runat="server"
            Target="_self"
            AdvertisementFile="~/App_Data/advertisement.xml" Width="200" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <h2>News</h2>
        <div class="subcontent">
        <div class="style2">
            This website has been created to facilitate the planning of your holiday, giving advice and recommendations.<br />
            <br />
        </div>
        <div class="style2">
            <strong>Notification: 28-04-2012</strong><br />
            <br />
            New trip from Madrid to Paris, 5 days.
        </div>
        <div class="style2">
            <strong>Notificatión: 15-04-2012</strong><br />
            <br />
            New cities added: Sevilla, Manchester, Munich.
        </div>
        <div class="style2">
            <strong>Notificatión: 4-04-2012</strong><br />
            <br />
            Holly Week! Visit Malaga.
        </div>
        <div class="style2">
            <strong>Notificatión: 29-03-2012</strong><br />
            <br />
            General strike be careful with the public transport.
        </div>
    </div>
    
</asp:Content>
