using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training1.Color
{
    public enum Colors
    {
        Green = 1,
        Red = 2,
        Blue = 3,
        White = 4
    }
    public static class Extensions
    {
        public static IEnumerable<Colors> arrayOfColors = Enum.GetValues(typeof(Colors)).Cast<Colors>().ToArray();
        public static void GetRandomValues ()
        {
            for (int i = 0; i< arrayOfColors.Count(); i++)
            {
                Console.WriteLine(arrayOfColors.ToList()[i]);
            }
        }
    }
}
