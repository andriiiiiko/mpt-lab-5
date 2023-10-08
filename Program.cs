using mpt_lab_5.Vehicles;
using mpt_lab_5.Vehicles.Enums;

namespace mpt_lab_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Transport passengerCar = new PassengerCar("ABC123456", 2023, 
                Make.Toyota, Color.Blue, FuelType.Petrol, 2.0, 25000, 4, true, 
                8.5);

            Console.WriteLine(passengerCar);

        
            Transport truck = new Truck("XYZ789012", 2023, Make.Volvo, Color.Red,
                FuelType.Diesel, 6.0, 50000, 15000, 4, true);

            Console.WriteLine(truck);


            Transport allTerrainVehicle = new AllTerrainVehicle("ATV456789", 2023,
                Make.Ford, Color.Green, FuelType.Petrol, 0.8, 8000, "Off-road",
                2, true);

            Console.WriteLine(allTerrainVehicle);
        }
    }
}