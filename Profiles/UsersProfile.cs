using AutoMapper;
using fleks_backend.Dtos;
using fleks_backend.Models;

namespace fleks_backend.Profiles
{
  public class UsersProfile : Profile
  {
    public UsersProfile()
    {
        // Source -> Target
        CreateMap<User, UserReadDto>(); 
        CreateMap<UserCreateDto, User>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<User, UserUpdateDto>();
    }
  }
}