using Business.Api.Clients;
using Business.Api.Domain;
using Business.Api.Factories;
using Business.Api.FactoryDesignPattern;
using Business.Api.Initialization;
using Business.Api.Repository;
using Business.Api.Services;
using Newtonsoft.Json;
using Car = Business.Api.FactoryDesignPattern.Car;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.

Configure(builder.Services);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();
LoadVehicleData(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void Configure(IServiceCollection services)
{
    // services.AddSingleton<IDynamoClient, DynamoDbClient>();
    // services.AddHttpClient<GenericHttpClient>(x => x.BaseAddress = new Uri("https://randomuser.me/"));
    //services.AddTransient<ILogger>();
    services.AddSingleton<IRepository, Repository>();
    services.AddTransient<IVehicleService, VehicleService>();
    services.AddSingleton<IVehicleFactory, VehicleFactory>();
}

static void LoadVehicleData(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var vehicleRepository = scope.ServiceProvider.GetRequiredService<IRepository>();
    var jsonFilePath =
        Path.Combine(AppContext.BaseDirectory, "Vehicles.json"); // Update with the correct JSON file path

    if (!File.Exists(jsonFilePath))
    {
        throw new FileNotFoundException("Vehicles JSON file not found.");
    }

    try
    {
        string jsonData = File.ReadAllText(jsonFilePath);

        var settings = new JsonSerializerSettings();
        settings.Converters.Add(new VehicleConverter());

        List<Vehicle?>? vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(jsonData, settings);

        // Add vehicles to the repository
        foreach (var vehicle in vehicles)
        {
            vehicleRepository.Add(vehicle);
            Console.WriteLine(vehicleRepository.GetById(vehicle.Id));
        }
        vehicles.Add(null);
    }
    catch (Exception ex)
    {
        // Handle any exceptions or log the error
        Console.WriteLine($"Error occurred while loading vehicle data: {ex.Message}");
    }
}