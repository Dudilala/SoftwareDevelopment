using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPR
{
    internal class Tasks
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string DeadLine { get; set; }
        public bool IsCompleted { get; set; }

        public Tasks(string title, string description, string deadLine) 
        {
          this.Title = title;
            this.Description = description;
            this.DeadLine = deadLine;
            this.IsCompleted = false;
        }








    }
}
