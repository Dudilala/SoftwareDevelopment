using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPR
{
    internal class TodoService
    {

        private readonly List<Tasks> tasks = new List<Tasks>();
        private static int nextId = 1;

        public List<Tasks> GetAll()
        {
            return tasks;
        }

        public void Add(string title, string description, DateTime dueDate)
        {
            Tasks todoItem = new Tasks(nextId, title, description, dueDate);
            tasks.Add(todoItem);
            nextId++;
        }

        public Tasks FindById(int id)
        {
            foreach (Tasks todoItem in tasks)
            {
                if (todoItem.Id == id)
                {
                    return todoItem;
                }

            }
           
            return null;
        }

        public void Complete(int id)
        {

            Tasks completedTask = FindById(id);
            if (completedTask == null)
            {
                throw new ArgumentException("Задачата не съществува");
            }
            completedTask.Completed();
        }
        public void Delete(int id)
        {
            Tasks deleteTask = FindById(id);
            if (deleteTask == null)
            {
                throw new ArgumentException("Задачата не съществува");
            }
            tasks.Remove(deleteTask);
        }

    }
}
