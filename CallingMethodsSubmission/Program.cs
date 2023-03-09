using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user what number they would like to perform math operations on
            Console.WriteLine("What number would you like to do math operations on?");
            //Convert the user entered string to Int32 and store it in integerIn
            int integerIn = Convert.ToInt32(Console.ReadLine());

            //Call each method stores in the class MathOp and assign it to integerOut(1-3)
            int integerOut1 = MathOp.add5(integerIn);
            int integerOut2 = MathOp.multiplyBy3(integerIn);
            int integerOut3 = MathOp.divideBy2(integerIn);

            //Print out strings showing what method was used and the output of that method 
            //using the int that the user entered
            Console.WriteLine(integerIn + " has been passed into the method add5" + 
                " and the method returns " +integerOut1);
            Console.WriteLine(integerIn + " has been passed into the method multiplyBy3" +
                " and the method returns " + integerOut2);
            Console.WriteLine(integerIn + " has been passed into the method divideBy2" +
                " and the method returns " + integerOut3);
            Console.ReadLine();
        }
    }
}
