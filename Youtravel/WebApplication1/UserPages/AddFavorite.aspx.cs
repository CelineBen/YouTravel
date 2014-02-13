using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using YouTravelClassLibrary.Carpeta_EN;
using System.Collections;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        public string countryActive = "";
        public string cityActive = "";
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] != null)
            {
                if (!IsPostBack)
                {
                    Load_DropDownList_Country();
                }
                else
                {
                    countryActive = (string)ViewState["countryActive"];
                    cityActive = (string)ViewState["cityActive"];
                }
                Load_Favorite();
            }else
                Response.Redirect("../Restricted.aspx");
        }

        private void Load_Favorite()
        {
                FavoriteClass f=new FavoriteClass();
                ListView1.DataSource = f.printMyFavorites((int)Session["idUser"]);
                ListView1.DataBind();
        }

        public void Load_DropDownList_Country()
        {
            if (!IsPostBack)
            {
                CountryClass co = new CountryClass();
                ArrayList list=co.printCountries(1);
                    string item;
                    FavoriteCountryList.Items.Clear();
                    FavoriteCountryList.Items.Add(new ListItem("", ""));
                    for (int i = 0; i < list.Count;i++)
                    {
                        item = list[i].ToString();
                        FavoriteCountryList.Items.Add(new ListItem(item, item));
                    }
                    FavoriteCountryList.DataBind();
            }
        }

        public void Load_DropDownList_City()
        {
            CityClass ci = new CityClass();
            ArrayList list = ci.ArrayCities(countryActive);
            string item;
            FavoriteCityList.Items.Clear();
            FavoriteCityList.Items.Add(new ListItem("", ""));
            for (int i = 0; i < list.Count; i++)
            {
                item = list[i].ToString();
                FavoriteCityList.Items.Add(new ListItem(item, item));
            }
            FavoriteCityList.DataBind();
        }

        public bool InsertCity()
        {
            bool cambiado = false;
            FavoriteClass f = new FavoriteClass();
            cambiado = f.addFavorite((int)Session["idUser"], cityActive, countryActive);
            return cambiado;
        }

        protected void FavoriteCountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryActive = FavoriteCountryList.SelectedItem.Text.ToString();
            ViewState["countryActive"] = countryActive;
            ViewState["cityActive"] = "";
            Load_DropDownList_City();
        }

        protected void SaveFavorite_Click(object sender, EventArgs e)
        {
            if (cityActive != "" && countryActive != "")
            {
                InsertCity();
                Load_Favorite();
            }
        }

        protected void FavoriteCityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityActive = FavoriteCityList.SelectedItem.Text.ToString();
            ViewState["cityActive"] = cityActive;
        }
    }
}
