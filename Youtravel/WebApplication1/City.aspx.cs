using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using YouTravelClassLibrary.Carpeta_EN;
using System.Collections;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        String countryName;
        String cityName;
        int idCity;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] != null)
            {
                countryName = Request.QueryString["Country"];
                cityName = Request.QueryString["City"];
                LabelCountry.Text = countryName;
                LabelCity.Text = cityName;

                Load_Cities();

                Load_Hotels();
                Load_Restaurants();
                Load_ThingsToDo();
            }
            else
            {
                Response.Redirect("Restricted.aspx");
            }
        }

        private void Load_Cities()
        {
            try
            {
                CityClass ci = new CityClass();
                ListView1.DataSource = ci.printCities(countryName);
                ListView1.DataBind();
            }
            catch (Exception ex) { }
        }
/*        private void Load_Cities()
        {
            CityClass ci = new CityClass();
            ListView1.DataSource = ci.printCities(countryName);
            ListView1.DataBind();
        }
*/
        private void Load_ThingsToDo()
        {
            try
            {
            ThingsToDoClass t = new ThingsToDoClass();
            ListView2.DataSource = t.printThingsToDo(cityName);
            ListView2.DataBind();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Load_Restaurants()
        {
            try
            {
                RestaurantClass r = new RestaurantClass();
                ListView3.DataSource = r.printRestaurants(cityName);
                ListView3.DataBind();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Load_Hotels()
        {
                HotelClass h = new HotelClass();
                ListView4.DataSource = h.printHotels(cityName);
                ListView4.DataBind();
        }

        public bool InsertFavorite()
        {
            bool cambiado = false;
            FavoriteClass f = new FavoriteClass();
            f.addFavorite((int)Session["idUser"], cityName, countryName);
            cambiado = true;
            return cambiado;
        }

        //FavoriteImage_Click
        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            InsertFavorite();
        }
    }
}