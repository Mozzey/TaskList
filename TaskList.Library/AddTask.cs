using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Library
{
    public class AddTask
    {
        public static string TeamMember;
        public static string DueDate;
        public static string Description;
        public static List<Task> TaskList;
        public static Task NewTask = new Task(TeamMember, Description, DueDate);

        public AddTask(List<Task> taskList)
        {
            TaskList = taskList;
        }
        public static void AddNewTask(List<Task> taskList)
        {
            Console.Write("Team member name: ");
            NewTask.TeamMember = Console.ReadLine();
            Console.Write("Task Description: ");
            NewTask.Description = Console.ReadLine();
            Console.Write("Due Date: ");
            NewTask.DueDate = Console.ReadLine();
            Console.WriteLine("Task Entered!");
            taskList.Add(NewTask);
        }


    }
}
