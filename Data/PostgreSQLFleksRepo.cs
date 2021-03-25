using System;
using System.Collections.Generic;
using System.Linq;
using fleks_backend.Models;

namespace fleks_backend.Data
{
  public class PostgreSQLFleksRepo : IFleksBackendRepo
  {
    private readonly FleksBackendContext _context;

    public PostgreSQLFleksRepo(FleksBackendContext context)
    {
        _context = context;
    }

    public void CreateCar(Car car)
    {
      if(car == null) 
      {
        throw new ArgumentNullException(nameof(car));
      }

      _context.Cars.Add(car);
    }

    public void CreateUser(User user)
    {
      if(user == null)
      {
        throw new ArgumentNullException(nameof(user));
      }

      _context.Users.Add(user);
    }

    public void DeleteCar(Car car)
    {
      if(car == null) 
      {
        throw new ArgumentNullException(nameof(car));
      }

      _context.Cars.Remove(car);
    }

    public void DeleteUser(User user)
    {
      if(user == null)
      {
        throw new ArgumentNullException(nameof(user));
      }

      _context.Users.Remove(user);
    }

    public IEnumerable<Car> GetAllCars()
    {
      return _context.Cars.ToList();
    }

    public IEnumerable<User> GetAllUsers()
    {
      return _context.Users.ToList();
    }

    public Car GetCarById(int id)
    {
      return _context.Cars.FirstOrDefault(p => p.Id == id);
    }

    public User GetUserById(int id)
    {
      return _context.Users.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0 );
    }

    public void UpdateCar(Car car)
    {
      // Nothing
    }

    public void UpdateUser(User user)
    {
      // Nothing
    }
  }
}