using Business.Api.Domain;

namespace Business.Api.Repository;

public interface IRepository
{
    //TODO Implement 5 interface methods in a repository class and create the following.
    //You will need to be able to
    //get all vehicles,
    //Get a single vehicle by id,
    //add a vehicle,
    //update a vehicle 
    //delete a vehicle by id
    Task<List<Vehicle>> GetAll();
    Task<Vehicle?> GetById(int id);
    Task Add(Vehicle? entity);
    void Update(Vehicle entity);
    void Delete(int id);
}