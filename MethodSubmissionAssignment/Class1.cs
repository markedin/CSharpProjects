using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class NumberMath
    {
        //create a method within the NumberMath class that takes in 1 or 2 numbers (optional) to perform
        //a math operation 
        public static int addAndMultiply(int integer1, int integer2 = 1)
        {
            //create a variable to store the answer of the math operation in order to return it
            //to the main program
            int result = Convert.ToInt32(Math.Sqrt(((integer1^2) + (integer2^2))));
            //return the answer
            return result;
        }
    }
}
