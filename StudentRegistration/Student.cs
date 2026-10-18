using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private int grade;
        private double averagescore;
        private decimal fee;
        private bool hasscholarship;
        private char classletter;
        private DateTime birthdate;

        public int Id
        {
            get {return id;} 
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public double AverageScore { get; set; }
        public decimal Fee { get; set; }
        public bool HasScholarship { get; set; }
        public char ClassLetter { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(int id, string name)
        {
            this.id = id;
            Name = name;
        }




    }
}
