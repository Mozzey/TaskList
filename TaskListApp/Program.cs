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
            var taskList = new TasksList(); 
            bool isRunning = true;
            while (isRunning)
            {
                
                string mainMenu = MainMenu();
                Console.WriteLine(mainMenu);
                Console.Write("What would you like to do? ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        taskList.DisplayList();
                        break;
                    case 2:
                        taskList.AddTask();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Have a Great Day!!");
                        Console.ReadKey();
                        isRunning = false;
                        break;
                    default:
                        break;
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
