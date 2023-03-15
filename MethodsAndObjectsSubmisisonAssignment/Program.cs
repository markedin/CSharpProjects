using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmisisonAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create employee object with firstname sample and lastname student
            Employee emp = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            //call superclass method SayName() on employee object
            emp.SayName();
            Console.ReadLine();
        }
    }
}
