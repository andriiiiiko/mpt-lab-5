using mpt_lab_5.Vehicles.Enums;

namespace mpt_lab_5.Vehicles
{
    public class AllTerrainVehicle : Transport
    {
        private string _terrainType;
        private int _maxPassengers;
        private bool _hasFourWheelDrive;

        public AllTerrainVehicle(string vehicleIdentificationNumber, int manufactureYear, Make make, Color vehicleColor,
            FuelType fuelType, double engineCapacity, int price, string terrainType, int maxPassengers, 
            bool hasFourWheelDrive)
            : base(vehicleIdentificationNumber, manufactureYear, make, vehicleColor, fuelType, engineCapacity, price)
        {
            _terrainType = terrainType;
            _maxPassengers = maxPassengers;
            _hasFourWheelDrive = hasFourWheelDrive;
        }

        public string TerrainType
        {
            get => _terrainType;
            set => _terrainType = value;
        }

        public int MaxPassengers
        {
            get => _maxPassengers;
            set => _maxPassengers = value;
        }

        public bool HasFourWheelDrive
        {
            get => _hasFourWheelDrive;
            set => _hasFourWheelDrive = value;
        }

        public override string ToString()
        {
            return base.ToString() + $", Terrain Type: {TerrainType}, Max Passengers: {MaxPassengers}, " +
                   $"4WD: {HasFourWheelDrive}";
        }
    }
}