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
                Console.ForegroundColor = ConsoleColor.White;
                string mainMenu = taskList.MainMenu();
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
                        taskList.DeleteTask();
                        break;
                    case 4:
                        taskList.MarkTaskComplete();
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

        
    }
}
