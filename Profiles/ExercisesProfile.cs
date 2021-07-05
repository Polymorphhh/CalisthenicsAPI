using AutoMapper;
using CalisthenicsAPI.Dtos;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Profiles
{
    public class ExercisesProfile : Profile
    {
        public ExercisesProfile()
        {
            CreateMap<Exercise, ExerciseReadDto>();
            CreateMap<ExerciseCreateDto, Exercise>();
            CreateMap<ExerciseUpdateDto, Exercise>();
        }
    }
}