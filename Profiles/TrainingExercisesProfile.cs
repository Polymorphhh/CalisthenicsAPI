using AutoMapper;
using CalisthenicsAPI.Dtos;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Profiles
{
    public class TrainingExercisesProfile : Profile
    {
        public TrainingExercisesProfile()
        {
            CreateMap<TrainingExercise, TrainingExerciseReadDto>();
        }
    }
}