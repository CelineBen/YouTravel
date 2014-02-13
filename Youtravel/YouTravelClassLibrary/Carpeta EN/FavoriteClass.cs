using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YouTravelClassLibrary.Carpeta_CAD;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class FavoriteClass
    {
        private int idFavorite;
        private String favorites;

        public int IdFavorite
        {
            get { return idFavorite; }
        }

        public String Favorites
        {
            get { return favorites; }
            set { favorites = value; }
        }

        /*
         * Constructors of Favorites
         * */
        //Default constructor
        public FavoriteClass()
        {
            favorites = "";
            idFavorite = 0;
        }

        //Constructor with value
        public FavoriteClass(String fav, int id)
        {
            favorites = fav;
            idFavorite = id;
        }

        //Constructor of copy
        public FavoriteClass(FavoriteClass fav)
        {
            favorites = fav.favorites;
            idFavorite = fav.idFavorite;
        }


        /**********************************
         * Publics methods of the class
         * ***************************************/

        /**DETAILS      :Print all the favorites of a given user
         * PARAMETERS   :The ID of the user
         * RETURN       :A collection (DATASET) of favorites
         * */
        public DataSet printMyFavorites(int userID)
        {
            DataSet lista = new DataSet();

            FavoriteCAD fav = new FavoriteCAD();

            lista = fav.printMyFavoritesCAD(userID);

            return lista;
        }

        /*USED IN ADDING FAVORITE PROCESS
         * 
         * DETAILS      :Add a favorite in the DB
         * PARAMETERS   :The name of favorite, the city, the country and the ID of the user
         * RETURN       :TRUE is the favorite is added, FALSE orthewise
         * */
        public bool addFavorite(int idUser, String city, String country)
        {
            bool added = false;
            FavoriteCAD fav = new FavoriteCAD();
            added = fav.addFavoriteCAD(idUser, city, country);
            return added;
        }

        /*DELETE A FAVORITE
         * 
         * DETAILS      :Delete a favorite
         * PARAMETERS   :Id of the favorite
         * RETURN       :TRUE is the favorite is delete, FALSE orthewise
         * */
        public bool deleteFavorite(int favID)
        {
            bool added = false;
            FavoriteCAD fav = new FavoriteCAD();

            added = fav.deleteFavoriteCAD(favID);

            return added;
        }
    }
}
