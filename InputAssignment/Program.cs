using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tell user to input a number
            Console.WriteLine("Please enter a number");
            //store number as string
            string ans = Console.ReadLine();
            //create new streamwriter, write ans to file
            using (StreamWriter file = new StreamWriter("C:\\Users\\edinm\\logs\\logs.txt", true))
            {
                file.WriteLine(ans);
            }
            //read back what was written to user
            Console.WriteLine("what you wrote was stored in a logs.txt file, and this is what is in that file");
            Console.WriteLine(File.ReadAllText("C:\\Users\\edinm\\logs\\logs.txt"));
            Console.ReadLine();


        }
    }
}
