using AutoMapper;
using CalisthenicsAPI.Dtos;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Profiles
{
    public class TrainingsProfile : Profile
    {
        public TrainingsProfile()
        {
            CreateMap<Training, TrainingReadDto>();
        }
    }
}