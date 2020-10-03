using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedSense.Models
{
    class Hauler : Employee
    {
        int idHauler { get; set; }
        ICollection<Driver> drivers { get; set; }

        public Hauler(string name, string surname, float wage, int idHauler) : base(name, surname, wage)
        {
            this.idHauler = idHauler;
        }
        void addDriver(Driver driver)
        {
            drivers.Add(driver);

            //callback
            driver.hauler = this;
        }
    }
}
