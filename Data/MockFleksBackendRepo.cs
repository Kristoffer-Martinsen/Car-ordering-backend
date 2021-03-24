using System.Collections.Generic;
using fleks_backend.Models;

namespace fleks_backend.Data
{
  public class MockFleksBackendRepo : IFleksBackendRepo
  {
    public void CreateCar(Car car)
    {
      throw new System.NotImplementedException();
    }

    public void CreateUser(User user)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteCar(Car car)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteUser(User user)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Car> GetAllCars()
    {
      var cars = new List<Car>
      {
        new Car
        {
          Id=0,
          Model="Peugot e-208",
          Year=2020,
          Transmission="Automatic",
          Fuel="Electric 340km",
          Storage=265,
          Price=5399
        },
        new Car
        {
          Id=1,
          Model="Jaguar I-Pace EV320 S Advanced",
          Year=2020,
          Transmission="Automatic",
          Fuel="Electric 470km",
          Storage=505,
          Price=10999
        },
        new Car
        {
          Id=2,
          Model="DS 3 Crossback E-Tense",
          Year=2020,
          Transmission="Automatic",
          Fuel="Electric 320km",
          Storage=350,
          Price=6299
        },
        new Car
        {
          Id=3,
          Model="Peugeot 3008 SUV",
          Year=2019,
          Transmission="Automatic",
          Fuel="Gas",
          Storage=591,
          Price=6299
        }
      };
      return cars;
    }

    public IEnumerable<User> GetAllUsers()
    {
      throw new System.NotImplementedException();
    }

    public Car GetCarById(int id)
    {
      return new Car{
        Id=0,
        Model="Peugot e-208",
        Year=2020,
        Transmission="Automatic",
        Fuel="Electric 340km",
        Storage=265,
        Price=5399
      };
    }

    public User GetUserById(int id)
    {
      throw new System.NotImplementedException();
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateCar(Car car)
    {
      throw new System.NotImplementedException();
    }

    public void UpdateUser(User user)
    {
      throw new System.NotImplementedException();
    }
  }
}