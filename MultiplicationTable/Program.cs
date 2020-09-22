using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for a number
             and displays the multiplication table for
            the given number, from 1 to 10*/
            Console.WriteLine("enter a number: ");
            int userNumber = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNumber} X {i} = {userNumber*i}");
            }

            for(int i = 10; i >= 1; i --)
            {
                Console.WriteLine($"{userNumber} X {i} = {userNumber * i}");
            }
        }
    }
}
