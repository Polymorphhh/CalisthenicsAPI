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
        [HttpGet("{id}")]
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
    }
}