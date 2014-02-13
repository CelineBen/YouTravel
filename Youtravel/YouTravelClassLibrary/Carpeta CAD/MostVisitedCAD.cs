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
    class MostVisitedCAD
    {
        /*****************************
         * CONNEXION STRING 
         * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());

        MostVisitedClass resto = new MostVisitedClass();

        public DataSet getMostVisitedCAD(String countryName)
        {
            DataSet bdvirtual = new DataSet();
            string connectionString = ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from MostVisited where Country=\'" + countryName + "\'" + " order by Country", c);
                da.Fill(bdvirtual, "MostVisited");
            }
            catch (Exception ex){}
            finally
            {
                c.Close();
            }
            return bdvirtual;
        }
    }
}
