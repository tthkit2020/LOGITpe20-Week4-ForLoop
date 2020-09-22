using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink;
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            if (age < 18)
            {
                drink = "milk";
            } else
            {
                drink = "beer";
            }

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{i} bottles of {drink} on the wall, \n {i} bottles of {drink}");
                Console.WriteLine("Take one down, pass it round.");
                if(i > 1)
                {
                    Console.WriteLine($"{i - 1} of {drink} on the wall");
                } else
                {
                    Console.WriteLine($"There are no bottles of {drink}. Go get some.");
                }
                
            }
        }
    }
}
