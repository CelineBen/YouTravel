<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTrip.aspx.cs" Inherits="WebApplication1.AccountFolder.AddTrip" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="subcontent">
        <h2>New Trips</h2>
        <div class="dest" >
         <div style="position: absolute; width: 65%;" align="left"> 
            <p>Enter the data of the new trip</p>
            <!-- Give a name to the trip-->
            <asp:Label ID="NameNewTripLabel" runat="server" >Name of your trip:</asp:Label>
            <asp:TextBox ID="NameNewTrip" runat="server" Width="150px"></asp:TextBox>

            <!-- Pick the continent and the city of destination-->
            <h4>Destination</h4>
            <asp:DropDownList ID="ContinentList1" runat="server" CssClass="destCountry" Width="10em" > 
                <asp:ListItem Selected="True">Spain</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="CityList1" runat="server" CssClass="destCity" Width="10em">
                <asp:ListItem Selected="True">Alicante</asp:ListItem>
            </asp:DropDownList>
            <!-- The date selected-->
            <p>
                <asp:Label ID="DateLabel" runat="server" >Date: </asp:Label>

                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="DateTextBox">
                </asp:CalendarExtender>
                <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
           </p>
           <p>
               <asp:Label ID="ObservationLabel" runat="server" Text="About the trip"></asp:Label>
               </p><p>
               <asp:TextBox ID="ObservationTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
               
           </p>

            <!-- Either adds another destination to the trip or saves the trip -->
           <!-- <asp:Button ID="AddDest" runat="server" CssClass="addDest" Text="Add a destination"/> -->
            <p>
                <asp:Button ID="PreviewTripButton" runat="server" Text="Previsualization ->" 
                    onclick="PreviewTripButton_Click" />
             </p>
             </div> 

             <!--The RIGHT SIDE: show the trip you just added Or when load this page, the last trip you save with only one destination-->
            <div style="position: absolute; width: 30%; left: 65%; " align="left" id="PreviewTrip">
            
                <p align="left" 
                    style="font-size: small; text-decoration: underline; font-weight: bold; font-variant: normal; 
                    text-transform: capitalize;">LAST TRIP ADDED</p>
                <p>
                    <asp:Label ID="LastTripLabel" runat="server" BorderStyle="Ridge" 
                        BorderColor="White" BorderWidth="2px" Font-Bold="True" Height="16px" 
                        Width="169px">Name of the trip</asp:Label>
                </p>
                <p>
                    <asp:Label ID="CityLastTripLabel" runat="server" BorderStyle="Ridge" 
                        BorderColor="White" BorderWidth="2px" Font-Bold="True" Height="16px" 
                        Width="169px">City </asp:Label>
                </p>
                <p>
                    <asp:Label ID="CountryLastTripLabel" runat="server" BorderStyle="Ridge" 
                        BorderColor="White" BorderWidth="2px" Font-Bold="True" Height="16px" 
                        Width="169px">Country</asp:Label>
                </p>
                <p>
                    <asp:Label ID="DateLastTripLabel" runat="server" BorderStyle="Ridge" 
                        BorderColor="White" BorderWidth="2px" Font-Bold="True" Height="16px" 
                        Width="169px">Date of the trip</asp:Label>
                </p>
                <p>
                <asp:Label ID="ObservationsLastTripLabel" runat="server" BorderStyle="Ridge" 
                        BorderColor="White" BorderWidth="2px" Font-Bold="True" Height="16px" 
                        Width="169px">About the trip</asp:Label>
                </p>
                <asp:Button ID="SaveTrip" runat="server" CssClass="saveDest" Text="Save" 
                    onclick="SaveTrip_Click"/> 
            </div>        
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

</asp:Content>
