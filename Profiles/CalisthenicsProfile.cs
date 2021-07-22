using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using CalisthenicsDtos;
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
            CreateMap<SetUpdateDto, Set>()
                .EqualityComparison((su, s) => su.Id == s.Id);

            CreateMap<SetItem, SetItemReadDto>();
            CreateMap<SetItemCreateDto, SetItem>();
            CreateMap<SetItemUpdateDto, SetItem>()
                .EqualityComparison((siu, si) => siu.Id == si.Id)
                .ForMember(si => si.Exercise, opt => opt.Ignore());

            CreateMap<Exercise, ExerciseReadDto>();
            CreateMap<ExerciseCreateDto, Exercise>();
            CreateMap<ExerciseUpdateDto, Exercise>();
        }
    }
}