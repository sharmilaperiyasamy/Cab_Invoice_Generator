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
        public void calculateMultipleFare()
        {
            Console.WriteLine("Enter Ride ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Distance:");
            double dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time:");
            double time = Convert.ToDouble(Console.ReadLine());
            double fare = generate.cal_Fare(dist, time);
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
