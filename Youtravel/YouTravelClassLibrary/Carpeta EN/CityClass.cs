using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YouTravelClassLibrary.Carpeta_CAD;
using System.Data;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class CityClass
    {
        private int idCity;// – PK, auto-increment
        private string nameCity;

        public int IdCidty
        {
            get { return idCity; }
        }

        public String NameCity
        {
            get { return nameCity; }
            set { nameCity = value; }
        }

        public CityClass()
        {
            nameCity = "";
            idCity = 0;
        }

        public CityClass(String city, int id)
        {
            nameCity = city;
            idCity = id;
        }

        public CityClass(CityClass city)
        {
            nameCity = city.nameCity;
            idCity = city.IdCidty;
        }

        /****************************
        * Public methods of the class
        * ***********************/

        /*DETAILS       :Print all the cities
         * PARAMETERS   :The ID of the country
         * RETURN       :A list of cities
         * */
        public DataSet printCities(String countryName)
        {
            DataSet lista = new DataSet();
            try
            {
                CityCAD city = new CityCAD();
                lista = city.printCitiesCAD(countryName);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }

        public ArrayList ArrayCities(String countryName)
        {
            ArrayList list=new ArrayList();
            DataSet d=printCities(countryName);
            DataTable t = new DataTable();
            t = d.Tables["country"];
            for (int i = 0; i < t.Rows.Count; i++)
            {
                list.Add(t.Rows[i]["cityNane"].ToString());
            }
            return list;
        }

        /*DETAILs       :Add a new city in the table
          * PARAMETERS   :Name of the country, and the ID of the continent it will belong to.
          * RETURN       :TRUE if the city has been added, FALSE orthewise
          * */
        public bool addCity(String name, int numPais)
        {
            bool added = false;

            CityCAD city = new CityCAD();

            added = city.addCityCAD(name, numPais);

            return added;
        }

        /*
         * DETAILS      :Delete a city.
         * PARAMETERS   :The id of the city
         * RETURN       :TRUE if the city is deleted, FALSE orthewise
         * */
        public bool deleteCity()
        {
            bool added = false;

            CityCAD city = new CityCAD();

            added = city.deleteCityCAD(this.IdCidty);

            return added;
        }
    }
}
