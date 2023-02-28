using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignmentNonGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Console Application Assigment");

            //This block sets mult50 to the string entered into the console, converts it to a double, multiplies it by 50, and returns the result
            Console.WriteLine("Input a number that will be multiplied by 50");
            string mult50 = Console.ReadLine();
            double mult50ans = Convert.ToDouble(mult50);
            mult50ans = mult50ans * 50;
            Console.WriteLine(mult50ans);
            
            //This block sets add25 to the string entered into the console, converts it to a double, adds 25, and returns the result
            Console.WriteLine("Input a number that will be added to 25");
            string add25 = Console.ReadLine();
            double add25ans = Convert.ToDouble(add25);
            add25ans = add25ans + 25;
            Console.WriteLine(add25ans);
           
            //This block sets div12 to the string entered into the console, converts it to a double, divides the input by 12.5, and returns the result
            Console.WriteLine("Input a number that will be divided by 12.5");
            string div12 = Console.ReadLine();
            double div12ans = Convert.ToDouble(div12);
            div12ans = div12ans / 12.5;
            Console.WriteLine(div12ans);
          
            //This block sets comp50 equal to the string entered into the console, converts it to an int, compares it to 50, and returns whether its greater than 50 or not
            Console.WriteLine("Input a number that will compared to see if it's greater than 50");
            string comp50 = Console.ReadLine();
            int comp50ans = Convert.ToInt32(comp50);
            bool ans = comp50ans > 50;
            Console.WriteLine(ans);
         
            //This block sets div7 equal to the string entered into the console, converts it to a double, divides it by 7, and returns the remainder to the console. 
            Console.WriteLine("Input a number that will be divided by 7 and the remainder will be returned");
            string div7 = Console.ReadLine();
            double div7ans = Convert.ToDouble(div7);
            double div7remainder = div7ans % 7;
            Console.WriteLine(div7remainder);
            Console.ReadLine();
           

        }
    }
}
