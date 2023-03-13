using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    public class MathOperations
    {
        //Create a method that takes in an int, performs a math operation on it, and returns 
        //the answer as an int
        public static int maths(int integerIN)
        {
            //create a variable to return to the main program
            int intOut1 = integerIN + 9;
            //return the answer post math operation to the main program
            return intOut1;
        }

        //Create a method (with the same name) that takes in a decimal, performs a math operation
        //on it, and returns the asnwer as an integer
        public static int maths(decimal integerIN)
        {
            //create a var and a math operation to return to the main program
            int intOut2 = Convert.ToInt32(integerIN * 2);
            //return the answer as an int to the main program
            return intOut2;
        }
        //create a method (with the same name) that will take in a string, convert to an int if possible
        //and will do a math operation on it. then, return as int
        public static int maths(string stringIN) 
        {
            //create a var and try to convert string input to int
            int intOut3 = Convert.ToInt32(stringIN);
            //perform math operation on intOut3
            intOut3 = intOut3 * 3 + 2;
            //return intOut3 as int
            return intOut3;

        }
    }
}
