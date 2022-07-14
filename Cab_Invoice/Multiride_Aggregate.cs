using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice
{
    internal class Multiride_Aggregate
    {
        public Dictionary<string, List<Ride_details>> Repo = new Dictionary<string, List<Ride_details>>();
        public List<Ride_details> list = new List<Ride_details>();
        Invoice generate = new Invoice();
        double fare = 0;


        public void getRideDetails()
        {
            Ride_details ride = new Ride_details();
            list = new List<Ride_details>();
            Console.WriteLine("Which ride you want to take:\n1.Noramal Ride\n2.Premium Ride");
            int rideType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Distance in Km:");
            ride.distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time in min:");
            ride.time = Convert.ToDouble(Console.ReadLine());
            switch (rideType)
            {
                case 1:
                    ride.fare = generate.cal_Fare_forNormalRides(ride.distance, ride.time);
                    break;
                case 2:
                    ride.fare = generate.cal_Fare_forPremiumRides(ride.distance, ride.time);
                    break;
            }
            list.Add(ride);
        }
        public void MultipleFare()
        {
            Console.WriteLine("How many rides you want to take:");
            int noOfRides = Convert.ToInt32(Console.ReadLine());
            while (noOfRides != 0)
            {
                Console.WriteLine("Enter User ID:");
                string userID = Console.ReadLine();
                getRideDetails();
                Repo.Add(userID, list.ToList());

                noOfRides--;
            }
        }
        public void showInvoice()
        {
            Console.WriteLine("Enter user ID to view invoice:");
            string userID = Console.ReadLine();
            List<Ride_details> newList = Repo[userID];
            foreach (var item in newList)
            {
                Console.WriteLine("--------------Invoice-------------\nDistance of Journey : " + item.distance + "Km\nTime taken for Journey : " + item.time + "min\nTotal Fare for the rides : Rs" + item.fare);
            }
        }
    }
}
