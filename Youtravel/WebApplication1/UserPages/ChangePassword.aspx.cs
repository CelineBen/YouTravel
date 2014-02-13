using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YouTravelClassLibrary.Carpeta_EN;

namespace WebApplication1.Account
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] == null)
            {
                Response.Redirect("../Restricted.aspx");
            }
        }

        protected void ChangeUserPassword_ChangedPassword(object sender, EventArgs e)
        {
            if(ChangeUserPassword.NewPassword==ChangeUserPassword.ConfirmNewPassword)
            {
                int userID = Convert.ToInt32(Session["idUser"].ToString().Trim());
                UserClass user = new UserClass(userID);
                if (ChangeUserPassword.CurrentPassword == user.Password)
                {
                   user.Password = ChangeUserPassword.NewPassword;
                   user.updateUserInfo();    
                }
            }
        }
    }
}
