using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum_Project_B.Models
{
    public class Customer : User
    {
        public Customer(string _firstname, string _lastname, string _email, string _organsisation, string _password) : base(_firstname, _lastname, _email, _organsisation, _password)
        {
        }
    }
}