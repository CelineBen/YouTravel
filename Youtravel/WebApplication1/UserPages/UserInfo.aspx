<%@ Page Title="PersonalData" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="WebApplication1.Account.RegisterLocalization" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div class="subcontent">
    <h2>Your Account</h2>
    <table style="margin: 0px auto;">
        <tr>
            <td align="right">
                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="UserName" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                    ControlToValidate="UserName" ErrorMessage="User Name is required." 
                    ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="FirstNameLabel" runat="server" 
                    AssociatedControlID="FirstName">First Name:</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="FirstName" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="FirstNameRequired" runat="server" 
                    ControlToValidate="UserName" ErrorMessage="First Name is required." 
                    ToolTip="First Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="LastNameLabel" runat="server" AssociatedControlID="LastName">Last Name:</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="LastName" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LastNameRequired" runat="server" 
                    ControlToValidate="LastName" ErrorMessage="Last Name is required." 
                    ToolTip="Last Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Email" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" 
                    ControlToValidate="Email" ErrorMessage="E-mail is required." 
                    ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="EmailRegularExpression" runat="server" ControlToValidate="Email" 
                ErrorMessage="E-mail invalid" ValidationExpression="^[a-z0-9._-]+@[a-z0-9._-]{2,}\.[a-z]{2,4}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="DateOfBirthLabel" runat="server" AssociatedControlID="DateOfBirth">Date of Birth (DD/MM/YYY):</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="DateOfBirth" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="DateOfBirthRequired" runat="server" 
                    ControlToValidate="DateOfBirth" ErrorMessage="Date of birth is required." 
                    ToolTip="Date of birth is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="DateOfBirth" 
                ErrorMessage="Date of birth invalid" ValidationExpression="^(\d{2})\/(\d{2})\/(\d{4})$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="CountryLabel" runat="server" AssociatedControlID="Country">Country:</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Country" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CountryRequired" runat="server" 
                    ControlToValidate="Country" ErrorMessage="Country is required." 
                    ToolTip="Country is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Button ID="ModifyData" runat="server" Text="Modify" CssClass="button" 
                    onclick="ModifyData_Click" />
            </td>
            <td>
                <asp:Button ID="Cancel" runat="server" Text="Cancel" CssClass="button" 
                PostBackUrl="~/UserPages/UserMain.aspx" onclick="Cancel_Click"/>
            </td>
        </tr>
    </table>
  </div>
</asp:Content>