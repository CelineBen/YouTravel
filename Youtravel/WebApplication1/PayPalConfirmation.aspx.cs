using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PayPalConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                //Control placeHolder = PreviousPage.Controls[3].FindControl("ContentPlaceHolder3");
                Control placeHolder = PreviousPage.Controls[0].FindControl("Content3");
                TextBox SourceTextBox = (TextBox)placeHolder.FindControl("TextBox4");
                if (SourceTextBox != null)
                {
                    Label4.Text = SourceTextBox.Text;
                }
                else Label4.Text = SourceTextBox.Text.ToString();
            }
        }
    }
}