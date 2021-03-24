using System.Collections.Generic;
using AutoMapper;
using fleks_backend.Data;
using fleks_backend.Dtos;
using fleks_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace fleks_backend.Controllers
{

  [Route("api/users")]
  public class UsersController : ControllerBase
  {
    private readonly IFleksBackendRepo _repository;
    private readonly IMapper _mapper;

    public UsersController(IFleksBackendRepo repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    [HttpGet]
    public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
    {
      var userItems = _repository.GetAllUsers();
      return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItems));
    }

    [HttpGet("{id}", Name="GetUserById")]
    public ActionResult<UserReadDto> GetUserById(int id)
    {
      var userItem = _repository.GetUserById(id);

      if(userItem != null)
      {
        return Ok(_mapper.Map<UserReadDto>(userItem));
      }

      return NotFound();
    }

    [HttpPost]
    public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
    {
      var userModel = _mapper.Map<User>(userCreateDto);
      _repository.CreateUser(userModel);
      _repository.SaveChanges();

      var userReadDto = _mapper.Map<UserReadDto>(userModel);
      return CreatedAtRoute(nameof(GetUserById), new {Id=userReadDto.Id}, userReadDto);
    }
  }
}