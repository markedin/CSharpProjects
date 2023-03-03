using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArraySubmissionAssignment
{
class Program
    {
        static void Main()

        {
            //this block line creats an array of 5 strings
            string[] strings = { "Hello", "how", "are", "you", "doing?" };
            //this line tells the user to pick an array index between 0 and 4
            Console.WriteLine("Please select an index of the array between 0 and 4.");
            //This line assigns the input (after converting str to Int32) to indexStr
            int indexStr = Convert.ToInt32(Console.ReadLine());
            //This if statement makes sure that the index chosen exists. If it doesnt, it displays a message 
            if (indexStr < 0 || indexStr > 4)
            {
                Console.WriteLine("You have chosen an index that doesnt exist.");
            }
            else 
            {
                //This line returns the string at strings[indexStr]
                Console.WriteLine(strings[indexStr]);
            }
           
            
            //this line defines a new array of 6 integers
            int[] ints = { 1, 2, 4, 8, 16, 32 };
            //this line tells the user to pick an array index between 0 and 5
            Console.WriteLine("Please select an array index between 0 and 5");
            //This line takes what the user entered and assigns it to indexInt (After converting to Int32)
            int indexInt = Convert.ToInt32(Console.ReadLine());
            //this if statement makes sure the chosen index exists. if it doesnt, it displays a message
            if (indexInt > 5 || indexInt < 0)
            {
                Console.WriteLine("You have chose an index that doesnt exist.");
            }

            else
            {
                Console.WriteLine(ints[indexInt]);
            }

            //this block creates a list of strings, and addes 4 strings to the list
            List<string> stringList = new List<string>();
            stringList.Add("Hey");
            stringList.Add("what's");
            stringList.Add("goin'");
            stringList.Add("on");
            //this line tells the user to pick an array index between 0 and 3
            Console.WriteLine("Please pick an index between 0 and 3");
            //This line assigns the input (after converting to Int32) to listIndex
            int listIndex = Convert.ToInt32(Console.ReadLine());
            //this if statement makes sure the chosen index exists. If it doesnt, it displays a message
            if (listIndex < 0 || listIndex > 3)
            {
                Console.WriteLine("You have chosen an index that doesn't exist.");
            }
            else
            {
                Console.WriteLine(stringList[listIndex]);
            }

            Console.ReadLine();
            


        }
    }
}
