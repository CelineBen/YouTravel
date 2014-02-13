using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YouTravelClassLibrary.Carpeta_CAD;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class RestaurantClass
    {
        int idRestaurant;
        String nameRestaurant;
        String addressRestaurant;

        /*********
         * Properties
         * **********/

        public int IdRestaurant
        {
            get { return idRestaurant; }
        }

        public String NameRestaurant
        {
            get { return nameRestaurant; }
            set { nameRestaurant = value; }
        }

        public String AddressRestaurant
        {
            get { return addressRestaurant; }
            set { addressRestaurant = value; }
        }

        /********************
         * Constructors
         * *****************/
        //Default
        public RestaurantClass()
        {
            idRestaurant = 0;
            nameRestaurant = "";
            addressRestaurant = "";
        }


        //With values
        public RestaurantClass(String nombre, String direccion)
        {
            nameRestaurant = nombre;
            addressRestaurant = direccion;
        }

        //copy
        public RestaurantClass(RestaurantClass restaurant)
        {
            nameRestaurant = restaurant.NameRestaurant;
            addressRestaurant = restaurant.AddressRestaurant;
        }

        public DataSet printRestaurants(String cityName)
        {
            DataSet bdvirtual = new DataSet();
            RestaurantCAD h = new RestaurantCAD();
            bdvirtual= h.printRestaurantsCAD(cityName);
            return bdvirtual;
        }
    }
}
