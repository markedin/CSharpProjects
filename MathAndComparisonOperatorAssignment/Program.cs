using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The following blocks are initializing variables in a way that makes sense to me and the problem
            double d1HR = 0;
            int d1HW = 0;
            int d1AS = 0;

            double d2HR = 0;
            int d2HW = 0;
            int d2AS = 0;

            
            Console.WriteLine("Anonymous Income Comparison Program");

            //The following block asks Person 1 their hourly rate, and stores it as a double in d1HR
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string d1HRstr = Console.ReadLine();
            d1HR = Convert.ToDouble(d1HRstr);

            //The Following block asks Person 1 how many hours a week they work, and stores it as int32 in d1HW
            Console.WriteLine("Hours Worked Per Week?");
            string d1HWstr = Console.ReadLine();
            d1HW = Convert.ToInt32(d1HWstr);

            //This line calculates annual salary that is used later
            d1AS = (int)(52 * (d1HW * d1HR));


            //This line asks Person 2 their hourly rate and stores it as a double in d2HR
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string d2HRstr = Console.ReadLine();
            d2HR = Convert.ToDouble(d2HRstr);

            //This block asks Person 2 how many hours a week they work, and stores it as an int32 in d2HW
            Console.WriteLine("Hours Worked Per Week?");
            string d2HWstr = Console.ReadLine();
            d2HW = Convert.ToInt32(d2HWstr);
            //This line calculates person 2's annual salary that is used later
            d2AS = (int)(52 * (d2HW * d2HR));

            //This block writes the annual salary of person 1 and 2 in the console
            Console.WriteLine("Annual Salary of Person 1: ");
            Console.WriteLine(d1AS);
            Console.WriteLine("Annual Salary of Person 2: ");
            Console.WriteLine(d2AS);

            //This line compares the annual salary of p1 and p2, and stores the bool result in salComp
            bool salComp = d1AS > d2AS;
            //This block writes a string followed by the comparison boolean value
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salComp);
            Console.ReadLine();




        }
    }
}
