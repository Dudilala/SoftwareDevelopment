using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UPR
{
    internal class Tasks
    {
        private int id;
        private string title;
        private string description;
        private DateTime deadline;
        private bool isCompleted;

        public int Id { get; set; }
        public string Title
        {
            get 
            { 
             return title; 
            }
            set
            { if (string.IsNullOrEmpty(title))
                    throw new ArgumentNullException("the title is a must"); 
            }
            
        }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }

        public Tasks(int id, string title, string description, DateTime deadLine) 
        {
            if (id <= 0) 
                throw new ArgumentOutOfRangeException("id has to be a positive number");
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("the title is a must");

            Id = id;
            Title = title;
            Description = description;
            DeadLine = deadLine;
            IsCompleted = false;
        }

        






    }
}
