using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Basic Inheritance*****\n");
            //создалиэкземляри установили максимальную скорость
            Car Jo = new Car(80);
            Jo.Speed = 40;
            Console.WriteLine("Jo is going {0}", Jo.Speed);

            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("Jo is going {0}", myVan.Speed);

            Console.ReadLine();
        }
    }
}
