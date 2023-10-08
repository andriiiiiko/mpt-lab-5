using mpt_lab_5.Vehicles.Enums;

namespace mpt_lab_5.Vehicles
{
    public interface ITransport
    {
        string VehicleIdentificationNumber { get; }
        int Year { get; }
        Make Make { get; }
        Color VehicleColor { get; set; }
        FuelType FuelType { get; set; }
        double EngineCapacity { get; set; }
        int Price { get; set; }
    }
}