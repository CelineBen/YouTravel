using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YouTravelClassLibrary.Carpeta_CAD;
using System.Data;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class CountryClass
    {
        int idCountry; // – PK, auto-increment
        string nameCountry;

        public int IdCountry
        {
            get { return idCountry; }
        }

        public String NameCountry
        {
            set { nameCountry = value; }
            get { return nameCountry; }
        }

        /*
         * Constructor of the class
         * */
        //Constructor by default
        public CountryClass()
        {
            nameCountry = "";
            idCountry = 0;
        }

        //Constructor with value
        public CountryClass(String nombre)
        {
            nameCountry = nombre;
        }

        //Constructor of copy
        public CountryClass(CountryClass pais)
        {
            nameCountry = pais.NameCountry;
        }

        /****************************
         * Public methods of the class
         * ***********************/

        /*DETAILS       :Print all the countries
         * PARAMETERS   :The ID of the continent
         * RETURN       :A list of countries
         * */
        public ArrayList printCountries(int numContinent)
        {
            ArrayList lista = new ArrayList();

            CountryCAD pays = new CountryCAD();
            lista=pays.printCountriesCAD(numContinent);
            return lista;
        }

        /*DETAILs       :Add a new country in the table
         * PARAMETERS   :Name of the country, and the ID of the continent it will belong to.
         * RETURN       :TRUE if the country has been added, FALSE orthewise
         * */
        public bool addCountry(String name, int numContinent)
        {
            bool added = false;

            CountryCAD pays = new CountryCAD();

            added = pays.addCountryCAD(name, numContinent);

            return added;
        }

        /*
         * DETAILS      :Delete a country.
         * PARAMETERS   :The id of the country
         * RETURN       :TRUE if the country is deleted, FALSE orthewise
         * */
        public bool deleteCountryCAD()
        {
            bool added = false;

            CountryCAD pays = new CountryCAD();

            added = pays.deleteCountryCAD(this.IdCountry);

            return added;
        }
    }
}
