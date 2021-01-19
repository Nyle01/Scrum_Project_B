using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum_Project_B
{
    public class Taskboard
    {
        List<Story> stories = new List<Story>();
        bool toBeVerified;
        bool done;
        bool inProgress;
        bool toDo;

        public List<Story> Stories { get => stories; set => stories = value; }
        public bool ToBeVerified { get => toBeVerified; set => toBeVerified = value; }
        public bool Done { get => done; set => done = value; }
        public bool InProgress { get => inProgress; set => inProgress = value; }
        public bool ToDo { get => toDo; set => toDo = value; }
    }
}