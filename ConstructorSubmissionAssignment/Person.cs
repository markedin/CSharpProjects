using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    //create a class called person
    public class Person
    {   
        //give person class properties name and id
        public string Name { get; set; }
        public int Id { get; set; }

        //chain constructor to other person contructor with a default id of 7
        public Person(string name) : this(name, 7) 
        {
        }

        //create person constructor with input arguments name and id
        public Person(string name, int id)
        {
            Name = name;
            Id = id;

        }
    }
}