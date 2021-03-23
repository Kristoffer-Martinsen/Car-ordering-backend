using System.Collections.Generic;
using AutoMapper;
using fleks_backend.Data;
using fleks_backend.Dtos;
using fleks_backend.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace fleks_backend.Controllers
{


  [Route("api/cars")]
  [ApiController]
  public class CarsController : ControllerBase
  {
    private readonly IFleksBackendRepo _repository;
    private readonly IMapper _mapper;

    public CarsController(IFleksBackendRepo repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult <IEnumerable<CarReadDto>> GetAllCars()
    {
      var carItems = _repository.GetAllCars();
      return Ok(_mapper.Map<IEnumerable<CarReadDto>>(carItems));
    } 

    [HttpGet("{id}", Name="GetCarById")]
    public ActionResult <CarReadDto> GetCarById(int id)
    {
      var carItem = _repository.GetCarById(id);

      if( carItem != null )
      {
        return Ok(_mapper.Map<CarReadDto>(carItem));
      }

      return NotFound();
    }
    
    [HttpPost]
    public ActionResult<CarReadDto> CreateCar(CarCreateDto carCreateDto)
    {
      var carModel = _mapper.Map<Car>(carCreateDto);
      _repository.CreateCar(carModel);
      _repository.SaveChanges();

      var carReadDto = _mapper.Map<CarReadDto>(carModel);

      return CreatedAtRoute(nameof(GetCarById), new {Id=carReadDto.Id}, carReadDto);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateCar(int id, CarUpdateDto carUpdateDto)
    {
      var carModelFromRepo = _repository.GetCarById(id);
      if(carModelFromRepo == null)
      {
        return NotFound();
      }
      _mapper.Map(carUpdateDto, carModelFromRepo);

      _repository.UpdateCar(carModelFromRepo);

      _repository.SaveChanges();

      return NoContent();  
    }

    [HttpPatch("{id}")]
    public ActionResult PartialUpdateCar(int id, JsonPatchDocument<CarUpdateDto> patchDocument)
    {
      var carModelFromRepo = _repository.GetCarById(id);
      if(carModelFromRepo == null)
      {
        return NotFound();
      }

      var carToPatch = _mapper.Map<CarUpdateDto>(carModelFromRepo);
      patchDocument.ApplyTo(carToPatch, ModelState);

      if(!TryValidateModel(carToPatch))
      {
        return ValidationProblem(ModelState);
      }

      _mapper.Map(carToPatch, carModelFromRepo);

      _repository.UpdateCar(carModelFromRepo);

      _repository.SaveChanges();

      return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCar(int id)
    {
      var carModelFromRepo = _repository.GetCarById(id);
      if(carModelFromRepo == null)
      {
        return NotFound();
      }

      _repository.DeleteCar(carModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }
  }
}