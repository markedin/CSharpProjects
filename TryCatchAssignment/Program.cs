using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while 
            try
            {
                //ask user for age
                Console.WriteLine("Please enter your age");
            }
            catch
            {

            }

            
            

            bool ansOkay = false;
            

            //take in user input, convert to int
            int age = Convert.ToInt32(Console.ReadLine());
            //get todays date (yyyy form) and convert to int
            int thisYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int yearBorn = thisYear - age - 1;
            Console.WriteLine("You were born in the year {0}", yearBorn);
            Console.ReadLine();
        }
    }
}
