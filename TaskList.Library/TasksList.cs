using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TaskList.Library
{
    public class TasksList : List<Task>
    {
        public void AddTask()
        {
            Console.Write("Team member name: ");
            string teamMember = IsValidName();
            Console.Write("Task Description: ");
            string description = Console.ReadLine();
            Console.Write("Due Date: ");
            string dueDate = IsValidDate();
            Console.WriteLine("Task Entered!");
            this.Add(new Task(teamMember, description, dueDate));
        }

        public void DisplayList()
        {
            string categories = String.Format("{0, -3}{1,-10}{2,-14}{3,-21}{4,-22}", "#", "Complete", "Due Date",
                "Team Member", "Description");
            Console.WriteLine(categories);
            Console.WriteLine("  -------------------------------------------------------------");
            for (int i = 0; i < this.Count; i++)
            {
                this.DisplayTask(i);
            }
        }
        public void DisplayTask(int i)
        {
            string formattedTask = String.Format("{0,-4} {1,-7} {2,-14} {3, -20} {4, -25}",
                $"{i + 1}.", this[i].Completed, this[i].DueDate, this[i].TeamMember, this[i].Description);
            Console.WriteLine(formattedTask);
        }
        public string MainMenu()
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
        public void DeleteTask()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please enter a task number to be deleted: ");
            var taskNumber = Console.ReadLine();
            
            if (int.TryParse(taskNumber, out int validTask) && (validTask > 0 && validTask <= this.Count))
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (validTask == (i + 1))
                    {
                        Console.WriteLine("Are you sure you wont to delete this task? (Y/N)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.DisplayTask(i);
                        var confirmation = Console.ReadLine().ToUpper();
                        if (confirmation.StartsWith("Y"))
                        {
                            this.Remove(this[i]);
                        }
                        else if(confirmation.StartsWith("N"))
                        {
                            MainMenu();
                        }
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry but you must enter a valid integer that matches a task.");
                Console.ForegroundColor = ConsoleColor.White;
                DeleteTask();
            }
        }

        public void MarkTaskComplete()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please enter a task number to be marked complete: ");
            var taskNumber = IsValidInt();
            for (int i = 0; i < this.Count; i++)
            {
                if (taskNumber == (i + 1))
                {
                    Console.WriteLine("Are you sure you want to mark this task Complete? (Y/N)");
                    Console.ForegroundColor = ConsoleColor.Green;
                    this.DisplayTask(i);
                    var confirmation = Console.ReadLine().ToUpper();
                    if (confirmation.StartsWith("Y"))
                    {
                        this[i].Completed = true;
                    }
                    else if (confirmation.StartsWith("N"))
                    {
                        MainMenu();
                    }
                }
            }
        }

        public int IsValidInt()
        {
            var taskNumber = Console.ReadLine();
            if (int.TryParse(taskNumber, out int validTask) && validTask > 0 && validTask <= this.Count)
            {
                return validTask;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry but you must enter a valid integer that matches a task number.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter a task number to be marked complete: ");
                return IsValidInt();
            }
        }

        public string IsValidDate()
        {
            var dueDate = Console.ReadLine();
            if (DateTime.TryParse(dueDate, out DateTime validDate) && validDate > DateTime.Now)
            {
                return validDate.ToString("MM/dd/yyyy");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry but yur due date can't be before the current day and must in the form of mm/dd/yyyy");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter a due date: ");
                return IsValidDate();
            }
        }

        public string IsValidName()
        {
            var validName = @"[A-Za-z]+\s?[A-Za-z]+";
            var teamMember = Console.ReadLine();
            if (Regex.IsMatch(teamMember, validName))
            {
                return teamMember;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry but name must consist of all only letters either lower or upper case");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Team Member Name:");
                return IsValidName();
            }
        }
    }
}
