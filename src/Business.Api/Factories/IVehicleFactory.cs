using Business.Api.Domain;

namespace Business.Api.Factories;

public interface IVehicleFactory
{
    public Vehicle Create(string type);
}