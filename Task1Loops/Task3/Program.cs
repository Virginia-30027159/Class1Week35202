using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 3*/
            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("------\t------\t----");
            Console.WriteLine("\n>>> For Loop <<<");
            /*for loop*/
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
            }

            Console.WriteLine("\n>>> While Loop <<<");
            int counter = 0;
            while (counter <= 10)
            {
                Console.WriteLine($"{counter}\t{counter*counter}\t{counter*counter*counter}");
                counter++;
            }
            Console.WriteLine("\n>>> Do While Loop <<<");
            int counter2 = 0;
            do
            {
                Console.WriteLine($"{counter2}\t{counter2 * counter2}\t{counter2 * counter2 * counter2}");
                counter2++;
            } while (counter2 <= 10);

                Console.WriteLine("Task 2 complete - press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
