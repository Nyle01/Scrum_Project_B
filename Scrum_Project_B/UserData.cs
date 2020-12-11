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
            string organsisation;
            string password;
            #endregion

            #region Konstruktor
            public UserData(string _authentificator, string _firstname, string _lastname, string _email, string _organsisation, string _password)
            {
                authentificator = _authentificator;
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
    }
}