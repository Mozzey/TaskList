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
            // Instantiate a new task list
            var taskList = new TasksList();
            ////////////////////////////////////////////////////////
            ///////////////////// TEST TASKS ///////////////////////
            Task task1 = new Task("mike", "mike's task", "01/01/19");
            Task task2 = new Task("erik", "erik's task", "02/02/19");
            Task task3 = new Task("mike", "mike's task 2", "01/20/20");
            Task task4 = new Task("mike", "mike's task 3", "01/03/19");
            taskList.Add(task1);
            taskList.Add(task2);
            taskList.Add(task3);
            taskList.Add(task4);
            ///////////////////////////////////////////////////////
            // flag for main loop
            bool isRunning = true;
            // Main program loop
            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.White;
                // Display main menu
                string mainMenu = taskList.MainMenu();
                Console.WriteLine(mainMenu);
                // Ask user to choose an option
                Console.Write("What would you like to do? ");
                string option = Console.ReadLine();
                // validate that input is an intgeter
                if (int.TryParse(option, out int validOption))
                {
                    // Options from the main menu
                    switch (validOption)
                    {
                        // If option 1 display sub menu with listing options
                        case 1:
                            // sub menu with listing options(see TaskList.cs -> ListDisplayMenu())
                            taskList.ListDisplayMenu();
                            break;
                        // If option 2 ask user to input task members and add a new task to the list
                        case 2:
                            taskList.AddTask();
                            break;
                        // If option 3 ask user to choose a task to delete, ask user to confirm, delete task
                        case 3:
                            taskList.DeleteTask();
                            break;
                        // If option 4 ask which task user would like to mark complete, ask user to confirm, mark task complete
                        case 4:
                            taskList.MarkTaskComplete();
                            break;
                        // If option 5 ask which task user would like to edit, ask user to confirm, input new task members, edit task
                        case 5:
                            taskList.EditTask();
                            break;
                        // If option 6 say goodbye and end program
                        case 6:
                            Console.WriteLine("Have a Great Day!!");
                            Console.ReadKey();
                            isRunning = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please choose and option from the list");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please choose and option from the list");
                }
            }
        }

        
    }
}
