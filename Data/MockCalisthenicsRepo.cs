using System.Collections.Generic;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Data
{
    public class MockCalisthenicsRepo : ICalisthenicsRepo
    {
        public IEnumerable<Exercise> GetAllExercises()
        {
            var exercises = new List<Exercise>
            {
                new Exercise { Id=0, Name="Push-Up", Description=@"Exercise done laying with face, 
                    palms and toes facing down, keeping legs and back straight, extending arms straight to 
                    push body up and back down again.", Hold=false },
                new Exercise { Id=1, Name="Pull-Up", Description=@"Exercise where you grip an overhead bar 
                    and lift your body until your chin is above that bar.", Hold=false },
                new Exercise { Id=2, Name="Push-Up", Description=@"Exercise where you supports 
                    yourself on a dip bar or from a set of rings with your arms straight down and shoulders 
                    over your hands, then lowers your body until your arms are bent to a 90 degree angle at 
                    the elbows, and then lifts your body up, returning to the starting position.", Hold=false }
            };

            return exercises;
        }

        public Exercise GetExerciseById(int id)
        {
            return new Exercise { Id=0, Name="Push-Up", Description=@"Exercise done laying with face, 
                    palms and toes facing down, keeping legs and back straight, extending arms straight to 
                    push body up and back down again.", Hold=false };
        }
    }
}