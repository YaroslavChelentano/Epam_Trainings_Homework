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
    }
}
