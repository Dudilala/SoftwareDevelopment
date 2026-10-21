namespace StudentRegistration
{
    internal class Program
    {
        private static int nextId = 1;
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("-Въведете данните на ученика-");
            int id = nextId++;

            Student student = null;
            while (true)
            {
                try
                {
                    Console.Write("Име: ");
                    string nameInput = Console.ReadLine();

                    student = new Student(id, nameInput);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}: Въведете отново.");
                }
            }

          
            while (true)
            {
                try
                {
                    Console.Write("Възраст: ");
                    student.Age = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Въведете цяло число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}: Въведете отново.");
                }
            }

         
            while (true)
            {
                try
                {
                    Console.Write("Клас: ");
                    student.Grade = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Въведете цяло число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}: Въведете отново.");
                }
            }

  
            while (true)
            {
                try
                {
                    Console.Write("Среден успех: ");
                    student.AverageScore = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Въведете число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}: Въведете отново.");
                }
            }

        
            while (true)
            {
                try
                {
                    Console.Write("Такса: ");
                    student.Fee = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Въведете валидно число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}: Въведете отново.");
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("Получава ли стипендия: ");
                    string input = Console.ReadLine().ToLower().Trim();

                    if (input == "true" || input == "da" || input == "да")
                    {
                        student.HasScholarship = true;
                        break;
                    }
                    else if (input == "false" || input == "ne" || input == "не")
                    {
                        student.HasScholarship = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Грешка: Въведете да или не.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Грешка: Въведете валидна стойност.");
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("Паралелка: ");
                    student.ClassLetter = char.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Въведете само един символ.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}: Въведете отново.");
                }
            }


            while (true)//ne raboti
            {
                try
                {
                    Console.Write("Дата на раждане: ");
                    student.BirthDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Невалиден формат на датата.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}: Въведете отново.");
                }
            }


            Console.WriteLine();
            Console.WriteLine("-Данни на ученика-");
            Console.WriteLine();
            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Име: {student.Name}");
            Console.WriteLine($"Възраст: {student.Age}");
            Console.WriteLine($"Клас: {student.Grade}");
            Console.WriteLine($"Среден успех: {student.AverageScore:F2}");
            Console.WriteLine($"Такса: {student.Fee:F2} euro.");
            Console.WriteLine($"Стипендия: {(student.HasScholarship ? "Да" : "Не")}");
            Console.WriteLine($"Паралелка: {student.ClassLetter}");
            Console.WriteLine($"Дата на раждане: {student.BirthDate}");
        }
    }
}
