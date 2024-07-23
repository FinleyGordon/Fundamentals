using Business.Api.Domain;
using Business.Api.DTOs;
using Business.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Business.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController(ILogger<VehicleController> logger, IVehicleService vehicleService) : ControllerBase
{
    private readonly ILogger<VehicleController> _logger = logger;

    [HttpGet()]
    public async Task<List<Vehicle>> GetAll()
    {
        //TODO Get all vehicles from the service.
        return await vehicleService.GetAllVehicles();
    }
    
    [HttpGet("{id:int}")]
    public async Task<List<Vehicle>> GetById(int id)
    {
        //TODO Get vehicle from the service.
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateVehicle([FromBody] CreateVehicleRequest request)
    {
        try
        {
            //TODO Call the vehicle service to create a vehicle from the DTO.
            await vehicleService.AddVehicle(request);
            return Ok("Vehicle created successfully.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}