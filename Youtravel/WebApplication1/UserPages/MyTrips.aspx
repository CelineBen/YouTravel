<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyTrips.aspx.cs" Inherits="WebApplication1.AccountFolder.MyTrips" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style5
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>My Trips</h2>

<div>
    <table class="style5" id="ListTripTable">
    
        <tr  align="left" bgcolor="#999966">
            <td>
                NAME OF TRIP</td>
            <td>
                COUNTRY</td>
            <td>
                CITY</td>
            <td>
                DATE</td>
            <td>
                OBSERVATION</td>
        </tr>
        <tr>
            <td>
                Ibiza Summer</td>
            <td>
                Spain</td>
            <td>
                Ibiza</td>
            <td>
                10/07/2012</td>
            <td>
                Just 5 days. Just a personal<br />
                trip.<br />
               </td>
        </tr>
        <tr>
            <td>
                Noisy </td>
            <td>
                UK</td>
            <td>
                Dragon</td>
            <td>
                28/06/2012</td>
            <td>
                -</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>
<div>
<p style="position: absolute; left: auto; padding-left: 20px">
    <asp:Button ID="deleteTripButton" runat="server" Text="Delete" 
        onclick="deleteTripButton_Click" BorderStyle="Groove" 
                BorderWidth="2px" Font-Bold="True" Font-Size="Small"/>
</p>
<p style="position: absolute; left: auto; padding-left: 100px">
    <asp:Button ID="Button1" runat="server" Text="Add" 
        onclick="addTripButton_Click" BorderStyle="Groove" 
                BorderWidth="2px" Font-Bold="True" Font-Size="Small"/>
</p>
<p style="position: absolute; right: auto; width: 50%; left: 50%;">
    <asp:Button ID="editTripButton" runat="server" Text="Edit" 
         BorderStyle="Groove" 
                BorderWidth="2px" Font-Bold="True" Font-Size="Small" 
        onclick="editTripButton_Click"/>
</p>
</div>
<br />
<br />
<br />
<br />
<br />
</asp:Content>
