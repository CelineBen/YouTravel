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
    public class FavoriteCAD
    {
        /*****************************
          * CONNEXION STRING 
          * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());
   

        //Unique constructor
        public FavoriteCAD() { }

        /**DETAILS      :Print all the favorites of a given user
         * PARAMETERS   :The ID of the user
         * RETURN       :A collection (DATASET) of favorites
         * */
        public DataSet printMyFavoritesCAD(int userID)
        {
            FavoriteClass fav = new FavoriteClass();
            DataSet bdvirtual = new DataSet();
            string connectionString = ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Favorite where idUser =\'" + userID + "\' order by city", c);
                adapter.Fill(bdvirtual, "favorite");
            }
            catch (Exception ex) { }
            finally { c.Close(); }
            return bdvirtual;
        }

        /*USED IN ADDING FAVORITE PROCESS
         * 
         * DETAILS      :Add a favorite in the DB
         * PARAMETERS   :The name of favorite, the city, the country and the ID of the user
         * RETURN       :TRUE is the favorite is added, FALSE orthewise
         * */
        public bool addFavoriteCAD(int idUser, String city, String country)
        {
            bool added = false;
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Favorite", c);
                adapter.Fill(bdvirtual, "FavoriteTable");
                DataTable tabla = new DataTable();
                tabla = bdvirtual.Tables["FavoriteTable"];
                DataRow row = tabla.NewRow();
                row[0] = idUser;
                row[1] = city;
                row[2] = country;
                tabla.Rows.Add(row);
                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(bdvirtual, "FavoriteTable");
                added = true;
            }
            catch (Exception ex) {added = false;}
            finally{ c.Close(); }
            return added;
        }

        /*DELETE A FAVORITE
        * 
        * DETAILS      :Delete a favorite
        * PARAMETERS   :Id of the favorite
        * RETURN       :TRUE is the favorite is delete, FALSE orthewise
        * */
        public bool deleteFavoriteCAD(int favID)
        {
            bool added = false;
            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("delete from favoriteTable where id = favID", c);

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
