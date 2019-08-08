using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("Please enter a number:");
            //    total = total +int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Total: {total}");

            /*Task 2 extension*/
            int total = 0;

            do
            {
                Console.Write("Please enter a number:");
                total = total + int.Parse(Console.ReadLine());

                Console.Write("Do you want to add another number(y/n):");
                if (Console.ReadLine().ToLower() == "n")
                    break;
            } while (true);

        }
    }
}
