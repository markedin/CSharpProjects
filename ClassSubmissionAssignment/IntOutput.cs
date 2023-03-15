using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class IntOutput
    {
        //Create a void method that takes in a number, divides by 2, and outputs to console
        public void divideByTwo(int integerIn)
        {
            //Create an int variable to hold answer to output
            int intOut = integerIn / 2;
            //Output answer to console
            Console.WriteLine(intOut);
        }
        //Overload the divideByTwo method to allow it to take decimals
        public void divideByTwo(decimal integerIn)
        {
            //create a decimal variable to hold the answer to output
            decimal intOut = integerIn / 2;
            //output the answer as an int
            Console.WriteLine(Convert.ToInt32(intOut));
        }

        //Create method with output parameters 
        public void alterNumbers(out int integerIn)
        {
            //create a variable with a default value of 12
            int number = 12;
            //set the integer in equal to the number, so when method is called, 
            // the passed parameter variable will be changed to 12
            integerIn = number;
        }

        

    }
}
