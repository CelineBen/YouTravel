using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YouTravelClassLibrary.Carpeta_CAD;

namespace YouTravelClassLibrary.Carpeta_EN
{
    public class UserClass
    {
        private int idUser;
        private String userName; //login
        private String firstName;
        private String lastName;
        private DateTime dateOfBirth;
        private String email;
        private String password;
        private String country;

        /********************
         * Properties
         * *****************/
        public int IdUser
        {
            set { IdUser = idUser; }
            get { return idUser; }
        }

        public String UserName //login
        {
            set { userName = value; }
            get { return userName; }
        }

        public String FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }

        public String LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }

        public DateTime DateOfBirth
        {
            set { dateOfBirth = value; }
            get { return dateOfBirth; }
        }

        public String Email
        {
            set { email = value; }
            get { return email; }
        }

        public String Password
        {
            set { password = value; }
            get { return password; }
        }

        public String Country
        {
            set { country = value; }
            get { return country; }
        }

        /**********************************************
         * Constructors
         * ********************************************/
        public UserClass()
        {
            userName = "";

            firstName = "";

            lastName = "";

            password = "";

            email = "";

            dateOfBirth = DateTime.MinValue;

            country = "";
        }

        public UserClass(int newIdUser)
        {
            idUser = newIdUser;
            UserClass user = new UserClass();
            user=getUserInformation();
            UserName = user.UserName;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Password = user.Password;
            Email = user.Email;
            DateOfBirth = user.DateOfBirth;
            Country = user.Country;
        }

        //Constructor with the values of registration form.
        public UserClass(String login, String appelido, String nombre, String correo, String contrasena, DateTime fechaNacimiento, String pais)
        {
            userName = login;

            lastName = appelido;

            firstName = nombre;

            email = correo;

            password = contrasena;

            dateOfBirth = fechaNacimiento;

            country = pais;
        }

        //Constructor of copy
        public UserClass(UserClass user)
        {
            userName = user.UserName;

            firstName = user.FirstName;

            lastName = user.LastName;

            password = user.Password;

            email = user.Email;

            dateOfBirth = user.DateOfBirth;

            country = user.Country;
        }
        /***********************************
        * Methods of the class
        * **********************************/

        /*USED IN THE LOGIN IN PROCESS (CONNEXION)
         * 
         * FUNCTION         : This method validate the login and the password.
         *                    By checking in the DB(Data Base) if the user exist there or not.
         * RETURN           : THE ID of the user if the user exist in the DB
         * TRICK            : If the value of the ID is 0, then the user don't exist.
         * */
        public int ValidateAccess(String login, String password)
        {
            int identification = 0;

            UserCAD userBD = new UserCAD();

            identification = userBD.ValidateAccessCAD(login, password);

            return identification;
        }


        /*USED IN THE REGISTRATION PROCESS
         * 
         * FUNCTION     :This method check if the User name (Login) 
         *               is unique in the BD.
         * RETURN       :TRUE if it isn't exist yet and then can be create, FALSE orthewise
         */
        public bool ValidateLogin(String log)
        {
            bool valid = false;

            UserCAD userBD = new UserCAD();

            valid = userBD.ValidateLoginCAD(log);

            return valid;
        }


        /*USED IN THE USER CREATION PROCESS
         * FUNCTION         :This method create a new user in the DB
         * RETURN           :TRUE if the user is created, FALSE orthewise
         * MORE             :Before calling this method, the "login" of the new user
         *                  will be previously validate with the method "VALIDATELOGIN(string login) above
         **/
        public bool CreateNewUser()
        {
            bool added = false;

            UserCAD userBD = new UserCAD();

            added = userBD.CreateNewUserCAD(this);

            return added;
        }


        /*USED IN THE MODIFICATION OF THE USER'S INFORMATIONS:
         * DETAILS      : This function modify the user information in the DB.
         *              The user already exist in the DB.
         * RETURN       :TRUE if the information are updated, FALSE otherwise.           
         * */
        public bool updateUserInfo()
        {
            bool updated = false;
            UserCAD userBD = new UserCAD();
            updated = userBD.updateUserInfoCAD(this);
            return updated;
        }


        /*USED WHEN A USER EDIT HIS INFORMATIONS
         * DETAILS      :This function retrieve the informations of the user from the DB
         *              and print them.
         * RETURN       :An object UserClass with all the user information.
         * */
        public UserClass getUserInformation()
        {
            UserCAD userBD = new UserCAD();
            UserClass user = new UserClass();
            user = userBD.getUserInformationCAD(IdUser);
            return user;
        }


        /*USED IN FOR DELETE AN ACCOUNT (NOT IMPLEMENTED IN THE UI)
         * DETAILS      :This function delete a user account from the DB
         * 
         * RETURN       :TRUE if the user has been deleted, FALSE Otherwise
         * */
        public bool deleteUser()
        {
            bool deleted = false;

            UserCAD user = new UserCAD();

            deleted = user.deleteUserCAD(this.IdUser);

            return deleted;
        }
    }
}
