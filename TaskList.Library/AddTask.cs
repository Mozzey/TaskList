using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Library
{
    public class AddTask
    {
        public static Task NewTask = new Task(TeamMember, Description, DueDate);
        public static string TeamMember { get; set; }
        public static string DueDate { get; set; }
        public static string Description { get; set; }

        public static Task AddNewTask()
        {
            Console.Write("Enter team member name: ");
            NewTask.TeamMember = Console.ReadLine();
            Console.Write("Enter a due date for this task: ");
            NewTask.DueDate = Console.ReadLine();
            Console.Write("Enter a brief description about the task: ");
            NewTask.Description = Console.ReadLine();
            Console.WriteLine("Task Entered!");
            return NewTask;
        }


    }
}
