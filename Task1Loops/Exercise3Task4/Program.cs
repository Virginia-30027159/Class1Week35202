using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Random random = new Random();
            int num = random.Next(10);
            do
            {

                Console.Write("Try and guess my number from 1 to 10: ");
                counter++;
                int guess = int.Parse(Console.ReadLine());
                if (guess == num)
                {
                    break; 
                }
                Console.Clear;
                else if (guess == num)
                    Console.Write("Sorry Try Again: ");
                Console.ReadLine();



            } while (true);

            Console.WriteLine($"You took {counter} times to guess correctly...");
        }
    }
}
