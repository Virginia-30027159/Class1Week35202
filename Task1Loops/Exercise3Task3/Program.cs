using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int limit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                if (i % 2 != 0)

                
                    Console.Write($"{i}\t");
               
                else
                
                    Console.Write($"{i}\n");
                
                
                
            }

            Console.ReadLine();
        }
    }
}
