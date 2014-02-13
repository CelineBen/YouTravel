using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using YouTravelClassLibrary.Carpeta_CAD;
using System.Data;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class HotelClass
    {
        int idHotel;
        String nameHotel;
        String addressHotel;

        /*********
         * Properties
         * **********/

        public int IdHotel 
        {
            get { return idHotel; }
        }

        public String NameHotel
        {
            get { return nameHotel; }
            set { nameHotel = value; }
        }

        public String AddressHotel
        {
            get { return addressHotel; }
            set { addressHotel = value; }
        }

        /********************
         * Constructors
         * *****************/
        //Default
        public HotelClass()
        {
            idHotel = 0;
            nameHotel = "";
            addressHotel = "";
        }


        //With values
        public HotelClass(String nombre, String direccion)
        {
            nameHotel = nombre;
            addressHotel = direccion;
        }

        //copy
        public HotelClass(HotelClass hotel)
        {
            nameHotel = hotel.NameHotel;
            addressHotel = hotel.AddressHotel;
        }

        public DataSet printHotels(String cityName){
            DataSet bdvirtual = new DataSet();
            HotelCAD h = new HotelCAD();
            bdvirtual = h.printHotelsCAD(cityName);
            return bdvirtual;
        }
    }
}
