using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training1.Color
{
    [Flags]
    public enum Colors
    {
        Green = 1,
        Red = 2,
        Blue = 3,
        White = 4
    }
    public static class Extensions
    {
        static Random randomNumber = new Random();
        public static IDictionary<Colors, int> AssociatedValue = new Dictionary<Colors, int>
        { { Colors.Green, randomNumber.Next(0,100)}, {Colors.Red, randomNumber.Next(0,100)},
            { Colors.Blue, randomNumber.Next(0,100)}, {Colors.White, randomNumber.Next(0,100)}};
        public static void DisplayEnum()
        {
            foreach (string colorName in Enum.GetNames(typeof(Colors)))
            {
                Console.WriteLine("{0} = {1:D}", colorName,
                                             Enum.Parse(typeof(Colors), colorName));
            }
        }
        public static void DisplaySortedDictionary()
        {
            var items = from pair in AssociatedValue
                        orderby pair.Value ascending
                        select pair;
            foreach (KeyValuePair<Colors, int> keyValue in items)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
}
