using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 32, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("passing test score: " + testScores[i]);
        //    }  
        //}
        //Console.ReadLine();


        //}

        //string[] names = { "Mark", "amanda", "bill", "Adam" };

        // for (int j = 0; j < names.Length; j++) 
        //    {
        //        if (names[j] )
        //    }


        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(92);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach(int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine(score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "jesse", "adam", "erik", "mark" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}

        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();

        //Create a 1-D array of strings
        string[] strArray = { "Mark", "Billy", "Paul", "Clyde" };

        //Ask user to input a string and assign string to strAdd
        Console.WriteLine("Please input some text to append to the end of each string in the array");
        string strAdd = Console.ReadLine();

        //Create a loop to iterate through strArray, concatenating strArray and strAdd
        for (int i = 0; i < strArray.Length; i++)
        {
            strArray[i] = strArray[i] + strAdd; 
        }

        //Create a loop to iterate through strArray and print out strArray
        for (int j = 0; j < strArray.Length; j++)
        {
            Console.WriteLine(strArray[j]);
        }


        for (int i = 0;i < strArray.Length; i++)
        {
            strArray[i + 1] = (strArray[i-1]) + strArray[i]);
            Console.WriteLine(strArray[i]);
        }


        Console.ReadLine(); 


    }
}

