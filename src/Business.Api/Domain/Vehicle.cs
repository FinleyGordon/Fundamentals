using System;

namespace Business.Api.Domain;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Style { get; set; }


    public abstract void PerformAction();
}