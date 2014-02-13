using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YouTravelClassLibrary.Carpeta_EN;

namespace WebApplication1.Account
{
    public partial class RegisterLocalization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] != null)
            {
                if (!IsPostBack)
                {
                    showData();
                }
            }
            else
            {
                Response.Redirect("../Restricted.aspx");
            }
        }

        private void showData()
        {
            int userID = Convert.ToInt32(Session["idUser"].ToString().Trim());
            UserClass user = new UserClass(userID);
            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            Email.Text = user.Email;
            Country.Text = user.Country;
            user.getUserInformation();
            UserName.Text=user.UserName;
            FirstName.Text=user.FirstName;
            LastName.Text=user.LastName;
            Email.Text=user.Email;
            DateTime dt = user.DateOfBirth;
            DateOfBirth.Text = String.Format("{0:dd/MM/yyyy}", dt);
            Country.Text=user.Country;
        }

        protected void ModifyData_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Session["idUser"].ToString().Trim());
            UserClass user = new UserClass(userID);
            user.UserName=UserName.Text;
            user.FirstName=FirstName.Text;
            user.LastName=LastName.Text;
            user.Email = Email.Text;
            user.DateOfBirth=Convert.ToDateTime(DateOfBirth.Text);
            user.Country=Country.Text;
            user.updateUserInfo();
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
