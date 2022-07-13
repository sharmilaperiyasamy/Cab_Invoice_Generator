Cab_Invoice.Multiride_Aggregate mul = new Cab_Invoice.Multiride_Aggregate();
Console.WriteLine("How many rides you want to take:");
int NumberOfRides = Convert.ToInt32(Console.ReadLine());
while (NumberOfRides != 0)
{
    Console.WriteLine("Enter Ride ID:");
    string id = Console.ReadLine();
    Console.WriteLine("Enter Distance:");
    double dist = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Time:");
    double time = Convert.ToDouble(Console.ReadLine());
    mul.calculateMultipleFare(id, dist, time);
    NumberOfRides--;
}
mul.calculateAggregate();