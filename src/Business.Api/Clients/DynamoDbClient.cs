// using Business.Api.Domain;
//
// namespace Business.Api.Clients;
//
// public class DynamoDbClient : IDynamoClient
// {
//     private readonly IDynamoClient _dynamoClient;
//
//     public DynamoDbClient(IDynamoClient dynamoClient)
//     {
//         _dynamoClient = dynamoClient;
//     }
//
//     public async Task<List<Vehicle>> GetAllVehicles()
//     {
//         var vehicles = await _dynamoClient.ScanAsync<Vehicle>();
//         return vehicles;
//     }
//     public async Task<Vehicle> GetVehicleById(int year)
//     {
//         var vehicle = await _dynamoClient.LoadAsync<Vehicle>(year);
//         return vehicle;
//     }
//
//     public async Task Add(Vehicle vehicle)
//     {
//         await _dynamoDBContext.SaveAsync(vehicle);
//     }
// }

