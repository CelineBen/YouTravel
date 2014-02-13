<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Destinations.aspx.cs" Inherits="WebApplication1.Destinations" Theme="Skin01"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="ContainerDest">  
        <!----------------------------------------- Map ----------------------------------------->                        
        <asp:Panel ID="Panel2" runat="server" Width="50px">
            <ul id="continents">
                <li id="northamerica"><a href="Destinations.aspx"></a></li>
                <li id="southamerica"><a href="Destinations.aspx"></a></li>
                <li id="asia"><a href="Destinations.aspx"></a></li>
                <li id="australia"><a href="Destinations.aspx"></a></li>
                <li id="africa"><a href="Destinations.aspx"></a></li>
                <li id="europe"><a href="Destinations.aspx"></a></li>
                <li id="antarctic"><a href="Destinations.aspx"></a></li>
            </ul>
        </asp:Panel>    
        <!-------------------------------------- EndMap ----------------------------------------->           

        <!----------------------------------------- RadioButtons ----------------------------------------->                
        <div class="bttContNA">
            <asp:RadioButton ID="RadioButtonNA" runat="server" />
            <asp:ModalPopupExtender ID="RadioButtonNA_ModalPopupExtender" runat="server" 
                BackgroundCssClass="AJAXbuttonEU" DynamicServicePath="" Enabled="True" 
                PopupControlID="PanelNA" TargetControlID="RadioButtonNA" 
                CancelControlID="CloseLinkButtonNA" DropShadow="True" 
                ViewStateMode="Enabled">
            </asp:ModalPopupExtender>
        </div>

        <div class="bttContSA">
            <asp:RadioButton ID="RadioButtonSA" runat="server" />
            <asp:ModalPopupExtender ID="RadioButtonSA_ModalPopupExtender" runat="server" 
                BackgroundCssClass="AJAXbuttonEU" DynamicServicePath="" Enabled="True" 
                PopupControlID="PanelSA" TargetControlID="RadioButtonSA" 
                CancelControlID="CloseLinkButtonSA" DropShadow="True" 
                ViewStateMode="Enabled">
            </asp:ModalPopupExtender>
        </div>

        <div class="bttContEU">
            <asp:RadioButton ID="RadioButtonEU" runat="server" oncheckedchanged="RadioButtonEU_CheckedChanged" />
            <asp:ModalPopupExtender ID="RadioButtonEU_ModalPopupExtender" runat="server" 
                BackgroundCssClass="AJAXbuttonEU" DynamicServicePath="" Enabled="True" 
                PopupControlID="PanelEU" TargetControlID="RadioButtonEU" 
                CancelControlID="CloseLinkButtonEU" DropShadow="True" 
                ViewStateMode="Enabled">
            </asp:ModalPopupExtender> 
        </div>

        <div class="bttContAf">
            <asp:RadioButton ID="RadioButtonAf" runat="server" />
            <asp:ModalPopupExtender ID="RadioButtonAf_ModalPopupExtender" runat="server" 
                BackgroundCssClass="AJAXbuttonEU" DynamicServicePath="" Enabled="True" 
                PopupControlID="PanelAf" TargetControlID="RadioButtonAf" 
                CancelControlID="CloseLinkButtonAf" DropShadow="True" 
                ViewStateMode="Enabled">
            </asp:ModalPopupExtender>
        </div>

        <div class="bttContAsi">
            <asp:RadioButton ID="RadioButtonAsi" runat="server" />
            <asp:ModalPopupExtender ID="RadioButtonAsi_ModalPopupExtender" runat="server" 
                BackgroundCssClass="AJAXbuttonEU" DynamicServicePath="" Enabled="True" 
                PopupControlID="PanelAsi" TargetControlID="RadioButtonAsi" 
                CancelControlID="CloseLinkButtonAsi" DropShadow="True" 
                ViewStateMode="Enabled">
            </asp:ModalPopupExtender>
        </div>

        <div class="bttContAus">
            <asp:RadioButton ID="RadioButtonAus" runat="server" />
            <asp:ModalPopupExtender ID="RadioButtonAus_ModalPopupExtender" runat="server" 
                BackgroundCssClass="AJAXbuttonEU" DynamicServicePath="" Enabled="True" 
                PopupControlID="PanelAus" TargetControlID="RadioButtonAus" 
                CancelControlID="CloseLinkButtonAus" DropShadow="True" 
                ViewStateMode="Enabled">
            </asp:ModalPopupExtender>
        </div>

        <div class="bttContAnt">
            <asp:RadioButton ID="RadioButtonAnt" runat="server" />
            <asp:ModalPopupExtender ID="RadioButtonAnt_ModalPopupExtender" runat="server" 
                BackgroundCssClass="AJAXbuttonEU" DynamicServicePath="" Enabled="True" 
                PopupControlID="PanelAnt" TargetControlID="RadioButtonAnt" 
                CancelControlID="CloseLinkButtonAnt" DropShadow="True" 
                ViewStateMode="Enabled">
            </asp:ModalPopupExtender>
        </div>
        <!-------------------------------------- EndRadioButtons ----------------------------------------->                

        <div>                                       
            <!----------------------------------------- North America ----------------------------------------->
            <asp:Panel ID="PanelNA" runat="server" SkinId="skinPanelNA">
                <div class="PnlbttnClX">
                    <asp:LinkButton ID="CloseLinkButtonNA" runat="server" Height="30px" Width="30px"
                        CssClass="ClosingX"> 
                     </asp:LinkButton>
                </div>                
                <ul id="col2" >                        
                    <li class="row"><a href="Destinations.aspx">U.S.A.</a></li>
                    <li class="row"><a href="Destinations.aspx">Canada</a></li>                                      
                    <li class="row"><a href="Destinations.aspx">Antigua and Barbuda</a></li>
                    <li class="row"><a href="Destinations.aspx">Barbados</a></li>
                    <li class="row"><a href="Destinations.aspx">Cuba</a></li> 
                    <li class="row"><a href="Destinations.aspx">Dominica</a></li> 
                    <li class="row"><a href="Destinations.aspx">Mexico</a></li>                     
                </ul>
            </asp:Panel>
            <!----------------------------------------- South America ----------------------------------------->
            <asp:Panel ID="PanelSA" runat="server" SkinId="skinPanelSA">
                <div class="PnlbttnClX">
                    <asp:LinkButton ID="CloseLinkButtonSA" runat="server" Height="30px" Width="30px"
                        CssClass="ClosingX"> 
                     </asp:LinkButton>
                </div>                
                <ul id="col3" >                        
                    <li class="row"><a href="Destinations.aspx">Argentina</a></li>
                    <li class="row"><a href="Destinations.aspx">Bolivia</a></li>
                    <li class="row"><a href="Destinations.aspx">Brazil</a></li>
                    <li class="row"><a href="Destinations.aspx">Chile</a></li> 
                    <li class="row"><a href="Destinations.aspx">Colombia</a></li>
                    <li class="row"><a href="Destinations.aspx">Ecuador</a></li>
                    <li class="row"><a href="Destinations.aspx">Guyana</a></li>                    
                </ul>
            </asp:Panel>
            <!----------------------------------------- Europe ----------------------------------------->
            <asp:Panel ID="PanelEU" runat="server" SkinId="skinPanelEU">
                <div class="PnlbttnClX">
                    <asp:LinkButton ID="CloseLinkButtonEU" runat="server" Height="30px" Width="30px"
                        CssClass="ClosingX"> 
                     </asp:LinkButton>
                </div>                
                <ul id="col1" >                        
                    <li class="row"><a href="Country.aspx?Country=England">England</a></li>
                    <li class="row"><a href="Country.aspx?Country=France">France</a></li>
                    <li class="row"><a href="Destinations.aspx">Holland</a></li>
                    <li class="row"><a href="Country.aspx?Country=Italy">Italy</a></li>
                    <li class="row"><a href="Destinations.aspx">Germany</a></li>
                    <li class="row"><a href="Destinations.aspx">Portugal</a></li> 
                    <li class="row"><a href="Country.aspx?Country=Spain">Spain</a></li>   
                </ul>
            </asp:Panel>
            <!----------------------------------------- Africa ----------------------------------------->
            <asp:Panel ID="PanelAf" runat="server" SkinId="skinPanelAf">
                <div class="PnlbttnClX">
                    <asp:LinkButton ID="CloseLinkButtonAf" runat="server" Height="30px" Width="30px"
                        CssClass="ClosingX"> 
                     </asp:LinkButton>
                </div>                
                <ul id="col4" >  
                    <li class="row"><a href="Destinations.aspx">Algeria</a></li>
                    <li class="row"><a href="Destinations.aspx">Angola</a></li> 
                    <li class="row"><a href="Destinations.aspx">Cameroon</a></li> 
                    <li class="row"><a href="Destinations.aspx">Egypt</a></li> 
                    <li class="row"><a href="Destinations.aspx">Libya</a></li>
                    <li class="row"><a href="Destinations.aspx">Morroco</a></li>
                    <li class="row"><a href="Destinations.aspx">Tunisia</a></li>                    
                </ul>
            </asp:Panel>
            <!----------------------------------------- Asia ----------------------------------------->
            <asp:Panel ID="PanelAsi" runat="server" SkinId="skinPanelAsi">
                <div class="PnlbttnClX">
                    <asp:LinkButton ID="CloseLinkButtonAsi" runat="server" Height="30px" Width="30px"
                        CssClass="ClosingX"> 
                     </asp:LinkButton>
                </div>                
                <ul id="col5" >                        
                    <li class="row"><a href="Destinations.aspx">Afghanistan</a></li>
                    <li class="row"><a href="Destinations.aspx">Republic of Armenia</a></li>
                    <li class="row"><a href="Destinations.aspx">Republic of Azerbaijan</a></li>
                    <li class="row"><a href="Destinations.aspx">Kingdom of Bahrain</a></li> 
                    <li class="row"><a href="Destinations.aspx">Kingdom of Bhutan</a></li>
                    <li class="row"><a href="Destinations.aspx">Republic of India</a></li>
                    <li class="row"><a href="Destinations.aspx">State of Israel</a></li>                    
                </ul>
            </asp:Panel>
            <!----------------------------------------- Australia ----------------------------------------->
            <asp:Panel ID="PanelAus" runat="server" SkinId="skinPanelAus">
                <div class="PnlbttnClX">
                    <asp:LinkButton ID="CloseLinkButtonAus" runat="server" Height="30px" Width="30px"
                        CssClass="ClosingX"> 
                     </asp:LinkButton>
                </div>                
                <ul id="col6" >                        
                    <li class="row"><a href="Destinations.aspx">American Samoa</a></li>                    
                    <li class="row"><a href="Destinations.aspx">Australia</a></li>
                    <li class="row"><a href="Destinations.aspx">Baker Island</a></li> 
                    <li class="row"><a href="Destinations.aspx">Cook Islands</a></li>
                    <li class="row"><a href="Destinations.aspx">Fiji</a></li>
                    <li class="row"><a href="Destinations.aspx">Nauru</a></li>         
                    <li class="row"><a href="Destinations.aspx">Palau</a></li>           
                </ul>
            </asp:Panel>
            <!----------------------------------------- Antarctic ----------------------------------------->
            <asp:Panel ID="PanelAnt" runat="server" SkinId="skinPanelAnt">
                <div class="PnlbttnClX">
                    <asp:LinkButton ID="CloseLinkButtonAnt" runat="server" Height="30px" Width="30px"
                        CssClass="ClosingX"> 
                     </asp:LinkButton>
                </div>                
                <ul id="col7" >                        
                    <li class="row"><a href="Destinations.aspx">Bouvet Island</a></li>
                    <li class="row"><a href="Destinations.aspx">French Southern Territories</a></li>
                    <li class="row"><a href="Destinations.aspx">Heard Island and McDonald Islands</a></li>
                    <li class="row"><a href="Destinations.aspx">South Georgia and the South Sandwich Islands</a></li>                  
                </ul>
            </asp:Panel>
        </div>
            
    </div>
</asp:Content>
