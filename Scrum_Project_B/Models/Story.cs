using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum_Project_B
{
    public class Story
    {
        string title;
        string description;
        string doneBy;
        string details;
        public enum Priority : int
        {
            p_1 = 1,
            p_2 = 2,
            p_3 = 3,
            p_5 = 5,
            p_8 = 8,
            p_13 = 13,
            p_21 = 21
        };
        int points;
        TimeSpan time_Is;
        TimeSpan time_Should;

        public Story(string Title)
        {
            title = Title;
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string DoneBy { get => doneBy; set => doneBy = value; }
        public string Details { get => details; set => details = value; }
        public int Points { get => points; set => points = value; }
        public TimeSpan Time_Is { get => time_Is; set => time_Is = value; }
        public TimeSpan Time_Should { get => time_Should; set => time_Should = value; }
    }
}