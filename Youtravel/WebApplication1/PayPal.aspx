<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PayPal.aspx.cs" Inherits="WebApplication1.PayPal" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelMaster" runat="server" CssClass="PANELMasterPP" 
        HorizontalAlign="Left">   
     
    <asp:Panel ID="Panel1" runat="server" CssClass="PPPanel1">
        <asp:Image ID="Image1" runat="server" Height="32px" ImageUrl="~/Images3/PayPalImages/PayPal00.png" Width="214px" />                        
    </asp:Panel>   

    <div class="paypalP">
        YouTravel Team Appreciate your support!
        <!--p>YouTravel Team Appreciate your support!</p-->
    </div>       
            
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="494px" 
        Height="56px" CssClass="PPRadioButtonList1">
        <asp:ListItem Value="CCard">Credit Card</asp:ListItem>
        <asp:ListItem>Visa</asp:ListItem>
        <asp:ListItem Value="MCard">Master Card</asp:ListItem>
        <asp:ListItem Value="AExpress">American Express</asp:ListItem>
        <asp:ListItem Value="PPal">Pay Pal</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="LableCCRadioButton" runat="server"  
            CssClass="CCErrorRadioBttn"></asp:Label>

    <asp:Panel ID="Panel3" runat="server" CssClass="PPPanel3">
        <asp:Label ID="Label4" runat="server" Text="Amount:" AssociatedControlID="TextBox4"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Height="15px" Width="100px" CssClass="focusing"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="euros" AssociatedControlID="TextBox4"></asp:Label>
    </asp:Panel>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
        CssClass="PPRegularExpressionValidator4" ControlToValidate="TextBox4" 
        ErrorMessage="* Please, no decimals! *" ValidationExpression="\d+" 
        SetFocusOnError="True" ValidationGroup="PayPal1">
    </asp:RegularExpressionValidator>
        
    <asp:Panel ID="Panel2" runat="server" Width="493px" CssClass="PPPanel2">            
        <asp:Label ID="Label1" runat="server" Text="Card Number: " AssociatedControlID="TextBox1"></asp:Label>         
        <asp:TextBox ID="TextBox1" runat="server" Height="15px" Width="164px" CssClass="focusing"></asp:TextBox>               
        <asp:Label ID="Label2" runat="server" Text="  Security Code: " AssociatedControlID="TextBox2"></asp:Label>         
        <asp:TextBox ID="TextBox2" runat="server" Height="15px" Width="25px" CssClass="focusing"></asp:TextBox>
        <br/>            
        <asp:Label ID="Label3" runat="server" Text="Expires: " AssociatedControlID="TextBox3"></asp:Label>  
        <asp:TextBox ID="TextBox3" runat="server" Height="15px" Width="45px" CssClass="focusing">__/ __ </asp:TextBox>       
        <asp:CalendarExtender ID="CalendarExtender1" runat="server" 
            TargetControlID="TextBox3" DaysModeTitleFormat="MMMM dd, yyyy" 
            Format="MM / yy">  
        </asp:CalendarExtender>
    </asp:Panel>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        CssClass="PPRegularExpressionValidator1" ControlToValidate="TextBox1" 
        ErrorMessage="* xxxx-xxxx-xx-xxxxxxxxxx *" ValidationExpression="\d{4}-\d{4}-\d{2}-\d{10}" 
        SetFocusOnError="True" ValidationGroup="PayPal1">
    </asp:RegularExpressionValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        CssClass="PPRegularExpressionValidator2" ControlToValidate="TextBox2" 
        ErrorMessage="* xxx *" ValidationExpression="\d{3}" 
        SetFocusOnError="True" ValidationGroup="PayPal1">
    </asp:RegularExpressionValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
        CssClass="PPRegularExpressionValidator3" ControlToValidate="TextBox3" 
        ErrorMessage="e.g.: * 02 / 12 *" ValidationExpression="\d{2} / \d{2}" 
        SetFocusOnError="True" ValidationGroup="PayPal1">
    </asp:RegularExpressionValidator>

    <asp:Button ID="Button1" runat="server" CssClass="buttonPayPal" 
            onclick="Button1_Click" ValidationGroup="PayPal1" Text="Submit" /> 
    
    <!------------------------------ CHECKING EMPTY CELLS ------------------------------>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="You missed a cell!" ValidationGroup="PayPal1" 
            SetFocusOnError="True" ControlToValidate="TextBox1" CssClass="EMPTYCELL1">
    </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="You missed a cell!" ValidationGroup="PayPal1" 
            SetFocusOnError="True" ControlToValidate="TextBox2" CssClass="EMPTYCELL2">
    </asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="You missed a cell!" ValidationGroup="PayPal1" 
            SetFocusOnError="True" ControlToValidate="TextBox3" CssClass="EMPTYCELL3">
    </asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ErrorMessage="You missed a cell!" ValidationGroup="PayPal1" 
            SetFocusOnError="True" ControlToValidate="TextBox4" CssClass="EMPTYCELL4">
    </asp:RequiredFieldValidator>

    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="* Please, choose the Credit Card! *"></asp:CustomValidator>
      
    
     
    </asp:Panel>
</asp:Content>

