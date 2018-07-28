using System;
using System.Collections.Generic;

namespace TaskList.Library
{
    public class ListTasks
    {

        public static List<Task> TaskList = new List<Task>();

        public ListTasks(List<Task> taskList)
        {
            TaskList = taskList;
        }

        public static void DisplayTasks(List<Task> taskList)
        {
            int taskNumber = 1;
            string categories = String.Format("{0, -4}{1,-10}{2,-14}{3,-21}{4,-22}", "#", "Complete", "Due Date",
                "Team Member", "Description");
            Console.WriteLine(categories);
            Console.WriteLine("  -------------------------------------------------------------");
            foreach (var task in taskList)
            {
                Console.WriteLine(FormatTask(task, taskNumber));
                taskNumber++;
            }
        }

        public static string FormatTask(Task task, int taskNumber)
        {
            string taskFormatting = String.Format("{0,-4} {1,-7} {2,-14} {3, -20} {4, -25}",
                    $"{taskNumber}.", "False", $"{task.DueDate}", task.TeamMember, task.Description);
            return taskFormatting;
        }
    }
}
