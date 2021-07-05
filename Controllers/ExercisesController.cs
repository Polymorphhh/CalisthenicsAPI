using System.Collections.Generic;
using CalisthenicsAPI.Data;
using CalisthenicsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalisthenicsAPI.Controllers
{
    [Route("api/exercises")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly ICalisthenicsRepo _repository;

        public ExercisesController(ICalisthenicsRepo repository)
        {
            _repository = repository;
        }

        // GET api/exercises
        [HttpGet]
        public ActionResult<IEnumerable<Exercise>> GetAllExercises()
        {
            var commandItems = _repository.GetAllExercises();
            return Ok(commandItems);
        }

        // GET api/exercises/{id}
        [HttpGet("{id}")]
        public ActionResult<Exercise> GetExerciseById(int id)
        {
            var commandItem = _repository.GetExerciseById(id);
            return Ok(commandItem);
        }
    }
}