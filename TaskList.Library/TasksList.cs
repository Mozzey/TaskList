using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Library
{
    public class TasksList : List<Task>
    {
        public void AddTask()
        {
            Console.Write("Team member name: ");
            string teamMember = Console.ReadLine();
            Console.Write("Task Description: ");
            string description = Console.ReadLine();
            Console.Write("Due Date: ");
            string dueDate = Console.ReadLine();
            Console.WriteLine("Task Entered!");
            this.Add(new Task(teamMember, description, dueDate));
        }

        public void DisplayList()
        {
            string categories = String.Format("{0, -4}{1,-10}{2,-14}{3,-21}{4,-22}", "#", "Complete", "Due Date",
                "Team Member", "Description");
            Console.WriteLine(categories);
            Console.WriteLine("  -------------------------------------------------------------");
            for (int i = 0; i < this.Count; i++)
            {
                string formattedTask = String.Format("{0,-4} {1,-7} {2,-14} {3, -20} {4, -25}",
                   $"{i + 1}.", "False", this[i].DueDate, this[i].TeamMember, this[i].Description);
                Console.WriteLine(formattedTask);
            }
        }
    }
}
