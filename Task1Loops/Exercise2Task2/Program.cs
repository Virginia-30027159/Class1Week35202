using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character/symbol:");
            string char1 = Console.ReadLine();

            Console.Write($"Please enter number of times you would like to disply {char1}:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i <= count; i++)
            {
                Console.Write(char1);
            }



            Console.WriteLine("\nTask 2 end...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
