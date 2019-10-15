using System;
using System.Collections.Generic;
using System.Text;

namespace Training3
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
