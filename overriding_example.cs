using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_OOPs
{
    class Employee
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Basic salary calculation");
        }
    }

    class Manager : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary + bonus");
        }
    }

    class Developer : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary + overtime pay");
        }
    }

}
