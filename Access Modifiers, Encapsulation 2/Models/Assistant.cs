using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Encapsulation_2.Models
{
    internal class Assistant : Manager
    {
        public bool IsSuccessfull { get; }

        public void GetFeedBack()
        {
            Employee e = new Employee();
            e.IsSuccessfull = true;
            e.GetPromotion();
            
        }
    }
}
