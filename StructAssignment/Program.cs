using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        //create a struct called number
        public struct Number
        {   
            //give it a property called Amount (of type decimal)
            public decimal Amount { get; set; }
        }


        static void Main(string[] args)
        {
            //create a new Number object, assign it a value of 20.22(m)
            Number num = new Number()
            {
                Amount = 20.22m
            };

            //print the amount of num to console (num.Amount)
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
