using mpt_lab_5.Vehicles.Enums;

namespace mpt_lab_5.Vehicles
{
    public class Truck : Transport
    {
        private double _cargoCapacity;
        private int _numberOfAxles;
        private bool _trailerHitch; 
        
        public Truck(string vehicleIdentificationNumber, int manufactureYear, Make make, Color vehicleColor,
            FuelType fuelType, double engineCapacity, int price, double cargoCapacity, int numberOfAxles,
            bool trailerHitch)
            : base(vehicleIdentificationNumber, manufactureYear, make, vehicleColor, fuelType, engineCapacity, price)
        {
            CargoCapacity = cargoCapacity;
            NumberOfAxles = numberOfAxles;
            TrailerHitch = trailerHitch;
        }

        public double CargoCapacity
        {
            get => _cargoCapacity;
            set
            {
                if (value > 0)
                {
                    _cargoCapacity = value;
                }
                else
                {
                    throw new ArgumentException("The cargo capacity cannot be negative");
                }
            }
        }
        
        public int NumberOfAxles { 
            get => _numberOfAxles;
            set
            {
                if (value > 1)
                {
                    _numberOfAxles = value;
                }
                else
                {
                    throw new ArgumentException("The number of axles should be more than one");
                }
            } 
        }

        public bool TrailerHitch
        {
            get => _trailerHitch;
            set => _trailerHitch = value;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cargo Capacity: {CargoCapacity}, Number of Axles: {NumberOfAxles}, " +
                   $"Trailer Hitch: {TrailerHitch}";
        }
    }
}