using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    //create a class for employee
    public class Employee
    {
        //give employee class properties: id, FirstName, LastName
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overload bool operator == to compare employee ids
        public static bool operator == (Employee a, Employee b)
        {
            //if statment to compare ids, if ==, return true. If not, return false
            if (a.id == b.id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //have to overload the != operator as well
        public static bool operator != (Employee a, Employee b)
        {
            //if statement to compare ids, if !=, return true, if not, return false
            if (a.id != b.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
