namespace mpt_lab_5;

public interface ITransport
{
    void Delete();
    void ChangeColor(Color newColor);
    void ModifyEngineSize(double newEngineSize);
    void SwitchFuelType(FuelType newFuelType);
    void ChangePrice(int newPrice);
}