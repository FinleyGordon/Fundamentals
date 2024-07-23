namespace Business.Api.Domain;

public class MotorCycle(int id, string make, string model, int year, string style, string? fuelType = null) : Vehicle(id, make, model, year, style)
{
    public string? FuelType { get; set; } = fuelType;

    public override void PerformAction()
    {
        Console.WriteLine("Performing action for a Motorcycle");
    }
}