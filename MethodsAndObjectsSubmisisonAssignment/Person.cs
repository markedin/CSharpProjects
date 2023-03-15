using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmisisonAssignment
{
    //create a class called person
    public class Person
    {   
        //Give class firstname and lastname properties
        public string FirstName {get; set;}
        public string LastName {get; set;}

        //create a void method named SayName()
        public void SayName()
        {   

            //Write string to console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
