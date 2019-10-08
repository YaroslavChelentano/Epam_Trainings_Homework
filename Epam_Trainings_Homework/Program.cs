using System;
using Training1;
using Training1.Rectangle;
using Training1.Month;
using Training1.Color;

namespace Epam_Trainings_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            var Jerry = new Person() { Name = "Jerry", Surname = "Koval", Age = 17 };
            Console.WriteLine("Enter Age of Person: ");
            var ageToComparison = int.Parse(Console.ReadLine());
            Jerry.DisplayAgeOfPersonInOrderToGivenNumber(ageToComparison);
            // Task 2
            Console.WriteLine("Enter Width of Rectangle: ");
            var width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Heigth of Rectangle: ");
            var height = double.Parse(Console.ReadLine());
            var rectangle = new Rectangle(width, height);
            Console.WriteLine($"Perimeter of Rectangle is {rectangle.Perimeter()}");
            // Task 3
            Console.WriteLine("Enter number of Month: ");
            int numberOfMonth = int.Parse(Console.ReadLine());
            if (0 <= numberOfMonth && numberOfMonth <= 12)
            {
                string selectedMonth = Enum.GetName(typeof(Month), numberOfMonth - 1);
                Console.WriteLine($"Selected Month is {selectedMonth} ");
            }
            else
            {
                Console.WriteLine("Invalid value number of Month");
            }
            // Task 4
            Extensions.GetRandomValues();
        }
    }
}
