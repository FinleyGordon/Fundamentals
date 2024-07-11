namespace Business.Api.Domain;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public override void PerformAction()
    {
        Console.WriteLine("Performing action for a car");
    }
}