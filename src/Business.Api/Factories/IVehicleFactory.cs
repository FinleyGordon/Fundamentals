using Business.Api.Domain;
using Business.Api.DTOs;

namespace Business.Api.Factories;

public interface IVehicleFactory
{
    public Vehicle Create(CreateVehicleRequest request);
}