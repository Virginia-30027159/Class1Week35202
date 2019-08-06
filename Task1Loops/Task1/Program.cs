using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int start = 3;
            int end = 7;

            /*Headings*/
            Console.WriteLine("N\t10*N\t100*N\t1000*N");
            Console.WriteLine("-\t----\t-----\t------\t");
            /*Task 1*/
            Console.WriteLine("\n>>> For Loop <<<");
            /*For Loop*/
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i}\t{i*10}\t{i*100}\t{i*1000}");
            }
            
            /*While Loop*/
            Console.WriteLine("\n>>> While Loop <<<");
            int counter = start;
            while (counter<=end)
            {
                Console.WriteLine($"{counter}\t{10 * counter}\t{100 * counter}\t{1000 * counter}");
                counter++;
            }
            
            /*Do While Loop*/
            Console.WriteLine("\n>>> Do While Loop <<<");
            int counter2 = start;
            do
            {
                Console.WriteLine($"{counter2}\t{counter2 *10}\t{counter2 *100}\t{counter2 *1000}");
                counter2++;
            } while (counter2 <= end);
            Console.WriteLine("Task 1 complete - press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
