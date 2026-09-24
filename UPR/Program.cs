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
        static string filePath = "tasks.txt";
        static List<Tasks> tasks = new List<Tasks>();
      

        static void Main(string[] args)
        {
            LoadDataFromFile();

            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1.Add new task");
                Console.WriteLine("2.Show tasks");
                Console.WriteLine("3.Check task");
                Console.WriteLine("4.Delete task");
                Console.WriteLine("5.End program");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter discription: ");
                    string description = Console.ReadLine();

                    Console.Write("Enter deadline: ");
                    string deadline = Console.ReadLine();

                    Tasks newTask = new Tasks(title, description, deadline);
                    tasks.Add(newTask);
                }
                Console.WriteLine("Added successfully");

                else if (choice == "2")
                {
                  if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks found...");
                    }
                    else
                }



            }
        }
    }
}
