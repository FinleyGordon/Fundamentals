using Business.Api.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Business.Api.Initialization;

public class VehicleConverter : JsonConverter<Vehicle>
{
    public override bool CanWrite => false;

    public override Vehicle ReadJson(JsonReader reader, Type objectType, Vehicle existingValue, bool hasExistingValue,
        JsonSerializer serializer)
    {
        JObject jsonObject = JObject.Load(reader);

        // Retrieve the "type" property value to determine the vehicle type
        string vehicleType = jsonObject["Type"]?.Value<string>();

        if (string.IsNullOrEmpty(vehicleType))
        {
            throw new JsonSerializationException("Invalid or missing vehicle type in JSON data.");
        }

        Vehicle? vehicle = null;
        switch (vehicleType)
        {
            case "Car":
                vehicle = new Car();
                break;
            case "Boat":
                vehicle = new Boat();
                break;
            case "Motorbike":
                vehicle = new MotorCycle();
                break;
            default:
                throw new JsonSerializationException($"Unknown vehicle type: {vehicleType}");
        }

        // Populate the vehicle object from the JSON data
        serializer.Populate(jsonObject.CreateReader(), vehicle);
        return vehicle;
    }

    public override void WriteJson(JsonWriter writer, Vehicle value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}