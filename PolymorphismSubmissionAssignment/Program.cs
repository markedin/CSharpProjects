using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new employee object with firstName = Sample and lastName = Student
            Employee emp = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };

            //Call SayName() method on emp (employee object)
            emp.SayName();

            //create object employee object that inherits from person and IQuittable
            Employee emp2 = new Employee();
            //Call the Quit() method from the IQuittable class on emp2 (emp2 is the employee quitting,
            //and also using this method)
            emp2.Quit(emp2);

            Console.ReadLine();
        }
    }
}
