using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPR
{
    internal class Program
    {
        static List<Tasks> tasks = new List<Tasks>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1.Add new task:");
                Console.WriteLine("2.Show tasks:");
                Console.WriteLine("3.Check task:");
                Console.WriteLine("4.Delete task:");
                Console.WriteLine("5.End program:");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();


                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;

                    case "2":
                        ShowTasks();
                        break;

                    case "3":
                        CheckTasks();
                        break;

                    case "4":
                        DeleteTasks();
                        break;

                    case "5":
                        Console.WriteLine("bye!");
                        return;

                    default:
                        Console.WriteLine("invalid choice. press a button...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.WriteLine("---Add new task---");
            Console.Write("Enter task: ");
            string title = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            Console.Write("Enter deadline: ");
            string deadLine = Console.ReadLine();

            Tasks newTask = new Tasks(title, description, deadLine);
            tasks.Add(newTask);

            Console.WriteLine("Task added successfully!");
            Console.ReadKey();
        }
        static void ShowTasks()
        {
            Console.WriteLine("--- Tasks ---");

            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Task number: " + (i + 1));
                    Console.WriteLine("Title: " + tasks[i].Title);
                    Console.WriteLine("Description: " + tasks[i].Description);
                    Console.WriteLine("Deadline: " + tasks[i].DeadLine);
                    Console.WriteLine("Completed: " + tasks[i].IsCompleted);
                }
            }

            Console.ReadKey();
        }


        static void CheckTasks()
        {
            Console.WriteLine("--- Check task ---");

            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks.");
                Console.ReadKey();
                return;
            }

            ShowTaskTitles();

            Console.Write("Enter task number: ");
            int number = int.Parse(Console.ReadLine());

            tasks[number - 1].IsCompleted = true;

            Console.WriteLine("Task completed!");
            Console.ReadKey();
        }


        static void DeleteTasks()
        {
            Console.WriteLine("--- Delete task ---");

            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks.");
                Console.ReadKey();
                return;
            }

            ShowTaskTitles();

            Console.Write("Enter task number: ");
            int number = int.Parse(Console.ReadLine());

            tasks.RemoveAt(number - 1);

            Console.WriteLine("Task deleted!");
            Console.ReadKey();
        }


        static void ShowTaskTitles()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + tasks[i].Title);
            }
        }
    }
}



