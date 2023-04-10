using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalChallengeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                
                Console.Write("Enter a First Name for the new student: ");
                string inputFirstName = Console.ReadLine();
                Console.Write("Enter a Last Name for the new student: ");
                string inputLastName = Console.ReadLine();
                Console.Write("Enter a GPA for the new student: ");
                decimal inputGPA = Convert.ToDecimal(Console.ReadLine());

                var student = new Student { FirstName = inputFirstName };
                student.LastName = inputLastName;
                student.GPA = inputGPA;
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.Id
                            select s;

                Console.WriteLine("All students in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Id + "\n" + item.FirstName + "\n" + item.LastName + "\n" + item.GPA);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                                            

            }
            

        }

        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal GPA { get; set; }

        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }

    }
}
