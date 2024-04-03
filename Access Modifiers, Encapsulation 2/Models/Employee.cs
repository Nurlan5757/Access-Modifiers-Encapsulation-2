using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Encapsulation_2.Models
{
    internal class Employee
    {
        


        public string Name { get; set; }
        protected internal bool IsSuccessfull {  get; set; }
        internal int Salary {  get; set; }


       
    }
}
