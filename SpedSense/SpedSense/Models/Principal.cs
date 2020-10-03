using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedSense.Models
{
    class Principal
    {
        int idPrincipal { get; set; }
        String name { get; set; }
        String nip { get; set; }
        ICollection<Order> Orders { get; set; }

        void addOrder(Order order)
        {
            Orders.Add(order);

            //callback
            order.principal = this;
        }
    }
}
