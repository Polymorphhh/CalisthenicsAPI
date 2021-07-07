using AutoMapper;
using CalisthenicsAPI.Dtos;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Profiles
{
    public class SetsProfile : Profile
    {
        public SetsProfile()
        {
            CreateMap<Set, SetReadDto>();
        }
    }
}