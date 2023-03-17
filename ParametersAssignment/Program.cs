using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>()
            {
                things = new List<string>() { "mark", "bill", "ted" }
            };

            Employee<int> employee2 = new Employee<int>()
            {
                things = new List<int>() { 1, 2, 3, 4, 5, 6 }
            };

            foreach (string i in employee.things)
            {
                Console.WriteLine(i);
            }

            foreach (int x in employee2.things)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

        }
    }
}
