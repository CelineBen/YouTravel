using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using YouTravelClassLibrary.Carpeta_CAD;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class TripClass
    {

        int idTrip;
        String tripName;
        DateTime tripDate;
        String tripObservations;//Comment about the trips
        Boolean tripState;//Tell us if the trip is pending or not
        String tripCity;
        String tripCountry;
        String tripContinent;

        /****************************
         * PROPERTIES
         * *************************/
        public int Idtrip
        {
            get { return idTrip; }
        }

        public String TripName
        {
            set { tripName = value; }
            get { return tripName; }
        }

        public String TripCity
        {
            set { tripCity = value; }
            get { return tripCity; }
        }

        public String TripCountry
        {
            set { tripCountry = value; }
            get { return tripCountry; }
        }

        public String TripContinent
        {
            set { TripContinent = value; }
            get { return TripContinent; }
        }
        public DateTime TripDate
        {
            set { tripDate = value; }
            get { return tripDate; }
        }

        public Boolean TripState
        {
            set { tripState = value; }
            get { return tripState; }
        }

        public String TripObservations
        {
            set { tripObservations = value; }
            get { return tripObservations; }
        }

        /*************************************************
         * CONSTRUCTORS
         * *************************************************/
        //By default
        public TripClass()
        {
            tripName = "";
            idTrip = 0;
            tripName = "";
            tripCity = "";
            tripCountry = "";
            tripContinent = "";
            tripDate = DateTime.MaxValue;
            tripState = false;//By default each trip is pending.
            tripObservations = "";
        }

        //With values
        public TripClass(String nombre, int numTrip, String ville, String pais, String continente, DateTime date, Boolean state, String notes)
        {
            tripName = nombre;
            idTrip = numTrip;
            tripCity = ville;
            tripCountry = pais;
            tripContinent = continente;
            tripDate = date;
            tripState = state;
            tripObservations = notes;
        }

        //Constructor of copy
        public TripClass(TripClass trip)
        {
            tripName = trip.TripName;
            idTrip = trip.Idtrip;
            tripCity = trip.TripCity;
            tripCountry = trip.TripCountry;
            tripContinent = trip.TripContinent;
            tripDate = trip.TripDate;
            tripState = trip.TripState;
            tripObservations = trip.TripObservations;
        }

        /************************************
         * METHODS OF CLASS
         * **********************************/

        /*USED IN THE TRIP CREATION PROCESS
         * 
         * DETAILS      : This function create a new trip
         * PARAMETERS   :Name of trip, city, country, continente, date of trip, state of trip, comments about the trip, the user ID owner of the trip
         * RETURN       :TRUE if the trip has been create, FALSE orthewise
         * */
        public bool addTrip(String nombre, DateTime date, String notes, Boolean state, String ville, String pais, String continente, int user)
        {
            bool added = false;

            TripCAD trip = new TripCAD();

            added = trip.addTripCAD(nombre, date, notes, state, ville, pais, continente, user);

            return added;
        }

        /*USED IN THE MODIFICATION OF THE TRIP'S INFORMATIONS:
         * 
         * DETAILS  : This function update the informations of a selected trip
         * RETURN   :TRUE if the trip had been updated, FALSE otherwise
         * */
        public bool updateTrip(int numTrip, String nombre, DateTime date, String notes, Boolean state, String ville, String pais, String continente)
        {
            bool updated = false;

            TripCAD trip = new TripCAD();

            updated = trip.updateTripCAD(numTrip, nombre, date, notes, state, ville, pais, continente);

            return updated;
        }


        /*USED IN THE EDITION OF TRIP
         * 
         * DETAILS      :This function edit the information of a selected trip
         * RETURN       :An object trip.
         * */
        public TripClass printOneTrip(int numTrip)
        {

            TripClass trip = new TripClass();

            TripCAD tripDB = new TripCAD();

            trip = tripDB.printOneTripCAD(numTrip);

            return trip;
        }


        /*USED IN THE EDITION OF ALL THE TRIPS OF A GIVEN USER
         * 
         * DETAILS      :Retrieve a collection of all the trip in the DB.
         * PARAMETERS   :numUser => The ID of the user
         * RETURN       :An object DATASET with all the trip
         * */
        public DataSet printAllTrip(int numUser)
        {
            DataSet bdvirtual = new DataSet();

            TripCAD trip = new TripCAD();

            bdvirtual = trip.printAllTripCAD(numUser);

            return bdvirtual;
        }

        /*USED FOR DELETE A TRIP
         * 
         * DETAILS      :Delete a trip
         * PARAMETERS   :The ID of the trip
         * RETURN       :TRUE is the trip has been deleted, FALSE orthewise
         * */
        public bool deleteTrip(int numTrip)
        {
            bool added = false;

            TripCAD trip = new TripCAD();

            added = trip.deleteTripCAD(numTrip);

            return added;
        }

    }
}
