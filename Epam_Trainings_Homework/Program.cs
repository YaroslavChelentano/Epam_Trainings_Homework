using System;
using Training1;
using Training1.Rectangle;

namespace Epam_Trainings_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            var Jerry = new Person() { Name = "Jerry", Surname = "Koval", Age = 17 };
            Console.WriteLine("Enter Age of Person: ");
            var n = int.Parse(Console.ReadLine());
            Jerry.DisplayAgeOfPersonInOrderToGivenNumber(n);
            // Task 2
            Console.WriteLine("Enter Width of Rectangle: ");
            var width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Heigth of Rectangle: ");
            var height = double.Parse(Console.ReadLine());
            var rectangle = new Rectangle(width, height);
            Console.WriteLine($"Perimeter of Rectangle is {rectangle.Perimeter()}"); 
            // Task 3
        }
    }
}
