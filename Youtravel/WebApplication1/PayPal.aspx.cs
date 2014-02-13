using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PayPal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem i in this.RadioButtonList1.Items)
                if (i.Selected == true)
                    Response.Redirect("PayPalConfirmation.aspx");
                else
                    this.LableCCRadioButton.Text=this.CustomValidator1.ErrorMessage.ToString();
        }
    }
}