using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum_Project_B.Models
{
    public class Productbacklog
    {
        List<Story> stories = new List<Story>();

        public List<Story> Stories { get => stories; set => stories = value; }
    }
}