using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Mark";
            //string quote = "The man said, \"Hello\", Mark. \n Hello on a new line. \n \t Hello on a new tab.";
            //string filename = @"C:\Users\Mark";

            //bool trueOrfalse = name.Contains("s");
            //trueOrfalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(quote);
            //Console.ReadLine();

       

            //this block includes defining strings to be concatenated
            string str1 = "Hello my name ";
            string str2 = "is ";
            string str3 = "Mark.";

            //this line concatenates 3 strings
            string str4 = str1 + str2 + str3;
            //this line converts the concatenated strings to uppercase
            str4 = str4.ToUpper();

            //this block defines a new string builder, and appends 1 line at a time to create a paragraph.
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is mark.\n");
            sb.Append("I like to code. \n");
            sb.AppendLine("I also like to snowboard.");
            sb.AppendLine("Do you like snow sports?");
            //this block writes the strings to the console
            Console.WriteLine(str4);
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
