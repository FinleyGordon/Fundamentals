using Business.Api.Domain;
using Business.Api.FactoryDesignPattern;

namespace Business.Api.Factories;

public class VehicleFactory : IVehicleFactory
{
    public Vehicle Create(string type)
    {
        //TODO define the logic for creating a vehicle based on the type from the DTO.
        throw new NotImplementedException();
    }
}