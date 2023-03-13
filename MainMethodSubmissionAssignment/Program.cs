using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //define variables that will be used to hold the return value of all 3 methods
            int integerOut1 = 0;
            int integerOut2 = 0;
            int integerOut3 = 0;

            //instantiate class1 and call first method, passing in an int
            integerOut1 = MathOperations.maths(3);
            //Write strings to console showing what decimal number was passed in to method, what the answer was,
            //and what data type the answer was returned as
            Console.WriteLine("Passing in an integer with a value of 3 to the first method.");
            Console.WriteLine("The result is: " + integerOut1 + " with a data type of: " + integerOut1.GetType() + "\n");

            //instantiate class1 and call second method, passing in a decimal
            integerOut2 = MathOperations.maths(1.110439m);
            //Write strings to console showing what decimal number was passed in to method, what the answer was,
            //and what data type the answer was returned as
            Console.WriteLine("Passing in a decimal with a value of 1.110439 to the second method.");
            Console.WriteLine("The result is: " + integerOut2 + " with a data type of: " + integerOut2.GetType() + "\n");

            //instantiate class1 and call first method, passing in a string that equates to an int
            integerOut3 = MathOperations.maths("3");
            //Write strings to console showing what decimal number was passed in to method, what the answer was,
            //and what data type the answer was returned as
            Console.WriteLine("Passing in a string with a value of \"3\" to the third method.");
            Console.WriteLine("The result is: " + integerOut3 + " with a data type of: " + integerOut3.GetType() + "\n");
            Console.ReadLine();
        }
    }
}
