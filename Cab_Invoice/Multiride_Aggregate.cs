using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice
{
    internal class Multiride_Aggregate
    {
        public Dictionary<string, double> ride = new Dictionary<string, double>();
        Invoice generate = new Invoice();
        double fare = 0;
        public void calculateMultipleFare(string id, double distance, double time)
        {
            double fare = generate.cal_Fare(distance, time);
            this.ride.Add(id, fare);
        }
        public void calculateAggregate()
        {
            int count = 0;
            foreach (var value in this.ride.Values)
            {
                fare = fare + value;
                count++;
            }
            double ag = fare / count;
            Console.WriteLine("Aggregate for all rides is : " + ag);
        }
    }
}
