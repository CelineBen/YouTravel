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
    public class TripCAD
    {
        /*****************************
         * CONNEXION STRING 
         * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());
   

        //Unique constructor
        public TripCAD() { }


        /*USED IN THE TRIP CREATION PROCESS
         * 
         * DETAILS      : This function create a new trip
         * PARAMETERS   :Name of trip, city, country, continente, date of trip, state of trip, comments about the trip, the user ID owner of the trip
         * RETURN       :TRUE if the trip has been create, FALSE orthewise
         * */
        public bool addTripCAD(String nombre, DateTime date, String notes, Boolean state, String ville, String pais, String continente, int user)
        {
            bool added = false;

            DataSet bdvirtual = new DataSet();

            try
            {
                c.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from TripTable", c);

                adapter.Fill(bdvirtual, "TripTable");

                DataTable tabla = new DataTable();

                tabla = bdvirtual.Tables["TripTable"];

                DataRow row = tabla.NewRow();

                row[1] = nombre;
                row[2] = date;
                row[3] = notes;
                row[4] = state;
                row[5] = ville;
                row[6] = pais;
                row[7] = continente;
                row[8] = user;

                tabla.Rows.Add(row);

                SqlCommandBuilder build = new SqlCommandBuilder(adapter);

                adapter.Update(bdvirtual, "TripTable");

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

        /*USED IN THE MODIFICATION OF THE TRIP'S INFORMATIONS:
         * 
         * DETAILS  : This function update the informations of a selected trip
         * RETURN   :TRUE if the trip had been updated, FALSE otherwise
         * */
        public bool updateTripCAD(int numTrip, String nombre, DateTime date, String notes, Boolean state, String ville, String pais, String continente)
        {
            bool added = false;
            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("UPDATE TripTable SET tripName = nombre, tripCity = ville, tripCountry = pais, tripState = state, tripDate = date WHERE idTrip = numTrip", c);

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


        /*USED IN THE EDITION OF TRIP
          * 
          * DETAILS      :This function edit the information of a selected trip
          * RETURN       :An object trip.
          * */
        public TripClass printOneTripCAD(int numTrip)
        {
            TripClass trip = new TripClass();

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("Select * from TripTable where idTrip = numTrip", c);

                SqlDataReader reader = com.ExecuteReader();

                trip.TripName = reader["tripName"].ToString();
                trip.TripCity = reader["tripCity"].ToString();
                trip.TripCity = reader["tripCountry"].ToString();
                trip.TripContinent = reader["tripContinent"].ToString();
                trip.TripDate = (DateTime)reader["tripDate"];
                trip.TripObservations = reader["tripObservations"].ToString();
                trip.TripState = (bool)reader["tripState"];

            }
            catch (SqlException exp)
            {
                throw new Exception(exp.Message, null);
            }
            finally
            {
                c.Close();
            }

            return trip;

        }

        /*USED IN THE EDITION OF ALL THE TRIPS OF A GIVEN USER
        * 
        * DETAILS      :Retrieve a collection of all the trip in the DB.
        * PARAMETERS   :numUser => The ID of the user
        * RETURN       :An object DATASET with all the trip
        * */
        public DataSet printAllTripCAD(int numUser)
        {

            DataSet lista = new DataSet();

            try
            {
                c.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from TripTable where numUser = idUser", c);

                adapter.Fill(lista, "TripTable");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
            finally
            {
                c.Close();
            }

            return lista;
        }


        /*USED FOR DELETE A TRIP
          * 
          * DETAILS      :Delete a trip
          * PARAMETERS   :The ID of the trip
          * RETURN       :TRUE is the trip has been deleted, FALSE orthewise
          * */
        public bool deleteTripCAD(int idTripo)
        {
            bool added = false;

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("delete from tripTable where idTrip = idtripo", c);

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
