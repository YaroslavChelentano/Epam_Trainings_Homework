using System;

namespace Training2
{
    public class Exceptions
    {
        public static void RecursivePrint(int value)
        {
            Console.WriteLine(value);
            RecursivePrint(++value);
        }
        public static void DisplayArray()
        {
            var arrayOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i <= arrayOfNumbers.Length; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
        public static void DoSomeMath(int a, int b)
        {
            if (a < 0)
            {
                throw new ArgumentException("Parameter should be greater than 0", "a");
            }
            if (b > 0)
            {
                throw new ArgumentException("Parameter should be less than 0", "b");
            }
            else
            {
                Console.WriteLine("Values are valid");
            }
        }
    }
}