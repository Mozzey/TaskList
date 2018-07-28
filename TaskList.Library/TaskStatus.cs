using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Library
{
    public class TaskStatus
    {
        public List<Task> TaskList { get; set; }
        public Task task;


        public TaskStatus(Task task)
        {
            
        }

        public bool TaskComplete()
        {
            Console.WriteLine("Please select as task number to delete.");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int taskNumber) && (taskNumber > 0 && taskNumber < TaskList.Count))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{TaskList[taskNumber]}");
                return WarnUser();
            }
            else
            {
                Console.WriteLine("I'm sorry but you must choose a task number in the current list of tasks.");
                return TaskComplete();
            }
        }

        public bool WarnUser()
        {
            Console.WriteLine("Are you POSITIVE you would like to delete this task? (y/n)");
            string yesOrNo = Console.ReadLine().ToLower();
            if (yesOrNo.StartsWith("y"))
            {
                return true;
            }
            else // if (yesOrNo.StartsWith("n"))
            {
                // return MainMenu();
                return false;
            }
            /*else
            {
                // Console.WriteLine("Please enter y or n");
                return WarnUser();
            }*/
        }
    }
}
