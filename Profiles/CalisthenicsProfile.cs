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
            CreateMap<TrainingCreateDto, Training>();
            CreateMap<TrainingUpdateDto, Training>();

            CreateMap<Set, SetReadDto>();
            CreateMap<SetCreateDto, Set>();
            CreateMap<SetUpdateDto, Set>();

            CreateMap<SetItem, SetItemReadDto>();
            CreateMap<SetItemCreateDto, SetItem>();
            CreateMap<SetItemUpdateDto, SetItem>();

            CreateMap<Exercise, ExerciseReadDto>();
            CreateMap<ExerciseCreateDto, Exercise>();
            CreateMap<ExerciseUpdateDto, Exercise>();
        }
    }
}