using System;
using Training1;
using Training1.Rectangle;
using Training1.Month;
using Training1.Color;
using Training1.Long;
using Training2;

namespace Epam_Trainings_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose training: \n 1.Struct \n 2.Exceptions");
            int choiceTraining = int.Parse(Console.ReadLine());
            switch (choiceTraining)
            {
                case 1:
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
                    Extensions.DisplayEnum();
                    Extensions.DisplaySortedDictionary();
                    // Task 5
                    long maxValueOfLong = (long)LongRange.Max;
                    long minValueOfLong = (long)LongRange.Min;
                    Console.WriteLine($"Max = {maxValueOfLong}");
                    Console.WriteLine($"Min = {minValueOfLong}");
                    break;
                case 2:
                    Console.WriteLine("Choose Task that will be executed: \n 1.StackOverflowException " +
                       "\n 2.IndexOurOfRangeException \n 3.Event Viewer \n 4.Try-catch-catch construction \n 5.DoSomeMath ");
                    int choiceTaskTraining2 = int.Parse(Console.ReadLine());
                    if (choiceTaskTraining2 == 1)
                    {
                        // Training 2 
                        // Task 1
                        try
                        {
                            Exceptions.RecursivePrint(0);
                        }
                        catch (StackOverflowException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    break;
                default:
                    Console.WriteLine("Invalid input value");
                    break;
            }
        }
    }
}
