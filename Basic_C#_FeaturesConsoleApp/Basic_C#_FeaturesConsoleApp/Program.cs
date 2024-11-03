using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C__FeaturesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иван Иванов";
            int age = 25;
            string email = "ivan.ivanov@example.com";
            float programmingScore = 85.5f;
            float mathScore = 90.0f;
            float physicsScore = 88.75f;

            Console.WriteLine($"Ф. И. О.: {fullName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine("Баллы:");
            Console.WriteLine($"  Программирование: {programmingScore}");
            Console.WriteLine($"  Математика: {mathScore}");
            Console.WriteLine($"  Физика: {physicsScore}");
            Console.ReadKey();

            float totalScore = programmingScore + mathScore + physicsScore;
            
            float averageScore = totalScore / 3;

           
            Console.WriteLine($"\nСумма баллов по всем предметам: {totalScore}");
            Console.WriteLine($"Средний балл: {averageScore:F2}");

            Console.ReadKey();
        }

    }
    


}
