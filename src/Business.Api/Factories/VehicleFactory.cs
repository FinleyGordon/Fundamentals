using System.Globalization;
using Business.Api.Domain;
using Business.Api.DTOs;
using Business.Api.FactoryDesignPattern;

namespace Business.Api.Factories;

public class VehicleFactory : IVehicleFactory
{
    public Vehicle Create(CreateVehicleRequest request)
    {
        return request.Type.ToLower(CultureInfo.InvariantCulture) switch
        {
            "car" => new Car(request.Id, request.Make, request.Model, request.Year, request.Style),
            "motorcycle" => new MotorCycle(request.Id, request.Make, request.Model, request.Year, request.Style),
            "boat" => new Boat(request.Id, request.Make, request.Model, request.Year, request.Style),
            _ => throw new Exception("Invalid vehicle type")
        };
    }
}