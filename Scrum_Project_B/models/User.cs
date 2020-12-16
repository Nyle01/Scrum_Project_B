using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum_Project_B
{
    public class User
    {
        #region Merkmale
        string authentificator;
        string firstname;
        string lastname;
        string email;
        string organsisation;
        string password;
        #endregion

        #region Konstruktor
        public UserData(string _firstname, string _lastname, string _email, string _organsisation, string _password)
        {
        
            firstname = _firstname;
            lastname = _lastname;
            email = _email;
            organsisation = _organsisation;
            password = _password;
        }
        #endregion

        #region Properties
        public string Authentificator
        {
            get { return authentificator; }
        }
        public string Firstname
        {
            get { return firstname; }
        }
        public string Lastname
        {
            get { return lastname; }
        }
        public string Email
        {
            get { return email; }
        }
        public string Organsisation
        {
            get { return organsisation; }
        }
        public string Password
        {
            get { return password; }
        }
        #endregion
    }
    public class Customer : User
    {

    }
    public class ProductMember : User
    {

    }
    public class ProductOwner : User
    {

    }
    public class ScrumMaster : User
    {

    }
}