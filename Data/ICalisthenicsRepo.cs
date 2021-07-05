using System.Collections.Generic;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Data
{
    public interface ICalisthenicsRepo
    {
        IEnumerable<Exercise> GetAllExercises();
        Exercise GetExerciseById(int id);
    }
}