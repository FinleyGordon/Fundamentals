namespace Business.Api.Domain;

public class Boat(int id, string make, string model, int year, string style, int? numberOfEngines = null) : Vehicle(id, make, model, year, style)
{
    public int? NumberOfEngines { get; set; } = numberOfEngines;

    public override void PerformAction()
    {
        Console.WriteLine("Performing action for a boat");
    }
}