using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //create a list of 10 employees, filling out their firstName, Id, and lastName
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {firstName = "Mark", Id = 1, lastName = "Edin"},
                new Employee() {firstName = "Bill", Id = 2, lastName = "Smith"},
                new Employee() {firstName = "Joe", Id = 3, lastName = "Jones"},
                new Employee() {firstName = "Kyle", Id = 4, lastName = "Zanzi"},
                new Employee() {firstName = "Joe", Id = 5, lastName = "Jonas"},
                new Employee() {firstName = "Chris", Id = 6, lastName = "Farley"},
                new Employee() {firstName = "Nic", Id = 7, lastName = "Kranz"},
                new Employee() {firstName = "Jake", Id = 8, lastName = "Jarge"},
                new Employee() {firstName = "Josh", Id = 9, lastName = "Stenner"},
                new Employee() {firstName = "Walter", Id = 10, lastName = "Giddens"}
            };

            //Create a foreach loop that will create a new list of all employees with the first name joe
            foreach (Employee employee in employees)
            {
                //create a new list to add the "Joes" to 
                List<Employee> joeList = new List<Employee>();
                //create an if statement to check if the current employee (in the foreach loop) has the first name joe
                if (employee.firstName == "Joe")
                {
                    //if the employee has the firstName == "Joe", add them to the "joeList"
                    joeList.Add(employee); 
                }
            }

            //perform the same action again, but use a lambda expression
            //create a new list to add the joes to and create a lambda expression to add the joes to the list
            List<Employee> joeList2 = employees.Where(x => x.firstName == "Joe").ToList();


            //using a lambda expression, make a list of all employees with an id number greater than 5
            //create a new list, and add employees with an id greater than 5 to that list
            List<Employee> empList = employees.Where(x => x.Id > 5).ToList();

          


            
            
        }
    }
}
