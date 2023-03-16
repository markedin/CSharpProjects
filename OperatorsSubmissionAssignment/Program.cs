using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate an employee obj with all properties filled
            Employee emp1 = new Employee()
            {
                id = 1,
                FirstName = "Mark",
                LastName = "Edin"
            };

            //instantiate another employee obj with all properties filled 
            Employee emp2 = new Employee()
            {
                id = 2,
                FirstName = "Bill",
                LastName = "Smith"
            };

            //write string to console to compare ids
            Console.WriteLine("Are the employee ids the same? Lets see");
            //set up status bool, starting false
            bool status = false;
            //use comparison operators on employee objs
            status = emp1 == emp2;
            //display comparsion results to console
            Console.WriteLine(status);
            //now write string to console to use != operator
            Console.WriteLine("Now we compare if the employee ids are different");
            //set up status2 bool value
            bool status2 = false;
            //use comparison operators on employee objs
            status2 = emp1 != emp2;
            //Display resutls to console
            Console.WriteLine(status2);

            Console.ReadLine();


        }
    }
}
