using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a symbol to use:");
            string symbol = Console.ReadLine();
            Console.Write("Please enter the height:");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Please enter the Width:");
            int w = int.Parse(Console.ReadLine());

            for (int i = 0; i < h; i++)/*deals with height*/
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTask 3 end...");
            Console.ReadLine();
        }
    }
}
