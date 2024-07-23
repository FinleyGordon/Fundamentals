using Business.Api.Domain;
using Business.Api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Business.Api.Services;

public interface IVehicleService
{
    public Task<Vehicle?> GetVehiclesById(int id);
    public Task<List<Vehicle>> GetAllVehicles();

    public Task AddVehicle(CreateVehicleRequest request);
}