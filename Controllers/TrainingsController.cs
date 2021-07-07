using System.Collections.Generic;
using AutoMapper;
using CalisthenicsAPI.Data;
using CalisthenicsAPI.Dtos;
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
            var trainingReadDtos = _mapper.Map<IEnumerable<TrainingReadDto>>(trainingItems);

            foreach (TrainingReadDto trainingReadDto in trainingReadDtos)
            {
                // get sets by training id
                // get trainingexercises by setid (for each set)
                //      then put trainingsexercises
                // then put sets in training (for each training)
                
                //trainingReadDto.Sets = _repository.GetSetsByTrainingId();
            }

            return Ok(trainingReadDtos);
        }
    }
}