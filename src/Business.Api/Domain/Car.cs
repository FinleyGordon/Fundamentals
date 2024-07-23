namespace Business.Api.Domain;

public class Car : Vehicle
{
    public Car(int id, string make, string model, int year, string style, int? numberOfDoors = null) : base(id, make, model, year, style)
    {
        Id = id;
        Make = make;
        Model = model;
        Year = year;
        Style = style;
        NumberOfDoors = numberOfDoors;
    }

    public int? NumberOfDoors { get; set; }

    public override void PerformAction()
    {
        Console.WriteLine("Performing action for a car");
    }
}