using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using YouTravelClassLibrary.Carpeta_EN;


namespace WebApplication1
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PayPal.aspx");
        }

   
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                Login loginControl = (Login)LoginView1.FindControl("Login1");
                String username = loginControl.UserName.ToString();
                String password = loginControl.Password.ToString();
                UserClass user = new UserClass();
                int idUser = user.ValidateAccess(username, password);
                if (idUser > 0)
                {
                    Session.Add("idUser", idUser);
                    FormsAuthentication.SetAuthCookie(username, true);
                    //FormsAuthentication.RedirectFromLoginPage(username,true);
                    //Response.Redirect("../UserPages/UserMain.aspx");
                }
            }
            catch (Exception ex) {}
        }

        protected void LogoutLink_OnClick(object sender, EventArgs args)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            Session.RemoveAll();
        }
            
    }
}
