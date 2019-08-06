using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*For Loop Example*/
                /*This application uses a for loop to display the number of loops that have occured*/

                /*This variable is used to set the amount of times the for loop will loop, try changing the number up or down and see what happens*/
                int limit = 10;

                /*Statement 1 - Create or initialise the counter*/
                /*Statement 2 - Set the conditions for how long the counter will run*/
                /*Statement 3 - increment or decrement the counter at the end of each loop*/

                for (/*Statement 1*/int counter = 1; /*Statement 2*/counter <= limit; /*Statement 3*/counter++)
                {
                    Console.WriteLine("Loop " + counter);

                }
            }


            {
                /*While Loop Example*/
                /*This code uses a WHILE loop to check if a user wishes to enter and stay inside of the loop.*/

                /*Ask the user if they want to enter the loop*/
                Console.Write("Would you like to enter the loop (Y / N): ");
                string input = Console.ReadLine().ToLower();

                /*If the user has input y or Y then they enter the loop.*/
                while (input == "y")
                {
                    /*The user will stay inside the loop untill they answer anything other 
                      than y after which the condition will no longer be met and break out.*/
                    Console.WriteLine("You are now inside of the loop.");
                    Console.Write("Would you like to stay inside the loop (Y / N): ");
                    input = Console.ReadLine().ToLower();
                }

                /*The WHILE loops condition is no longer met and the code continues on after the loop*/
                Console.WriteLine("\nYou have now passed the WHILE loop.");
            }


            {
                /*Do While Loop*/
                /*This code uses a DO / WHILE loop to check if a user wishes to stay inside of the loop.*/

                string input = "n";
                /*Remember a do while loop will always run at least once*/
                do
                {
                    /*The user will stay inside the loop until they answer 'n' after
                      which the condition will no longer be met and break out.*/
                    Console.WriteLine("You are now inside of the loop.");
                    Console.Write("Would you like to stay inside the loop (Y / N): ");
                    input = Console.ReadLine().ToLower();
                } while (input != "n");/*while 'input' is not equal to 'n'*/

                /*The DO / WHILE loops condition is no longer met and the code continues on after the loop*/
                Console.WriteLine("\nYou have now passed the DO WHILE loop.");
            }
        }




    }
}