namespace Business.Api.DTOs;

public record CreateVehicleRequest
{
    public required string Type { get; set; }
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Style { get; set; }
}