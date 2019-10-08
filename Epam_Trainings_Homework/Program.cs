using System;
using Training1;

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
        }
    }
}
