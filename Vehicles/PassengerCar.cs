using mpt_lab_5.Vehicles.Enums;

namespace mpt_lab_5.Vehicles
{
    public class PassengerCar : Transport
    {
        private int _numberOfDoors;
        private bool _hasSunroof;
        private double _fuelEfficiency;
        
        public PassengerCar(string vehicleIdentificationNumber, int manufactureYear, Make make, Color vehicleColor,
            FuelType fuelType, double engineCapacity, int price, int numberOfDoors, bool hasSunroof, 
            double fuelEfficiency)
            : base(vehicleIdentificationNumber, manufactureYear, make, vehicleColor, fuelType, engineCapacity, price)
        {
            _numberOfDoors = numberOfDoors;
            _hasSunroof = hasSunroof;
            _fuelEfficiency = fuelEfficiency;
        }

        public int NumberOfDoors
        {
            get => _numberOfDoors;
            set
            {
                if (value > 1)
                {
                    _numberOfDoors = value;
                }
                else
                {
                    throw new ArgumentException("The car must have at least two doors");
                }
            }
        }

        public bool HasSunroof
        {
            get => _hasSunroof;
            set => _hasSunroof = value;
        }

        public double FuelEfficiency
        {
            get => _fuelEfficiency;
            set
            {
                if (value > 0)
                {
                    _fuelEfficiency = value;
                }
                else
                {
                    throw new ArgumentException("The car cannot increase the amount of fuel in the gas tank " +
                                                "while driving :)");
                }
            }
        }
        
        public override string ToString()
        {
            return base.ToString() + $", Number of Doors: {NumberOfDoors}, Has Sunroof: {HasSunroof}, " +
                   $"Fuel Efficiency (per 100 km): {FuelEfficiency}";
        }
    }
}