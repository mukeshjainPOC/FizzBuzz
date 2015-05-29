using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    static class Extension
    {
        public static void PrintNumber(this int Number)
        {
            bool isfizzbuzz = false;
            if (Number <= 0)
            {
                Console.WriteLine("Invalid Input!!!");
            }
            else
            {
                if (Number % 3 == 0)
                {
                    Console.Write("Fizz");
                    isfizzbuzz = true;
                }
                if (Number % 5 == 0)
                {
                    Console.Write("Buzz");
                    isfizzbuzz = true;
                }
                if (!isfizzbuzz)
                {
                    Console.Write(Number.ToString());
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                i.PrintNumber();
            }
            Console.ReadLine();
        }
    }
}
