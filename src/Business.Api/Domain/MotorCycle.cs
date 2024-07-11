namespace Business.Api.Domain;

public class MotorCycle : Vehicle
{
    public string FuelType { get; set; }

    public override void PerformAction()
    {
        Console.WriteLine("Performing action for a Motorcycle");
    }
}