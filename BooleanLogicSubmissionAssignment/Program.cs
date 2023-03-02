using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This block includes the opening string, asks the user their age, assigns inputted age to userAgeStr, converts string to Int32 and assigns it to userAgeInt
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("What is your age?");
            string userAgeStr = Console.ReadLine();
            int userAgeInt = Convert.ToInt32(userAgeStr);

            //This block asks if the user has had a dui, assigns the string to userDUIStr, converts it to bool and assigns it to userDUIbool
            Console.WriteLine("Have you ever had a DUI?");
            string userDUIStr = Console.ReadLine();
            bool userDUIbool = Convert.ToBoolean(userDUIStr);

            //this block asks the user how many speeding tickets you have, assigns the inputted str to ticketStr, converts it to Int32 and assigns it to ticketInt
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketStr = Console.ReadLine();
            int ticketInt = Convert.ToInt32(ticketStr);

            //string
            Console.WriteLine("Qualified");
            

            //this block contains the logic for insurance approval. If the userAgeInt is above 15, userDUIbool is false, and ticketInt is <= 3, then it writes true to console. If any are false, it writes false. 
            if (userAgeInt > 15 && userDUIbool == false && ticketInt <= 3)
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadLine();
            }

        }
    }
}
