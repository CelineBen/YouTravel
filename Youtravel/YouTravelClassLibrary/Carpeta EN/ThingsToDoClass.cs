using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YouTravelClassLibrary.Carpeta_CAD;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class ThingsToDoClass
    {
        int idThingsToDo;
        String nameThingsToDo;
        String addressThingsToDo;

        /*********
         * Properties
         * **********/

        public int IdThingsToDo
        {
            get { return idThingsToDo; }
        }

        public String NameThingsToDo
        {
            get { return nameThingsToDo; }
            set { nameThingsToDo = value; }
        }

        public String AddressThingsToDo
        {
            get { return addressThingsToDo; }
            set { addressThingsToDo = value; }
        }

        /********************
         * Constructors
         * *****************/
        //Default
        public ThingsToDoClass()
        {
            idThingsToDo = 0;
            nameThingsToDo = "";
            addressThingsToDo = "";
        }


        //With values
        public ThingsToDoClass(String nombre, String direccion)
        {
            nameThingsToDo = nombre;
            addressThingsToDo = direccion;
        }

        //copy
        public ThingsToDoClass(ThingsToDoClass ThingsToDo)
        {
            nameThingsToDo = ThingsToDo.NameThingsToDo;
            addressThingsToDo = ThingsToDo.AddressThingsToDo;
        }

        public DataSet printThingsToDo(String cityName)
        {
            DataSet bdvirtual = new DataSet();
            ThingsToDoCAD h = new ThingsToDoCAD();
            bdvirtual = h.printThingsToDoCAD(cityName);
            return bdvirtual;
        }
    }
}
