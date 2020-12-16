using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scrum_Project_B.models;

public namespace Scrum_Project_B.models
{
    public class Story
    {
        string title;
        string description;
        string doneBy;
        string details;
        int priority;
        int point;
        int time_Should;
        int time_Is;
    }
    public class Taskboard
    {
        bool inProgress;
        bool toBeVerified;
        bool done;
        List<Story> stories = new List<Story>();
        List<Story> toDo = new List<Story>();
    }
}