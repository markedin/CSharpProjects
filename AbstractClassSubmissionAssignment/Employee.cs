using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    //create a class employee that inherits from person
    public class Employee : Person
    {
        //create an override method to use same logic of say name from parent class
        public override void SayName()
        {   //autofilled base.SayName() but its the same thing as SayName() in person class
            base.SayName();
        }
    }
}
