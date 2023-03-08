using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6PartSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------Assignment Part 1----------------
            //Create a 1 - D array of strings
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
            Console.ReadLine();
            //--------------------------------------------------------

            //------------------ - Assignment Part 2----------------
            //Create some variables to use in the infinite loop
            int x = 0;
            bool TorF = true;

            //Create an infinite while loop
            while (TorF)
            {
                //Write how many times the loop has ran and "TorF" has been true
                Console.WriteLine("The loop has been true " + x + " of iterations");
                //Fixing the loop by iterating x 
                x++;
                //If x > 15, the while condition becomes false, thus ending the loop
                if (x > 15)
                {
                    TorF = false;
                }
            }
            Console.ReadLine();
            //--------------------------------------------------------

            //------------------ - Assignment Part 3----------------

            //Create an array of int's to iterate through
            int[] intArray1 = { 90, 99, 53, 82, 50, 60, 100 };
            //Create a for loop that iterates through intArray until "i < intArray.Length" is false
            for (int i = 0; i < 7; i++)
            {
                //If the "test score" is above 80, the score is printed to the console
                if (intArray1[i] > 80)
                {
                    Console.WriteLine(intArray1[i]);
                }

            }
            //Create an array of int's to iterate through
            int[] intArray2 = { 90, 99, 53, 82, 50, 60, 100 };

            //Create a for loop that uses the "<=" operator to determine whether to continue or not
            for (int i = 0; i <= 6; i++)
            {
                //If the "test score" is above 80, the score is printed to the console
                if (intArray2[i] > 80)
                {
                    Console.WriteLine(intArray2[i]);
                }
            }
            //You would use "i <= 6" in the place of "i < 7" ,if you are not going to use 
            //"array".Length
            Console.ReadLine();
            //--------------------------------------------------------


            // ------------------ - Assignment Part 4----------------
            //Create a list of unique strings
            List<string> strings = new List<string> { "a", "c", "e", "g", "i", "j", "k", "z" };
            //Create a bool value to tell the loop to stop running if match is found
            bool ansFound = false;
            //Tell the user to choose a letter from the alphabet
            Console.WriteLine("Please write a single letter from the english alphabet");
            //Store the letter the user picks inside "ans"
            string ans = Console.ReadLine();
            //Create a for loop that will run until it has iterated through the entire array, OR until the "ansFound" == true
            for (int i = 0; i < strings.Count && ansFound == false; i++)
            {
                if (ans == strings[i])
                {
                    //if the answer has been found, set ansFound to true
                    ansFound = true;
                    //write a string to the console showing the user that their letter was in the array at an index position of ""
                    Console.WriteLine(ans + " is in the array, and its index position is " + i);
                }
                //create an else if statement where a string will be written to the console AFTER it has iterated through the 
                //array AND ansFound == false
                else if (i == strings.Count - 1 && ansFound == false)
                {
                    Console.WriteLine("That letter is not in the array!");
                }
            }


            Console.ReadLine();

            //--------------------------------------------------------


            //-------------------Assignment Part 5----------------
            //Create a list of strings that are letters of the alphabet
            List<string> strings2 = new List<string> { "a", "b", "c", "d", "e", "e", "f", "g" };
            //ask the user to input a letter of the alphabet to search for in the list
            Console.WriteLine("Please input a letter of the english alphabet");
            //create a string to assign the users inputted string
            string ans2 = Console.ReadLine();
            //Create an empty string to store the found indicies
            string ind = "";
            //Create a for loop to iterate through the list and find matching strings
            for (int j = 0; j < strings2.Count; j++)
            {
                if (strings2[j] == ans2)
                {
                    //if a matching string was found, convert the i value to a string and store it in ind
                    ind = ind + " " + Convert.ToString(j);

                }
                //If the loop has ran through the entire list AND the ind string is still empty, write a string
                else if (j == strings2.Count - 1 && ind == "")
                {
                    Console.WriteLine("Sorry! Your letter was not found in the list.");
                }

                else if (j == strings2.Count - 1 && ind != "")
                {
                    Console.WriteLine("The letter you entered is located at index (indicie) " + ind);
                }

            }

            Console.ReadLine();

            // --------------------------------------------------------


            //-------------------Assignment Part 6----------------
            //Create a list of strings (letters)"
            List<string> list2 = new List<string> { "a", "b", "c", "d", "e", "c", "g" };
            //Create different strings to add to the console print out after list is evaluated
            string strUni = " unique";
            string strDup = " a duplicate";
            //empty list to store already iterated strings
            List<string> strings3 = new List<string>();
            //Create a foreach loop to iterate through the list and find which strings are duplicates or unique
            foreach (string str3 in list2)
            {
                //if statement to check if the list containing already iterated strings are present
                if (strings3.Contains(str3))
                {
                    //write that the letter is a duplicate
                    Console.WriteLine(str3 + " - this item is " + strDup);
                }
                //else statement (because there are only 2 cases) to write the string is unique
                else
                {
                    Console.WriteLine(str3 + " - this item is " + strUni);
                }

                //add the current string to the "check" list
                strings3.Add(str3);





            }
            Console.ReadLine();
            //--------------------------------------------------------\



        }














    }


}
        

    


