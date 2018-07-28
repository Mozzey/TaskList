using System;
using System.Text;
using System.Collections.Generic;
using TaskList.Library;

namespace TaskListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            List<Task> listOfTasks = new List<Task>();
            var taskLists = new ListTasks(listOfTasks);

            while (isRunning)
            {
                string mainMenu = MainMenu();
                Console.WriteLine(mainMenu);
                Console.Write("What would you like to do? ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    taskLists.DisplayTaskList();
                }
                else if (option == 2)
                {
                    var task = AddTask.AddNewTask();
                    taskLists.AddToList(task);
                }
                else if (option == 3)
                {
                    Console.WriteLine("wip");
                }
                else if (option == 4)
                {
                    Console.WriteLine("wip");
                }
                else if (option == 5)
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadKey();
                    isRunning = false;
                }
            }
        }

        private static string MainMenu()
        {
            Console.WriteLine("Welcome to the Task Manager!");
            String mainMenu = String.Format("{0,17}\n{1,15}\n{2,19}\n{3,25}\n{4,11}", 
                "1. List tasks",
                "2. Add task",
                "3. Delete tasks",
                "4. Mark task complete",
                "5. Quit");
            return mainMenu;
        }
    }
}
