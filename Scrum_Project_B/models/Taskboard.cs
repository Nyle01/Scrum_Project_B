using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scrum_Project_B.models;



public namespace Scrum_Project_B
{
    public class Taskboard
    {
        bool inProgress;
        bool toBeVerified;
        bool done;
        List<Story> stories = new List<Story>();
        List<Story> toDo = new List<Story>();
        
    }
}