namespace Scrum_Project_B
{
    public partial class _default
    {
        class UserData
        {
            #region Merkmale
            string authentificator;
            string firstname;
            string lastname;
            string email;
            string classOrCompany;
            string password;
            #endregion

            #region Konstruktor
            public UserData(string _authentificator, string _firstname, string _lastname, string _email, string _classOrCompany, string _password)
            {
                authentificator = _authentificator;
                firstname = _firstname;
                lastname = _lastname;
                email = _email;
                classOrCompany = _classOrCompany;
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
            public string ClassOrCompany
            {
                get { return classOrCompany; }
            }
            public string Password
            {
                get { return password; }
            }
            #endregion
        }
    }
}