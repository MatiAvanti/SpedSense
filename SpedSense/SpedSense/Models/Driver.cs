using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedSense.Models
{
    class Driver : Employee
    {
        Boolean hasADR { get; set; }
        ICollection<Order> Orders { get; set; }
        Hauler hauler { get; set; }

        public Driver(string name, string surname, float wage, bool hasADR) : base(name, surname, wage)
        {
            this.hasADR = hasADR;
        }
        public void addOrder(Order order)
        {
            Orders.Add(order);

            //callback
            order.setDriver(this);
        }
        public void setHauler(Hauler hauler)
        {
            this.hauler = hauler;
        }
    }
}
