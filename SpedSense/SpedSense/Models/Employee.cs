using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedSense.Models
{
    abstract class Employee
    {
        String name { get; set; }
        String surname { get; set; }
        float wage { get; set; }

        protected Employee(string name, string surname, float wage)
        {
            this.name = name;
            this.surname = surname;
            this.wage = wage;
        }
    }
}
