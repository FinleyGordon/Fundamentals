namespace Business.Api.Domain;

public class VehicleError : Exception
{
    public string message;
    
    public VehicleError(string message)
    {
        this.message = message;
    }
}