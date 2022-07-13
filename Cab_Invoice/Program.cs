Cab_Invoice.Multiride_Aggregate mul = new Cab_Invoice.Multiride_Aggregate();
Console.WriteLine("How many rides you want to take:");
int NumberOfRides = Convert.ToInt32(Console.ReadLine());
while (NumberOfRides != 0)
{
    mul.calculateMultipleFare();
    NumberOfRides--;
}
mul.calculateAggregate();