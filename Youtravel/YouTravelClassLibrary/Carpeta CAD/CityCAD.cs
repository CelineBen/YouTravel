using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using YouTravelClassLibrary.Carpeta_EN;

namespace YouTravelClassLibrary.Carpeta_CAD
{
    public class CityCAD
    {
        /*****************************
         * CONNEXION STRING 
         * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());
   

        //Unique constructor
        public CityCAD() { }

        public DataSet printCitiesCAD(String countryName)
        {
            DataSet bdvirtual = new DataSet();
            string connectionString = ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString();
            SqlConnection c = new SqlConnection(connectionString);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select cityNane, countryName=\'"+countryName+"\' from CityTable where country= (select idCountry from CountryTable where countryName=\'" + countryName + "\') order by cityNane", c);
                da.Fill(bdvirtual, "country");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            finally { c.Close(); }
            return bdvirtual;
        }
        
        
        /*DETAILs       :Add a new city in the table
          * PARAMETERS   :Name of the country, and the ID of the continent it will belong to.
          * RETURN       :TRUE if the city has been added, FALSE orthewise
          * */
        public bool addCityCAD(String name, int numPais)
        {
            bool added = false;
            DataSet bdvirtual = new DataSet();

            try
            {
                c.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from citeTable", c);

                adapter.Fill(bdvirtual, "citeTable");

                DataTable tabla = new DataTable();

                tabla = bdvirtual.Tables["citeTable"];

                DataRow row = tabla.NewRow();

                row[1] = name;
                row[2] = numPais;

                tabla.Rows.Add(row);

                SqlCommandBuilder build = new SqlCommandBuilder(adapter);

                adapter.Update(bdvirtual, "citeTable");

                added = true;
            }
            catch (SqlException exp)
            {
                added = false;
                throw new Exception(exp.Message, null);
            }
            finally
            {
                c.Close();
            }

            return added;
        }

        /*
        * DETAILS      :Delete a city.
        * PARAMETERS   :The id of the city
        * RETURN       :TRUE if the city is deleted, FALSE orthewise
        * */
        public bool deleteCityCAD(int cityID)
        {
            bool added = false;
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete from cityTable where id = cityID", c);

                com.ExecuteNonQuery();

                added = true;

            }
            catch (SqlException exp)
            {
                added = false;
                throw new Exception(exp.Message, null);
            }
            finally
            {
                c.Close();
            }

            return added;
        }
    }
}
