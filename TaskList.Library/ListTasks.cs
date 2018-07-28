using System;
using System.Collections.Generic;

namespace TaskList.Library
{
    public class ListTasks
    {
        public static List<Task> TaskList;
        public ListTasks(List<Task> taskList)
        {
            TaskList = taskList;
        }
        public void AddToList(Task task)
        {
            TaskList.Add(task);
        }
        
        public void DisplayTaskList(List<Task> taskList)
        {
            
            for (int i = 0; i < taskList.Count; i++)
            {
                string formattedTask = String.Format("{0,-4} {1,-7} {2,-14} {3, -20} {4, -25}",
                    $"{i+1}.", "False", taskList[i].DueDate, taskList[i].TeamMember, taskList[i].Description);
                Console.WriteLine(formattedTask);
            }
            Console.WriteLine();
        }
    }
}
