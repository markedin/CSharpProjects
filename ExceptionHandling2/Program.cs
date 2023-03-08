using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        try
        {
            //Create a list of integers
            List<int> list = new List<int> { 1, 3, 5, 6, 7, 10, 45 };
            //Tell the user to input a whole number to divide the list by
            Console.WriteLine("Type a whole number that you will divide all integers in the list by.");
            //Save user input and convert the string to int (in ans)
            int ans = Convert.ToInt32(Console.ReadLine());

            //create a for loop to iterate through the list and divide each number by the user inputted number
            for (int i = 0; i < list.Count; i++)
            {
                //assign the current list[i]/ans int to new variable
                int ans2 = list[i] / ans;
                //print list[i]/ans to console
                Console.WriteLine(ans2);
            }
        }
        //Catch block for inputting a string to the program
        catch (FormatException ex)
        {   //Tell the user that a string was inputted
            Console.WriteLine(ex.Message);
            return;
        }
        //catch block for dividing by zero 
        catch (DivideByZeroException ex)
        {   //tell the user they tried to divide by zero
            Console.WriteLine(ex.Message);
            
        }
        //Show the user that the try/catch blocks have excecuted and display that message in console
        finally
        {
            Console.WriteLine("Program has emerged from try/catch block");

            Console.ReadLine();
        }
        
        


    }   

}

