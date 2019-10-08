using System;

namespace Training1
{
    public struct Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public void DisplayAgeOfPersonInOrderToGivenNumber(int n)
        {
            if (n > 0) // check if n is valid
            {
                if (Age > n)
                {
                    Console.WriteLine($"{Name} {Surname} older than {n}"); 
                }
                else
                {
                    Console.WriteLine($"{Name} {Surname} younger than {n}");
                }
            }
            else
            {
                Console.WriteLine("Argument n is not valid");
            }
        }

    }
}
