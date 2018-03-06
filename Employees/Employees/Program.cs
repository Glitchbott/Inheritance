using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Inheritance****\n");
            SalePersons Fred = new SalePersons();
            Fred.Name = "Fred";
            Fred.Age = 31;
            Fred.SaleNumber = 50;

            Console.WriteLine("My name is {0}", Fred.Name);
            Console.WriteLine("My age is {0}", Fred.Age);
            Console.WriteLine("I sale {0}", Fred.SaleNumber);

            Console.ReadLine();

        }
    }
}
