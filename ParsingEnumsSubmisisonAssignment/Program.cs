using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmisisonAssignment
{
    internal class Program
    {
        //create an enum for days of the week
        public enum daysOfTheWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        {
            //Ask the user to enter the current day of the week
            Console.WriteLine("Please enter a day of the week (All lowercase letters)");
            //try/catch blocks to write a string if you do not enter a day of the week correctly
            try
            {
                //assign the user input to datatype daysOfTheWeek, and parse it using Enum.Parse() method.
                //if the user input string converts to an enum daysOfTheWeek, no exception is thrown,
                //which means you entered in a day of the week correctly
                daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), Console.ReadLine());
                
            }
            //catch block to write string when exception is thrown
            catch 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();

        
        }

    }
}
