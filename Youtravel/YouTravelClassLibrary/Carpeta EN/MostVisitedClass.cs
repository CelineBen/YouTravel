using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using YouTravelClassLibrary.Carpeta_CAD;
using System.Data;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class MostVisitedClass
    {
        int idMostVisited;
        String nameMostVisited;
        String addressMostVisited;

        public MostVisitedClass()
        {
            idMostVisited = 0;
            nameMostVisited = "";
            addressMostVisited = "";
        }


        //With values
        public MostVisitedClass(String nombre, String direccion)
        {
            nameMostVisited = nombre;
            addressMostVisited = direccion;
        }

        public DataSet getMostVisited(String countryName){
            DataSet bdvirtual = new DataSet();
            MostVisitedCAD mv = new MostVisitedCAD();
            bdvirtual = mv.getMostVisitedCAD(countryName);
            return bdvirtual;
        }
    }
}
