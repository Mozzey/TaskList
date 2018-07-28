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

            /*
            var task1 = new Task("firstName lastName", "simple task", DateTime.Now.ToString("MM/dd/yyyy"));
            var task2 = new Task("mozzey magick", "test two and random text to take up space", DateTime.Now.ToString("MM/dd/yyyy"));
            var task3 = new Task("magick", "test thre but with more words", DateTime.Now.ToString("MM/dd/yyyy"));
            */
            while (isRunning)
            {


                List<Task> taskList = new List<Task>();
                string mainMenu = MainMenu();
                Console.WriteLine(mainMenu);
                Console.Write("What would you like to do? ");
                string option = Console.ReadLine();
                if (int.TryParse(option, out int validOption))
                {
                    switch (validOption)
                    {
                        case 1:
                            ListTasks.DisplayTasks(taskList);
                            break;
                        case 2:
                            var task = AddTask.AddNewTask();
                            taskList.Add(task);
                            break;
                        case 3:
                            Console.WriteLine("WIP");
                            break;
                        case 4:
                            Console.WriteLine("WIP");
                            break;
                        case 5:
                            Console.WriteLine("Goodbye!");
                            isRunning = false;
                            break;
                        default:
                            break;
                    }
                }



                Console.ReadLine();
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
