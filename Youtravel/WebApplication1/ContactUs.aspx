<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="subcontent">
        <h2>Contact Us</h2>

        <!-- Shows whether the message has been sent or not after clicking on SEND button-->        
        <asp:Label ID="AnswerMessage" runat="server" CssClass="contactlabel" ></asp:Label>

        <!-- User's Name--> 
        <div class="contact">
            <asp:Label ID="Name" runat="server" CssClass="contactlabel">Your name</asp:Label>
            <asp:TextBox ID="YourName" runat="server" CssClass="contacttext" Width="20em">
            </asp:TextBox>   
        </div>

        <!-- User's Email --> 
        <div class="contact">
            <asp:Label ID="Email" runat="server" CssClass="contactlabel">Your email</asp:Label>
            <asp:TextBox ID="YourEmail" runat="server" CssClass="contacttext" Width="20em">
            </asp:TextBox>
            <asp:RegularExpressionValidator ID="EmailRegularExpression" runat="server" 
                ControlToValidate="YourEmail" ErrorMessage="E-mail invalid" 
                ValidationExpression="^[a-z0-9._-]+@[a-z0-9._-]{2,}\.[a-z]{2,4}$">
            </asp:RegularExpressionValidator>
        </div>

        <!-- User's Message --> 
        <div class="contact">
            <asp:Label ID="Message" runat="server" CssClass="contactlabel">Your message</asp:Label>
            <asp:TextBox ID="YourMessage" runat="server" CssClass="contacttext" Width="30em" 
                            TextMode="MultiLine" Rows="10">
            </asp:TextBox>       
        </div>
        
        <!-- Submit Button --> 
        <asp:Button ID="ContactUsSubmit" runat="server" Text="Send" 
            CssClass="button" style="position:relative; left: 60%;" onclick="ContactUsSubmit_Click"/>
    </div>
</asp:Content>
