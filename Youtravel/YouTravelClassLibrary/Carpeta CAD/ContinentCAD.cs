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
    public class ContinentCAD
    {
        /*****************************
          * CONNEXION STRING 
          * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());
   

        //Unique constructor
        public ContinentCAD() { }


        /*DETAILS       :Print all the continents
         * RETURN       :A list of continents
         * */
        public ArrayList printAllContinentCAD()
        {
            ArrayList lista = new ArrayList();

            ContinentClass conti = new ContinentClass();

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("Select * from ContinentTable", c);

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    conti.NameContinent = dr["nameContinent"].ToString();

                    lista.Add(conti.NameContinent);
                }
            }
            catch (SqlException exp)
            {
                throw new Exception(exp.Message, null);
            }
            finally
            {
                c.Close();
            }

            return lista;
        }

        /*DETAILs       :Add a new continent in the table
          * PARAMETERS   :Name of the continent.
          * RETURN       :TRUE if the continent has been added, FALSE orthewise
          * */
        public bool addContinentCAD(String nom)
        {
            bool added = false;
            DataSet bdvirtual = new DataSet();

            try
            {
                c.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from ContinentTable", c);

                adapter.Fill(bdvirtual, "ContinentTable");

                DataTable tabla = new DataTable();

                tabla = bdvirtual.Tables["ContinentTable"];

                DataRow row = tabla.NewRow();

                row[1] = nom;

                tabla.Rows.Add(row);

                SqlCommandBuilder build = new SqlCommandBuilder(adapter);

                adapter.Update(bdvirtual, "ContinentTable");

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
         * DETAILS      :Delete a continent.
         * PARAMETERS   :The id of the continent
         * RETURN       :TRUE if the continent is deleted, FALSE orthewise
         * */
        public bool deleteContinentCAD(int contID)
        {
            bool added = false;
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete from continetTable where id = continentID", c);

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
