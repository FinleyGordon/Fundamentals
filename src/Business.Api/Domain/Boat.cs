namespace Business.Api.Domain;

public class Boat : Vehicle
{
    public int NumberOfEngines { get; set; }

    public override void PerformAction()
    {
        Console.WriteLine("Performing action for a boat");
    }
}