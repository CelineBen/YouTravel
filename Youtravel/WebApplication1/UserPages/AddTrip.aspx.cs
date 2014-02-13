using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YouTravelClassLibrary.Carpeta_EN;

namespace WebApplication1.AccountFolder
{
    public partial class AddTrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] == null)
            {
                Response.Redirect("../Restricted.aspx");
            }              
        }

        protected void PreviewTripButton_Click(object sender, EventArgs e)
        {
            LastTripLabel.Text           = NameNewTrip.Text;
               
            CityLastTripLabel.Text      = ContinentList1.SelectedValue;
            
            CountryLastTripLabel.Text   = CityList1.SelectedValue;
                
            DateLastTripLabel.Text  = DateTextBox.Text;

            ObservationsLastTripLabel.Text = ObservationTextBox.Text;
        }

        protected void SaveTrip_Click(object sender, EventArgs e)
        {
            TripClass trip = new TripClass();

            trip.TripName = NameNewTrip.ToString();

           // trip.TripDate = DateTextBox.ToString();

            trip.TripCountry = CityList1.SelectedValue.ToString();

            trip.TripContinent = ContinentList1.SelectedValue.ToString();

            trip.TripObservations = ObservationTextBox.ToString();
            DateTime date = DateTime.Now;
            String vide = "vide";
            trip.addTrip(vide, date, vide, true, vide, vide, vide, 2);

        }
    }
}