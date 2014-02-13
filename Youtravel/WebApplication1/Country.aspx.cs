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

namespace WebApplication1
{
    public partial class Country : System.Web.UI.Page
    {
        public String countryName;

        protected void Page_Load(object sender, EventArgs e)
        {
            countryName = Request.QueryString["Country"];
            LabelCountry.Text = countryName;
            Load_Cities();
            Load_MostVisited();
        }

        private void Load_Cities()
        {
            try
            {
                CityClass ci = new CityClass();
                ListView1.DataSource = ci.printCities(countryName);
                ListView1.DataBind();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Load_MostVisited()
        {
            try
            {
                MostVisitedClass mv = new MostVisitedClass();
                ListView2.DataSource = mv.getMostVisited(countryName);
                ListView2.DataBind();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
       }
    }
}