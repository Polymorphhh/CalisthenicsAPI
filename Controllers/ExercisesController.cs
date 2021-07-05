using System.Collections.Generic;
using AutoMapper;
using CalisthenicsAPI.Data;
using CalisthenicsAPI.Dtos;
using CalisthenicsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalisthenicsAPI.Controllers
{
    [Route("api/exercises")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly ICalisthenicsRepo _repository;
        private readonly IMapper _mapper;

        public ExercisesController(ICalisthenicsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/exercises
        [HttpGet]
        public ActionResult<IEnumerable<Exercise>> GetAllExercises()
        {
            var exerciseItems = _repository.GetAllExercises();
            var exerciseReadDtos = _mapper.Map<IEnumerable<ExerciseReadDto>>(exerciseItems);

            return Ok(exerciseReadDtos);
        }

        // GET api/exercises/{id}
        [HttpGet("{id}", Name ="GetExerciseById")]
        public ActionResult<ExerciseReadDto> GetExerciseById(int id)
        {
            var exerciseItem = _repository.GetExerciseById(id);
            if (exerciseItem != null)
            {
                var exerciseReadDto = _mapper.Map<ExerciseReadDto>(exerciseItem);
                return Ok(exerciseReadDto);
            }

            return NotFound();
        }

        // POST api/exercises
        [HttpPost]
        public ActionResult<ExerciseReadDto> CreateExercise(ExerciseCreateDto exerciseCreateDto)
        {
            var exerciseModel = _mapper.Map<Exercise>(exerciseCreateDto);
            _repository.CreateExercise(exerciseModel);
            _repository.SaveChanges();

            var exerciseReadDto = _mapper.Map<ExerciseReadDto>(exerciseModel);

            return CreatedAtRoute(nameof(GetExerciseById), new {Id = exerciseReadDto.Id}, exerciseReadDto);
        }
    }
}