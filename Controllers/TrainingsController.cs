using System.Collections.Generic;
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
            foreach (Training item in trainingItems)
            {
                System.Console.Out.WriteLine(item.Name);
                System.Console.Out.WriteLine(item.Sets.Count);
                foreach (Set set in item.Sets)
                {
                    System.Console.Out.WriteLine(set.ToString());
                }
            }
                       
            var trainingReadDtos = _mapper.Map<IEnumerable<Training>, IEnumerable<TrainingReadDto>>(trainingItems);
            foreach (TrainingReadDto item in trainingReadDtos)
            {
                System.Console.Out.WriteLine(item.Name);
                System.Console.Out.WriteLine(item.Sets.Count);
                foreach (SetReadDto set in item.Sets)
                {
                    System.Console.Out.WriteLine(set.ToString());
                }
            }
           
            return Ok(trainingReadDtos);
        }
    }
}