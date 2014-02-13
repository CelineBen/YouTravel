<%@ Page Title="Cambiar contraseña" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="ChangePassword.aspx.cs" Inherits="WebApplication1.Account.ChangePassword" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Change Password</h2>
    <asp:ChangePassword ID="ChangeUserPassword" runat="server"
        ChangePasswordTitleText="" 
        onchangedpassword="ChangeUserPassword_ChangedPassword">
        <CancelButtonStyle CssClass="button" />
        <ChangePasswordButtonStyle CssClass="button" />
        <TitleTextStyle Font-Bold="True" />
    </asp:ChangePassword>

</asp:Content>
