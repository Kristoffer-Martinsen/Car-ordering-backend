using AutoMapper;
using fleks_backend.Dtos;
using fleks_backend.Models;

namespace fleks_backend.Profiles
{
  public class CarsProfile : Profile
  {
    public CarsProfile()
    {
        // Source -> Target
        CreateMap<Car, CarReadDto>(); 
        CreateMap<CarCreateDto, Car>();
        CreateMap<CarUpdateDto, Car>();
        CreateMap<Car, CarUpdateDto>();
    }
  }
}