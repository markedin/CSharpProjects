using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignmentDoWhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //this block is setting up boolean variables I will use later in the program
            bool isSuitable = true;
            bool myCatsBool = true;
            bool myCare = true;
            do
            {
                
                //this is the beginning of the do loop, which will run as long as isSuitable is true. 
                //It asks if you have dogs, and converts the answer to a boolean value and then sets the opposite equal to isSuitable (weird wording, had to flip it)
                Console.WriteLine("Cat Adoption Screening Application");
                Console.WriteLine("Do you have dogs? Answer 'true/false'");
                bool myDogs = Convert.ToBoolean(Console.ReadLine());
                isSuitable = !myDogs;

                //This block asks how many cats you have, converts the string to int32, and records the number in myCats. if you answer with a number more than 3, isSuitable = myCatsBool = false. 
                Console.WriteLine("How many cats do you have? Answer with a number");
                int myCats = Convert.ToInt32(Console.ReadLine());
                if (myCats > 3)  {
                    myCatsBool = false;
                    isSuitable = myCatsBool;
                }
                else
                {

                }
                
                //This block asks if you are financially able to care for the cat etc, it stores the string and converts it to boolean, and then is set equal to isSuitable. at the end of the application, if isSuitable is 
                //true, a string is printed to the console, if false, a different string is printed
                Console.WriteLine("Are you able to financially care for this cat for the rest of its life? Answer with 'true/false'");
                myCare = Convert.ToBoolean(Console.ReadLine());
                isSuitable = myCare;
                if(isSuitable == true)
                {
                    Console.WriteLine("Congratulations! You can adopt a cat!");
                }
                else
                {
                    Console.WriteLine("Sorry, you cannot adopt a cat.");
                }

            }

            while (isSuitable);
            Console.ReadLine();


        }
    }
}
