using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using YouTravelClassLibrary.Carpeta_EN;

namespace YouTravelClassLibrary.Carpeta_CAD
{
    public class CountryCAD
    {
        /*****************************
         * CONNEXION STRING 
         * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());
   

        //Unique constructor
        public CountryCAD() { }


        //Print all the countries
/*        public ArrayList printCountriesCAD(int numContinent)
        {
            ArrayList lista = new ArrayList();

            CountryClass con = new CountryClass();

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("Select * from countryTable where continent=1", c);

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    con.NameCountry = dr["NameCountry"].ToString();

                    lista.Add(con.NameCountry);
                }
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }

            return lista;
        }
*/

        public ArrayList printCountriesCAD(int numContinent)
        {
            ArrayList lista = new ArrayList();
                DataSet bdvirtual = new DataSet();
                string connectionString = ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select distinct countryName from CountryTable order by countryName", c);
                    da.Fill(bdvirtual, "country");
                    DataTable t = new DataTable();
                    t = bdvirtual.Tables["country"];
                    for (int i = 0; i < t.Rows.Count; i++)
                    {
                        lista.Add(t.Rows[i]["countryName"].ToString());
                    }
                }
                catch (Exception ex) { }
                finally { c.Close(); }
            
        return lista;
        }
    /*
            ArrayList lista = new ArrayList();

            CountryClass con = new CountryClass();

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("Select * from countryTable where continent=1", c);

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    con.NameCountry = dr["NameCountry"].ToString();

                    lista.Add(con.NameCountry);
                }
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }

            return lista;
        }
    */
        /*DETAILs       :Add a new country in the table
          * PARAMETERS   :Name of the country, and the ID of the continent it will belong to.
          * RETURN       :TRUE if the country has been added, FALSE orthewise
          * */
        public bool addCountryCAD(String name, int numContinent)
        {
            bool added = false;
            DataSet bdvirtual = new DataSet();

            try
            {
                c.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from countryTable", c);

                adapter.Fill(bdvirtual, "countryTable");

                DataTable tabla = new DataTable();

                tabla = bdvirtual.Tables["countryTable"];

                DataRow row = tabla.NewRow();

                row[1] = name;
                row[2] = numContinent;

                tabla.Rows.Add(row);

                SqlCommandBuilder build = new SqlCommandBuilder(adapter);

                adapter.Update(bdvirtual, "FavoriteTable");

                added = true;
            }
            catch
            {
                added = false;
            }
            finally
            {
                c.Close();
            }

            return added;
        }

        /*
         * DETAILS      :Delete a country.
         * PARAMETERS   :The id of the country
         * RETURN       :TRUE if the country is deleted, FALSE orthewise
         * */
        public bool deleteCountryCAD(int paysID)
        {
            bool added = false;
            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("delete from countryTable where id = paysID", c);

                com.ExecuteNonQuery();

                added = true;

            }
            catch
            {
                added = false;
                throw;
            }
            finally
            {
                c.Close();
            }

            return added;
        }
    }
}
