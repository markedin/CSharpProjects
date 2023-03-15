using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
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
            Console.ReadLine();
        }
    }
}
