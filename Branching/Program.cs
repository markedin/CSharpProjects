using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("it is not exactly room temp");
            //}

            //Console.ReadLine();

            int roomTemperature = 70;

            Console.WriteLine("Hi what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temp where youre at?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature) 
            {
                Console.WriteLine("It is exactly room temp.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temp");
            }
            else if (currentTemperature < roomTemperature)
            {
                Console.WriteLine("It is colder than room temp");
            }
            else
            {
                Console.WriteLine("Uhhhh no way homie");
            }
        }
    }
}
