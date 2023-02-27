using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "";
            string myCourse = "";

            int myPageInt = 0;
            string myPage = "";

            bool myHelp = false;
            string myHelpString = "";

            string myExperiences = "";

            string myFeedback = "";

            byte myHours = 0;
            string myHoursString = "";



            //This block of code writes the opening statements of the program
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            //This block asks for your name, and stores it in myName
            Console.WriteLine("What is your name?");
            myName = Console.ReadLine();

            //This block asks what course youre on, and stores it in myCourse
            Console.WriteLine("What course are you on?");
            myCourse = Console.ReadLine();

            //This block asks what page number, and stores it in myPage, which gets 
            //converted to an Int32, and then is stored as an int in myPageInt
            Console.WriteLine("What page number?");
            myPage = Console.ReadLine();
            myPageInt = Convert.ToInt32(myPage);

            //This block asks if you need help, and stores your response in myHelpString,
            //which is then converted to a boolean value stored in myHelp
            Console.WriteLine("Do you need help with anything? Please " +
                "answer 'true' or 'false'.");
            myHelpString = Console.ReadLine();
            myHelp = Convert.ToBoolean(myHelpString);

            //This block asks if there were any positive experiences, and the stores 
            //the response in myFeedback
            Console.WriteLine("Were there any positive experiences you'd like" +
                " to provide? Please be specific.");
            myFeedback = Console.ReadLine();

            //This block asks how many hours of study you had and stores it in myHoursString
            //, which is then converted from string to Byte and is stored in myHours
            Console.WriteLine("How many hours did you study today?");
            myHoursString = Console.ReadLine();
            myHours = Convert.ToByte(myHoursString);


            //This block writes some text that should appear at the end of the program. 
            Console.WriteLine("Thank you for your answers. An instructor will respond" +
                "to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
