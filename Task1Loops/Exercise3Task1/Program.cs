using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 1; i <= 50; i++)
            {
                Console.Write($"{i} ");
                if (i%10 == 0)
                
                Console.WriteLine();
                
            }
            Console.WriteLine();
        }
    }
}
