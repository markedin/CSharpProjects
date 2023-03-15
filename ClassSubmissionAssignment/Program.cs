using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tell user to input an integer or decimal number that will be divided by two
            Console.WriteLine("Please enter an number that will be divided by 2");
            //Instantiate IntOutput class
            IntOutput intOut = new IntOutput();    
            //Create int variable to hold user input
            decimal ans = Convert.ToDecimal(Console.ReadLine());
            //Pass ans into method
            intOut.divideByTwo(ans);
                
                
            
       
        
            

            //tell user about method with output parameter, tell them to enter number
            Console.WriteLine("Please enter in a number that will be changed to 12 " +
                "after calling the alterNumber method.");
            //create variable to hold user input
            int ans2 = Convert.ToInt32(Console.ReadLine());
            //Pass ans2 into alterNumber method
            intOut.alterNumbers(out ans2);
            //Show user new value of ans2
            Console.WriteLine("This is the new value of your input: " + ans2);

            Console.ReadLine();

        }
    }
}
