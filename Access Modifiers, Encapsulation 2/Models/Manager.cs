using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Encapsulation_2.Models
{
    internal class Manager: Employee
    {
        protected int salary {  get; }
        internal void GetPromotion()
        {
            Employee e = new Employee();
            e.Salary = salary + 100;


        }

    }
}
