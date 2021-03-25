using System.Collections.Generic;
using AutoMapper;
using fleks_backend.Data;
using fleks_backend.Dtos;
using fleks_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace fleks_backend.Controllers
{

  [Route("api/users")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly IFleksBackendRepo _repository;
    private readonly IMapper _mapper;

    public UsersController(IFleksBackendRepo repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
/*
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

    [HttpPut("{id}")]
    public ActionResult UpdateUser(int id, UserUpdateDto userUpdateDto)
    {
      var userModelFromRepo = _repository.GetUserById(id);
      if(userModelFromRepo == null)
      {
        return NotFound();
      }
      _mapper.Map(userUpdateDto, userModelFromRepo);
      _repository.UpdateUser(userModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }
*/
    [HttpPatch("{id}")]
    public ActionResult PartialUpdateUser(int id, JsonPatchDocument<UserUpdateDto> patchDocument)
    {
      var userModelFromRepo = _repository.GetUserById(id);
      if(userModelFromRepo == null)
      {
        return NotFound();
      }

      var userToPatch = _mapper.Map<UserUpdateDto>(userModelFromRepo);
      patchDocument.ApplyTo(userToPatch, ModelState);

      _mapper.Map(userToPatch, userModelFromRepo);
      _repository.UpdateUser(userModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteUser(int id)
    {
      var userModelFromRepo = _repository.GetUserById(id);
      if(userModelFromRepo == null)
      {
        return NotFound();
      }

      _repository.DeleteUser(userModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }
  }
}