using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum_Project_B.Models
{
    public class Project
    {
        string title;
        int id;
        string description;
        List<Productbacklog> productbacklogs = new List<Productbacklog>();

        public Project(string Title)
        {
            title = Title;
        }

        public string Title { get => title; set => title = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
    }
}