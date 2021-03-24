using System.Collections.Generic;
using fleks_backend.Models;

namespace fleks_backend.Data
{
  public interface IFleksBackendRepo
  {
    bool SaveChanges();

    IEnumerable<Car> GetAllCars();
    Car GetCarById(int id);
    void CreateCar(Car car);
    void UpdateCar(Car car);
    void DeleteCar(Car car);


    IEnumerable<User> GetAllUsers();
    User GetUserById(int id);
    void CreateUser(User user);
    void UpdateUser(User user);
    void DeleteUser(User user);
  }
}