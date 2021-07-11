using System.Linq;
using AutoMapper;
using CalisthenicsAPI.Dtos;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Profiles
{
    public class CalithenicsProfile : Profile
    {
        public CalithenicsProfile()
        {
            CreateMap<Training, TrainingReadDto>();
            CreateMap<Set, SetReadDto>();
            CreateMap<SetItem, SetItemReadDto>();

            CreateMap<Exercise, ExerciseReadDto>();
            CreateMap<ExerciseCreateDto, Exercise>();
            CreateMap<ExerciseUpdateDto, Exercise>();
        }
    }
}