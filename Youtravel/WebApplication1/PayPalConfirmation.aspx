<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PayPalConfirmation.aspx.cs" Inherits="WebApplication1.PayPalConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelMasterConfirmation" runat="server" CssClass="PANELMasterPP" 
        HorizontalAlign="Left">  
        <asp:Panel ID="Panel1" runat="server" CssClass="PPPanel1">
            <asp:Image ID="Image1" runat="server" Height="32px" ImageUrl="~/Images3/PayPalImages/PayPal00.png" Width="214px" />                        
        </asp:Panel>   

        <div class="paypalP">
            Thank you very much, indeed!
        </div>    
        
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

    </asp:Panel>
</asp:Content>

