using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice
{
    internal class Ride_details
    {
        public double distance;
        public double time;
        public Ride_details(double distance, double time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
