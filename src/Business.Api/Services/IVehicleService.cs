using Business.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Business.Api.Services;

public interface IVehicleService
{
    public Task<Vehicle?> GetVehiclesById(int id);
    public Task<List<Vehicle>> GetAllVehicles();

    public Task AddVehicle(string type, int year, string make, string model);
}