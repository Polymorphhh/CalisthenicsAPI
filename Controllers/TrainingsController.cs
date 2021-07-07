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

            return Ok(trainingReadDtos);
        }
    }
}