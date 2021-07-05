using System.Collections.Generic;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Data
{
    public interface ICalisthenicsRepo
    {
        bool SaveChanges();
        
        IEnumerable<Exercise> GetAllExercises();
        Exercise GetExerciseById(int id);
        void CreateExercise(Exercise exercise);
        void UpdateExercise(Exercise exercise);
    }
}