using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;//change this to change the times table produced
            Console.WriteLine("7 times table:");
            Console.WriteLine("--------------");
            Console.WriteLine(">>> For Loop <<<");
            /*for loop*/
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i*number}");
            }

            Console.WriteLine("\n>>> While Loop <<<");
            /*While loop*/
            int counter = 1;
            while(counter <= 12)
            {
                Console.WriteLine($"{counter} x {number} = {counter * number}");
                counter++;
            }

            Console.WriteLine("\n>>> Do While Loop <<<");
            /*Do While loop*/
            int counter2 = 1;
            do
            {
                Console.WriteLine($"{counter2} x {number} = {counter2 * number}");
                counter2++;
            } while (counter2 <= 12);



                Console.WriteLine("Task 2 complete - press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
