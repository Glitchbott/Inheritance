﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        //Конструкторы

        public Employee() { }
        public Employee(string name, int id, float pay)

            : this(name, 0, id, pay, "") { }


        public Employee(string name, int id, int age, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            empSSN = ssn;

        }
    }
}
