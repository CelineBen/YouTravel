using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using YouTravelClassLibrary.Carpeta_EN;

//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Configuration;

namespace YouTravelClassLibrary.Carpeta_CAD
{
    class UserCAD
    {
       
        /*****************************
         * CONNEXION STRING 
         * ***************************/
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.Setting"].ToString());
   
        public UserCAD()
        { }


        /*USED IN THE LOGIN IN PROCESS (CONNEXION)
         * 
         * FUNCTION         : This method validate the login and the password.
         *                    By checking in the DB(Data Base) if the user exist there or not.
         * RETURN           : THE ID of the user if the user exist in the DB
         * TRICK            : If the value of the ID is 0, then the user don't exist.
         */
        public int ValidateAccessCAD(String login, String contrasena)
        {
            int identification = 0;
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select idUser from userTable where userName = \'" + login + "\'and password = \'" + contrasena + "\'", c);
                da.Fill(bdvirtual, "UserTable");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["UserTable"];
                if (t.Rows.Count == 1)
                    identification = (int)t.Rows[0]["idUser"];
            }
            catch (SqlException exp) { }
            finally { c.Close(); }
            return identification;
        }


        /*USED IN THE REGISTRATION PROCESS
         * 
         * FUNCTION     :This method check if the User name (Login) 
         *               is unique in the BD.
         * RETURN       :TRUE if it isn't exist yet and then can be create, FALSE orthewise
         */
        public bool ValidateLoginCAD(String log)
        {
            bool validate = false;
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from UserTable where userName =\'" + log + "\'", c);
                da.Fill(bdvirtual, "UserTable");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["UserTable"];
                if (t.Rows.Count == 0)
                    validate = true;
            }
            catch (SqlException exp){}
            finally{c.Close();}
            return validate;
        }


        /*USED IN THE USER CREATION PROCESS
          * FUNCTION         :This method create a new user in the DB
          * RETURN           :TRUE if the user is created, FALSE orthewise
          * MORE             :Before calling this method, the "login" of the new user
          *                  will be previously validate with the method "VALIDATELOGIN(string login) above
          **/
        public bool CreateNewUserCAD(UserClass user)
        {
            bool updated = false;
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select *from UserTable", c);
                da.Fill(bdvirtual, "UserTable");
                DataTable tabla = new DataTable();
                tabla = bdvirtual.Tables["UserTable"];
                DataRow nuevaFila = tabla.NewRow();
                nuevaFila[0] = 2;
                nuevaFila[1] = user.FirstName;
                nuevaFila[2] = user.LastName;
                nuevaFila[3] = user.DateOfBirth;
                nuevaFila[4] = user.UserName;
                nuevaFila[5] = user.Password; 
                nuevaFila[6] = user.Email;
                nuevaFila[7] = user.Country;
                tabla.Rows.Add(nuevaFila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "UserTable");
                updated = true;
            }
            catch (SqlException exp){updated = false;}
            finally{c.Close();}
            return updated;
        }


        /*USED IN THE MODIFICATION OF THE USER'S INFORMATIONS:
        * DETAILS      : This function modify the user information in the DB.
        *              The user already exist in the DB.
        * RETURN       :TRUE if the information are updated, FALSE otherwise.           
        * */
        public bool updateUserInfoCAD(UserClass usuario)
        {
            bool updated = false;
            //UserClass user = usuario;
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from UserTable where idUser =\'" + usuario.IdUser + "\'", c);
                da.Fill(bdvirtual, "UserTable");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["UserTable"];
                t.Rows[0]["userName"] = usuario.UserName;
                t.Rows[0]["firstName"] = usuario.FirstName;
                t.Rows[0]["lastName"] = usuario.LastName;
                t.Rows[0]["password"] = usuario.Password;
                t.Rows[0]["email"] = usuario.Email;
                t.Rows[0]["dateOfbirth"] = usuario.DateOfBirth;
                t.Rows[0]["country"] = usuario.Country;
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "UserTable");
                updated = true;
            }
            catch (Exception ex){updated = false;}
            finally{c.Close();}
            return updated;
        }

        /*USED WHEN A USER EDIT HIS INFORMATIONS
         * DETAILS      :This function retrieve the informations of the user from the DB
         *              and print them.
         * RETURN       :An object UserClass with all the user information.
         * */
        public UserClass getUserInformationCAD(int IDuser)
        {
            UserClass usuario = new UserClass();

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("Select * from userTable where idUser =\'" +IDuser+"\'", c);

                SqlDataReader dr = com.ExecuteReader();

                dr.Read();

                usuario.LastName = dr["lastName"].ToString();
                usuario.FirstName = dr["firstName"].ToString();
                usuario.DateOfBirth = (DateTime)dr["dateOfBirth"];
                usuario.UserName = dr["userName"].ToString();
                usuario.Email = dr["email"].ToString();
                usuario.Password = dr["password"].ToString();
                usuario.Country = dr["country"].ToString();
            }
            catch (SqlException exp)
            {
                throw new Exception(exp.Message, exp);
            }
            finally
            {
                c.Close();
            }

            return usuario;
        }


        /*USED IN FOR DELETE AN ACCOUNT (NOT IMPLEMENTED IN THE UI)
        * DETAILS      :This function delete a user account from the DB
        * 
        * RETURN       :TRUE if the user has been deleted, FALSE Otherwise
        * */
        public bool deleteUserCAD(int userID)
        {
            bool deleted = false;

            try
            {
                c.Open();

                String sql = "DELETE FROM UserTable WHERE idUser = userID";

                SqlCommand com = new SqlCommand(sql, c);

                com.ExecuteNonQuery();

                deleted = true;

            }
            catch (SqlException exp)
            {
                deleted = false;
                /**SAME QUESTION
                 * I don't want to throw any exception since the method return 
                 * a bool. W
                 * Waht do you think?
                 * */
                throw new Exception(exp.Message, exp);
            }
            finally
            {
                c.Close();
            }
            return deleted;
        }
    }
}
