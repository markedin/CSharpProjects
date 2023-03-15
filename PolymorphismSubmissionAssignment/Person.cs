using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    //create a public abstract class called person
    public abstract class Person
    {
        //give class 2 properties, firstName and lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        //create a SayName() method
        public virtual void SayName()
        {
            //write string to console 
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }

    }
}
