using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment2
{
    public class PerformMath
    {
        //Create a class with no return value (void), and pass in two integers
        public void DoMath(int integerOne, int integerTwo)
        {
            //create an integer variable to store answer
            int intOut = 0;
            //Perform math on two passed parameters and store in intOut
            intOut = integerOne + 5 + integerTwo * 2;
            //Display the answer to the console
            Console.WriteLine(intOut);
        }


        
        
            
        
        
        
        
        
    }
}
