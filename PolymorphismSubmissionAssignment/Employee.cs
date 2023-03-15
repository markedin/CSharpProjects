using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    //create a class employee that inherits from person AND interface IQuittable
    public class Employee : Person, IQuittable
    {
        //create an override method to use same logic of say name from parent class
        public override void SayName()
        {   //autofilled base.SayName() but its the same thing as SayName() in person class
            base.SayName();
        }

        //implement IQuit() from IQuittable
        public void Quit(Employee employee)
        {
            //write string to console
            Console.WriteLine("I am done working here! I can't take it any longer! I QUIT");
        }

    }
    
}
