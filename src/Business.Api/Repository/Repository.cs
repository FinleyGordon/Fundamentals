using Business.Api.Clients;
using Business.Api.Domain;
using Business.Api.Exceptions;

namespace Business.Api.Repository;

public class Repository : IRepository
{
    private const string jsonFileName = "Vehicles.json"; // Update with the actual JSON file name
    private List<Vehicle>? _collection;
    

    public Repository()
    {
        _collection = new List<Vehicle>();
    }

    public async Task<List<Vehicle>> GetAll()
    {
        if (_collection != null) return _collection;
        return null;
    }

    public async Task<Vehicle?> GetById(int id)
    {
        if (_collection != null) return _collection.FirstOrDefault(v => v.Id == id);
        return null;
    }

    public async Task Add(Vehicle entity)
    {
        if (entity == null)
        {
            throw new VehicleException("Vehicle cannot be null");
        }
        
        _collection.Add(entity);
    }

    public void Update(Vehicle entity)
    {
        if (_collection != null)
        {
            Vehicle? existingEntity = _collection.FirstOrDefault(v => v.Id == entity.Id);
            if (existingEntity != null)
            {
                existingEntity.Make = entity.Make;
                existingEntity.Model = entity.Model;
                existingEntity.Year = entity.Year;
            }
        }
    }

    public void Delete(int id)
    {
        if (_collection != null)
        {
            Vehicle? existingEntity = _collection.FirstOrDefault(v => v.Id == id);
            if (existingEntity != null)
            {
                _collection.Remove(existingEntity);
            }
        }
    }
}

