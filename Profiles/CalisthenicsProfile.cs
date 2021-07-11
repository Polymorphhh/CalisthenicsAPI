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
            CreateMap<TrainingExercise, TrainingExerciseReadDto>();

            CreateMap<TrainingUpdateDto, Training>()
                .ForMember(t => t.Sets, opt => opt.Ignore())
                .AfterMap(AddOrUpdateSets);
            CreateMap<SetUpdateDto, Set>()
                .ForMember(s => s.TrainingExercises, opt => opt.Ignore())
                .AfterMap(AddOrUpdateTrainingExercises);
            CreateMap<TrainingExerciseUpdateDto, TrainingExercise>();

            CreateMap<TrainingCreateDto, Training>();
            CreateMap<SetCreateDto, Set>();
            CreateMap<TrainingExerciseCreateDto, TrainingExercise>()
            .ForMember(te => te.RefExercise, opt => opt.Ignore());

            CreateMap<Exercise, ExerciseReadDto>();
            CreateMap<ExerciseReadDto, Exercise>();
            CreateMap<ExerciseCreateDto, Exercise>();
            CreateMap<ExerciseUpdateDto, Exercise>();
        }

        private void AddOrUpdateSets(TrainingUpdateDto trainingUpdateDto, Training training, ResolutionContext context)
        {
            foreach (SetUpdateDto setUpdateDto in trainingUpdateDto.Sets)
            {
                if (setUpdateDto.Id == 0)
                {
                    training.Sets.Add(context.Mapper.Map<Set>(setUpdateDto));
                }
                else
                {
                    context.Mapper.Map(setUpdateDto, training.Sets.SingleOrDefault(s => s.Id == setUpdateDto.Id));
                }               
            }
        }

        private void AddOrUpdateTrainingExercises(SetUpdateDto setUpdateDto, Set set, ResolutionContext context)
        {
            foreach (TrainingExerciseUpdateDto trainingExerciseUpdateDto in setUpdateDto.TrainingExercises)
            {
                if (trainingExerciseUpdateDto.Id == 0)
                {
                    set.TrainingExercises.Add(context.Mapper.Map<TrainingExercise>(trainingExerciseUpdateDto));
                }
                else
                {
                    context.Mapper.Map(trainingExerciseUpdateDto, set.TrainingExercises
                        .SingleOrDefault(s => s.Id == trainingExerciseUpdateDto.Id));
                }               
            }
        }
    }
}