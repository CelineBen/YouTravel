<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Top10.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="subcontent">
        <h2>TOP 10 Places in Europe</h2>

        <!-- First element--> 
        <div class="element" >
            <div class="elementTitle">
                <span class="number">1</span>
                <a href="">Paris, France</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top1" CssClass="elementPhoto" runat="server" 
                    ImageUrl="~/Images3/Top10/Paris.gif"/>
                <div class="elementDescription">
                    <p>Paris is the capital and largest city of France. It is situated on the river Seine, in 
                    northern France, at the heart of the Île-de-France region (or Paris Region, French: Région 
                    parisienne). The city of Paris, within its administrative limits (the 20 arrondissements) 
                    largely unchanged since 1860, has an estimated population of 2,211,297(January 2008), 
                    but the Paris metropolitan area has a population of 12,089,098[4] (January 2008), and is 
                    one of the most populated metropolitan areas in Europe.[5] Paris was the largest city in 
                    the Western world for about 1,000 years, prior to the 19th century, and the largest in the 
                    entire world between the 16th and 19th centuries.</p>
                    <p class="more"><a href="">More...</a></p>
                </div>
            </div>
        </div>

        <!-- Second element--> 
        <div class="element" >
            <div class="elementTitle">
                <span class="number">2</span>
                <a href="">London, England</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top2" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/London.gif" />
                <div class="elementDescription">
                    <p>Paris is the capital and largest city of France. It is situated on the river Seine, in 
                    northern France, at the heart of the Île-de-France region (or Paris Region, French: Région 
                    parisienne). The city of Paris, within its administrative limits (the 20 arrondissements) 
                    largely unchanged since 1860, has an estimated population of 2,211,297(January 2008), 
                    but the Paris metropolitan area has a population of 12,089,098[4] (January 2008), and is 
                    one of the most populated metropolitan areas in Europe.[5] Paris was the largest city in 
                    the Western world for about 1,000 years, prior to the 19th century, and the largest in the 
                    entire world between the 16th and 19th centuries.</p>
                    <p class="more"><a href="">More...</a></p>
                </div>
            </div>
        </div>

        <!-- Third element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">3</span>
                <a href="">Barcelona, Spain</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top3" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Barcelona.gif" />
                    <div class="elementDescription">
                        <p>Paris is the capital and largest city of France. It is situated on the river Seine, in 
                        northern France, at the heart of the Île-de-France region (or Paris Region, French: Région 
                        parisienne). The city of Paris, within its administrative limits (the 20 arrondissements) 
                        largely unchanged since 1860, has an estimated population of 2,211,297(January 2008), 
                        but the Paris metropolitan area has a population of 12,089,098[4] (January 2008), and is 
                        one of the most populated metropolitan areas in Europe.[5] Paris was the largest city in 
                        the Western world for about 1,000 years, prior to the 19th century, and the largest in the 
                        entire world between the 16th and 19th centuries.</p>
                        <p class="more"><a href="">More...</a></p>
                    </div>
            </div>
        </div>

        <!-- Fourth element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">4</span>
                <a href="">Praha, Czech Republic</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top4" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Praga.gif" />
                <div class="elementDescription">
                    
                </div>
            </div>
        </div>

        <!-- Fifth element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">5</span>
                <a href="">Venice, Italy</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top5" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Venise.gif" />
                <div class="elementDescription">
                    
                </div>
            </div>
        </div>

        <!-- Sixth element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">6</span>
                <a href="">Firenze, Italy</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top6" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Firenze.gif" />
                <div class="elementDescription">
                    
                </div>
            </div>
        </div>

        <!-- Seventh element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">7</span>
                <a href="">Istanbul, Turkey</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top7" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Istanbul.gif" />
                <div class="elementDescription">
                    
                </div>
            </div>
        </div>

        <!-- Eigth element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">8</span>
                <a href="">Amsterdam, Netherlands</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top8" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Firenze.gif" />
                <div class="elementDescription">
                    
                </div>
            </div>
        </div>

        <!-- Nineth element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">9</span>
                <a href="">Berlin, Germany</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top9" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Berlin.gif" />
                <div class="elementDescription">
                    
                </div>
            </div>
        </div>

        <!-- Tenth element-->
        <div class="element" >
            <div class="elementTitle">
                <span class="number">1O</span>
                <a href="">Dublin, Ireland</a>
            </div>
            <div class="elementContent">
                <asp:Image ID="Top10" CssClass="elementPhoto" runat="server" ImageUrl="~/Images3/Top10/Dublin.gif" />
                <div class="elementDescription">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
