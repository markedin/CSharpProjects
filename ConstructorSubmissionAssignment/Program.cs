using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const string name = "Mark";
            //create a variable using var
            var id = 7;
            //create person object and pass in name and id variables
            Person person = new Person(name, id);



            //write a string to the console writing the persons name and associated Id
            Console.WriteLine(person.Name + person.Id);
            Console.ReadLine();

        }
    }
}
