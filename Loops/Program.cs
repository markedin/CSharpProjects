using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess A number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;


            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62! True again.");
                        Console.WriteLine("Guess A number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29! Try again.");
                        Console.WriteLine("Guess A number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 55:
                        Console.WriteLine("You guess 55. Try again");
                        Console.WriteLine("Guess A number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12! thats right");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess A number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            {
                
            }

            
            Console.ReadLine();
        }
    }
}
