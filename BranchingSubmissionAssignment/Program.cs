using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. PLease follow the instructions below");

            Console.WriteLine("Please enter the package weight");
            int myWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width:");
            int myWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int myHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int myLength = Convert.ToInt32(Console.ReadLine());

            if (myLength <= 50 && myWidth <= 50 && myHeight <= 50)
            {
                decimal myPrice = (myHeight * myWidth * myLength * myWeight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is : " + "$" + myPrice + ".00");
                Console.WriteLine("Thank you!");
               

            }

            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.ReadLine();


        }
    }
}
