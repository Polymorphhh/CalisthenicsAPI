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

        // Training
        IEnumerable<Training> GetAllTrainings();
        Training GetTrainingById(int id);
        void CreateTraining(Training training);
        void UpdateTraining(Training training);
        void DeleteTraining(Training training);
    }
}