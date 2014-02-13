using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YouTravelClassLibrary.Carpeta_CAD;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class ContinentClass
    {

        int idContinent;// – PK, auto-increment
        string nameContinent;

        public int IdContinent
        {
            get { return idContinent; }
        }

        public String NameContinent
        {
            set { nameContinent = value; }
            get { return nameContinent; }
        }

        /*
         * Constructors
         * */

        //By default
        public ContinentClass()
        {
            nameContinent = "";
            idContinent = 0;
        }

        //Initialized
        public ContinentClass(String continent)
        {
            nameContinent = continent;
        }

        //Of copy
        public ContinentClass(ContinentClass conti)
        {
            nameContinent = conti.NameContinent;
        }

        /*******************************
         * Publics Methods of class
         * ****************************/


        /*DETAILS       :Print all the continents
         * RETURN       :A list of continents
         * */
        public ArrayList printAllContinent()
        {
            ArrayList lista = new ArrayList();

            ContinentCAD conti = new ContinentCAD();

            lista = conti.printAllContinentCAD();

            return lista;
        }

        /*DETAILs       :Add a new continent in the table
           * PARAMETERS   :Name of the continent.
           * RETURN       :TRUE if the continent has been added, FALSE orthewise
           * */
        public bool addContinent(String name)
        {
            bool added = false;

            ContinentCAD conti = new ContinentCAD();

            added = conti.addContinentCAD(name);

            return added;
        }

        /*
         * DETAILS      :Delete a continent.
         * PARAMETERS   :The id of the continent
         * RETURN       :TRUE if the continent is deleted, FALSE orthewise
         * */
        public bool deleteContinent(int contID)
        {
            bool added = false;

            ContinentCAD conti = new ContinentCAD();

            added = conti.deleteContinentCAD(contID);

            return added;
        }
    }
}
