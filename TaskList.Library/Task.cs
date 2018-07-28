using System;
using System.Collections.Generic;

namespace TaskList.Library
{
    public class Task
    {
        public static bool Completed = false;
        public string TeamMember { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public static int TaskIndex { get; set; }

        public Task(string teamMember, string description, string dueDate)
        {
            TeamMember = teamMember;
            Description = description;
            DueDate = dueDate;
        }

        
    }
}
