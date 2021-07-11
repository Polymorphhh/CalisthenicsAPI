using System.Collections.Generic;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Data
{
    public interface ICalisthenicsRepo
    {
        bool SaveChanges();
        
        // Exercise
        IEnumerable<Exercise> GetAllExercises();
        Exercise GetExerciseById(int id);
        void CreateExercise(Exercise exercise);
        void UpdateExercise(Exercise exercise);
        void DeleteExercise(Exercise exercise);

        // SetItems
        void CreateSetItem(SetItem setItem);
        void UpdateSetItem(SetItem setItem);
        void DeleteSetItem(SetItem setItem);

        // Set
        void CreateSet(Set set);
        void UpdateSet(Set set);
        void DeleteSet(Set set);

        // Training
        IEnumerable<Training> GetAllTrainings();
        Training GetTrainingById(int id);
        void CreateTraining(Training training);
        void UpdateTraining(Training training);
        void DeleteTraining(Training training);
    }
}