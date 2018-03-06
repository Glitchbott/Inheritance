using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //Менаджарам нужно знать кол-во опцинов на акции
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        
    }
}
