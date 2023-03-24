using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print out current date and time to console
            DateTime dateTime = DateTime.Now;
            //write the datetime to console after converting it to a string
            Console.WriteLine(dateTime.ToString());
            //ask the user for a number
            Console.WriteLine("Please enter a number!");
            //store answer in DateTime variable
            int ans = Convert.ToInt32(Console.ReadLine());
            //store new timespan in time, ans plug in ans into the hours 
            TimeSpan time = new TimeSpan(0, ans, 0, 0, 0);
            //create new datetime var timeOut, and add the timespan to the dateTime var created in the beginning of program
            DateTime timeOut = dateTime.Add(time);
            //write string to console 
            Console.WriteLine("You entered {0}, so the time {0} hours from now will be {1}!", ans, timeOut);




            Console.ReadLine();
        }
    }
}
