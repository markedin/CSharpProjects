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

            //create employee object as type IQuittable
            IQuittable emp2 = new Employee();
            //Call the Quit() method from the IQuittable class on emp as emp2
            emp2.Quit(emp);

            Console.ReadLine();
        }
    }
}
