using System;
using System.Collections.Generic;
using System.Linq;
using CalisthenicsAPI.Models;

namespace CalisthenicsAPI.Data
{
    public class SqlCalisthenicsRepo : ICalisthenicsRepo
    {
        private readonly CalisthenicsContext _context;

        public SqlCalisthenicsRepo(CalisthenicsContext context)
        {
            _context = context;
        }

        public void CreateExercise(Exercise exercise)
        {
            if (exercise == null)
            {
                throw new ArgumentNullException(nameof(exercise));
            }

            _context.Exercises.Add(exercise);
        }

        public void DeleteExercise(Exercise exercise)
        {
            if (exercise == null)
            {
                throw new ArgumentNullException(nameof(exercise));
            }
            
            _context.Exercises.Remove(exercise);
        }

        public IEnumerable<Exercise> GetAllExercises()
        {
            return _context.Exercises.ToList();
        }

        public Exercise GetExerciseById(int id)
        {
            return _context.Exercises.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateExercise(Exercise exercise)
        {
            // Nothing
        }
    }
}