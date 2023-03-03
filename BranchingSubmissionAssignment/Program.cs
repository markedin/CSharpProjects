using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. PLease follow the instructions below");

            //This block asks the user for the package weight, converts the entered string to int32, and stores it in myWEight. If too heavy, display error message 
            Console.WriteLine("Please enter the package weight");
            int myWeight = Convert.ToInt32(Console.ReadLine());
            if (myWeight > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
            }

            else
            {
                //This block asks the user for the package width, converts the entered string to int32, and stores it in myWidth
                Console.WriteLine("Please enter the package width:");
                int myWidth = Convert.ToInt32(Console.ReadLine());


                //This blcok asks the user for the package height, converts the entered string to int32, and stores it in myHeight
                Console.WriteLine("Please enter the package height: ");
                int myHeight = Convert.ToInt32(Console.ReadLine());


                //This block asks the user for the package length, converts the entered string to int32, and stores it in myLength
                Console.WriteLine("Please enter the package length:");
                int myLength = Convert.ToInt32(Console.ReadLine());

                //This block checks to see if the total of the measurements is greater than 50, if not, then multiply all the measurements & weight, and divide by 100 to calculate the cost (stored in myPrice)
                if (myWidth + myHeight + myLength <= 50)
                {
                    decimal myPrice = (myHeight * myWidth * myLength * myWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + myPrice + ".00");
                    Console.WriteLine("Thank you!");


                }

                //This block displays an error message if any of the measurements are too big
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }

            
            Console.ReadLine();


        }
    }
}
