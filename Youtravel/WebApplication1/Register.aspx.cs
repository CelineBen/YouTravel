using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using YouTravelClassLibrary.Carpeta_EN;

namespace WebApplication1.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            UserClass user = new UserClass();

          /*  user.FirstName = "Firmin";
            user.LastName = "Firmino";
            user.UserName = create*/
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            //FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);

            /*string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (String.IsNullOrEmpty(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect(continueUrl);*/
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            UserClass tempUser = new UserClass();
            String nick=UserName.Text;
            String password=Password.Text;
            String password2=ConfirmPassword.Text;
            String name=FirstName.Text;
            String subname=LastName.Text;
            String email=Email.Text;
            DateTime birth = Convert.ToDateTime(DateOfBirth.Text);
            String country=Country.Text;
            if (tempUser.ValidateLogin(nick))
            {
                UserClass newUser = new UserClass(nick, subname, name, email, password, birth, country);
                newUser.CreateNewUser();
            }
        }
    }
}
