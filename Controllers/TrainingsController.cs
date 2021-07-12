using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CalisthenicsAPI.Data;
using CalisthenicsAPI.Dtos;
using CalisthenicsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalisthenicsAPI.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        private readonly ICalisthenicsRepo _repository;
        private readonly IMapper _mapper;

        public TrainingsController(ICalisthenicsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/trainings
        [HttpGet]
        public ActionResult<IEnumerable<TrainingReadDto>> GetAllTrainings()
        {
            var trainingItems = _repository.GetAllTrainings();
            var trainingReadDtos = _mapper.Map<IEnumerable<Training>, IEnumerable<TrainingReadDto>>(trainingItems);

            return Ok(trainingReadDtos);
        }

        // GET api/trainings/{id}
        [HttpGet("{id}", Name ="GetTrainingById")]
        public ActionResult<TrainingReadDto> GetTrainingById(int id)
        {
            var trainingItem = _repository.GetTrainingById(id);
            if (trainingItem != null)
            {
                var trainingReadDto = _mapper.Map<TrainingReadDto>(trainingItem);
                return Ok(trainingReadDto);
            }

            return NotFound();
        }

        // POST api/trainings
        [HttpPost]
        public ActionResult<TrainingReadDto> CreateTraining(TrainingCreateDto trainingCreateDto)
        {
            var trainingModel = _mapper.Map<Training>(trainingCreateDto);
            _repository.CreateTraining(trainingModel);
            _repository.SaveChanges();

            // Commented line below doesn't return the exercises references (not loaded in training model)
            // so a new query is needed
            // var trainingReadDto = _mapper.Map<TrainingReadDto>(trainingModel);
            var trainingReadDto = _mapper.Map<TrainingReadDto>(_repository.GetTrainingById(trainingModel.Id));

            return CreatedAtRoute(nameof(GetTrainingById), new {Id = trainingReadDto.Id}, trainingReadDto);
        }

        // PUT api/trainings/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTraining(int id, TrainingUpdateDto trainingUpdateDto)
        {
            var trainingModelFromRepo = _repository.GetTrainingById(id);
            if (trainingModelFromRepo == null)
            {
                return NotFound();
            }

            trainingModelFromRepo = _mapper.Map(trainingUpdateDto, trainingModelFromRepo);
            _repository.UpdateTraining(trainingModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        // DELETE api/training/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTraining(int id)
        {
            var trainingModelFromRepo = _repository.GetTrainingById(id);
            if (trainingModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteTraining(trainingModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}