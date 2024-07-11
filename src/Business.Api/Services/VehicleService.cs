using Business.Api.Domain;
using Business.Api.Exceptions;
using Business.Api.Factories;
using Business.Api.FactoryDesignPattern;
using Business.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Business.Api.Services;

public class VehicleService : IVehicleService
{
    private readonly IRepository _respository;
    private readonly IVehicleFactory _vehicleFactory;
    private readonly ILogger<VehicleService> _logger;

    public VehicleService(IRepository repository,
        IVehicleFactory vehicleFactory,
        ILogger<VehicleService> logger)
    {
        _respository = repository;
        _vehicleFactory = vehicleFactory;
        _logger = logger;
    }

    public async Task<Vehicle?> GetVehiclesById(int id)
    {
        //TODO Get a vehicle from the repository
        throw new NotImplementedException();

    }

    public async Task<List<Vehicle>> GetAllVehicles()
    {
        //TODO Get all vehicles using the repository
        throw new NotImplementedException();
    }

    public Task AddVehicle(string type, int year, string make, string model)
    {
        //TODO Add a vehicle using the repository
    }
}