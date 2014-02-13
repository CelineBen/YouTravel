using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using YouTravelClassLibrary.Carpeta_EN;
using System.Data;

namespace YouTravelClassLibrary.Carpeta_CAD
{
    class RestaurantCAD
    {
        /*****************************
         * CONNEXION STRING 
         * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());

        RestaurantClass resto = new RestaurantClass();

        public DataSet printRestaurantsCAD(String cityName)
        {
            DataSet bdvirtual = new DataSet();
            string connectionString = ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString();
            SqlConnection c = new SqlConnection(connectionString);
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from RestaurantTable where city in (select idCity from CityTable where cityNane=\'" + cityName + "\')", c);
                da.Fill(bdvirtual, "restaurant");

            }
            catch (Exception ex) { }
            finally { c.Close(); }
            return bdvirtual;
        }
    }
}
