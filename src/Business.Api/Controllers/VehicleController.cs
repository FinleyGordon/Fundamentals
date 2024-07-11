using Business.Api.Domain;
using Business.Api.DTOs;
using Business.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Business.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly ILogger<VehicleController> _logger;

    public VehicleController(ILogger<VehicleController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public async Task<List<Vehicle>> GetAll()
    {
        //TODO Get all vehicles from the service.
        throw new NotImplementedException();
    }
    
    [HttpGet()]
    public async Task<List<Vehicle>> GetById(int id)
    {
        //TODO Get vehicle from the service.
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult CreateVehicle([FromBody] CreateVehicleRequest request)
    {
        try
        {
            //TODO Call the vehicle service to create a vehicle from the DTO.
            return Ok("Vehicle created successfully.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}