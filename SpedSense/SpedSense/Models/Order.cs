using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedSense.Models
{
    class Order
    {
        int tonage { get; set; }
        LoadType loadType { get; set; }
        DateTime admissionDate { get; set; }
        DateTime payday { get; set; }
        int paymentDuration { get; set; }
        String loadingLocation { get; set; }
        String destination { get; set; }
        public Driver driver { get; set; }
        public Principal principal{ get; set;}

        public enum LoadType
        {
            COOLED,
            STILL,
            LIQUID
        }
    }
}
