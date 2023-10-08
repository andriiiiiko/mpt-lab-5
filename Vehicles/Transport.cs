namespace mpt_lab_5.Vehicles;

using Enums;

public abstract class Transport : ITransport
{
    private readonly string _vehicleIdentificationNumber;
    private readonly int _manufactureYear;
    private readonly Make _make;
    private Color _vehicleColor;
    private FuelType _fuelType;
    private double _engineCapacity;
    private int _price;

    protected Transport(string vehicleIdentificationNumber, int manufactureYear, Make make, Color vehicleColor, 
        FuelType fuelType, double engineCapacity, int price)
    {
        _vehicleIdentificationNumber = vehicleIdentificationNumber;
        _manufactureYear = manufactureYear;
        _make = make;
        _vehicleColor = vehicleColor;
        _fuelType = fuelType;
        _engineCapacity = engineCapacity;
        _price = price;
    }

    public string VehicleIdentificationNumber => _vehicleIdentificationNumber;

    public int Year => _manufactureYear;

    public Make Make => _make;

    public Color VehicleColor
    {
        get => _vehicleColor;
        set => _vehicleColor = value;
    }

    public FuelType FuelType
    {
        get => _fuelType;
        set => _fuelType = value;
    }

    public double EngineCapacity
    {
        get => _engineCapacity;
        set => _engineCapacity = value;
    }

    public int Price
    {
        get => _price;
        set => _price = value;
    }
}