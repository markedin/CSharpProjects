using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write instructions telling the user to input 2 integers, one at a time, but make
            //the second one optional
            Console.WriteLine("Please input 2 integers.");
            Console.WriteLine("First Integer:");
            //Create variables to store user inputs
            int firstInt = Convert.ToInt32(Console.ReadLine());
            //Tell user to input second variable, or leave it blank
            Console.WriteLine("Input second integer, input not required.");
            //Try block to see if the user inputted a second number, if so, run the method with both
            //params
            try
            {
                int secondInt = Convert.ToInt32(Console.ReadLine());
                int ans = NumberMath.addAndMultiply(firstInt, secondInt);
            }
            //if only 1 int was entered, run method with only "firstInt". 
            catch 
            { //Call method from class1, store in int variable
                int ans = NumberMath.addAndMultiply(firstInt);
                //Tell user what answer is with their inputted numbers
                Console.WriteLine("Your answer is: " + ans);
                Console.ReadLine();
            }
            
            
        }
    }
}
