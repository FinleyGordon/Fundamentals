using Business.Api.Domain;
using Business.Api.DTOs;
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
        return await _respository.GetById(id);


    }

    public async Task<List<Vehicle>> GetAllVehicles()
    {
        return await _respository.GetAll();
    }

    public async Task AddVehicle(CreateVehicleRequest request)
    {
        Vehicle vehicle = _vehicleFactory.Create(request);
        await _respository.Add(vehicle);
    }
}