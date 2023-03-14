using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tell the user that you will be inputting two numbers into the method
            Console.WriteLine("We will be passing 4 and 7 into the method.");
            //Instantiate the class
            PerformMath DoTheMath = new PerformMath();
            //Pass in 4 and 7 into method by name
            DoTheMath.DoMath(integerOne: 4, integerTwo: 7);


            Console.ReadLine();
        }
    }
}
