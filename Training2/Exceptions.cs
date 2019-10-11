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
    }
}
