using System;

namespace Business.Api.Domain;

public abstract class Vehicle(int id, string make, string model, int year, string style)
{
    public int Id { get; protected init; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Style { get; set; }

    public abstract void PerformAction();
}