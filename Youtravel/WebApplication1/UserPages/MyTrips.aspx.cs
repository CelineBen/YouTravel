using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YouTravelClassLibrary.Carpeta_EN;

namespace WebApplication1.AccountFolder
{
    public partial class MyTrips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] != null)
            {
                LoadTrip();
            }
            else
            {
                Response.Redirect("../Restricted.aspx");
            }
        }

        protected void deleteTripButton_Click(object sender, EventArgs e)
        {
            TripClass trip = new TripClass();

            int numSeleccionado = 0;

            trip.deleteTrip(numSeleccionado);
        }

        //The idea is that, on popup windows will allows a user to make the change
        protected void editTripButton_Click(object sender, EventArgs e)
        {

        }

        //Save the modification
        protected void SaveModification_Clik(object sender, EventArgs e)
        { 
            
        }

        protected void addTripButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MemberPages/AddTrip.aspx");
        }

        private void LoadTrip()
        { }
    }
}