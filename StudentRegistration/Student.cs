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
            get
            { 
            return id;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Числото трябва да бъде положително");
                }
              id=value;
            }
        
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Името не може да бъде празно");
                }
                name = value;
            }
        }
        public int Age 
        {
            get
            {
                return age;
            }
            set 
            { 
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Възрастта трябва да бъде между 6 и 20 години");
                }
                age = value;
            }
        }
        public int Grade 
        { 
            get 
            {
                return grade;
            }
            set
            { 
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Класът трябва да бъде между 1 и 12");
                }
                grade = value;
            }
        }
        public double AverageScore
        {
            get
            { return averagescore; }
            set
            {
                if (value < 2.0 || value > 6.0)
                {
                    throw new ArgumentOutOfRangeException("Средният успех трябва да бъде между 2.00 и 6.00");
                }
                averagescore = value;
            }
        }
        public decimal Fee
        {
            get { return fee; }
            set
            { 
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Таксата трябва да бъде положителна");
                }
                fee = value;
            }
        }
        public bool HasScholarship
        {
            get 
            { 
                return hasscholarship;
            }
            set 
            { 
                hasscholarship = value;
            }
        }
        public char ClassLetter 
        {
            get
            { 
            return classletter;
            }
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("Трябва да бъде буква");
                }
                classletter = value;
            }
        }
        public DateTime BirthDate
        { 
            get
            {  
              return birthdate;
            }
            set
            {
                 if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Не може да бъде бъдеща дата");
                }
                birthdate = value;
            }
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }




    }
}
