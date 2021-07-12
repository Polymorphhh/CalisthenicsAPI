using System;
using System.Collections.Generic;
using System.Linq;
using CalisthenicsAPI.Models;
using Microsoft.EntityFrameworkCore;

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

        public void CreateTraining(Training training)
        {
            if (training == null)
            {
                throw new ArgumentNullException(nameof(training));
            }

            _context.Trainings.Add(training);
        }

        public void DeleteExercise(Exercise exercise)
        {
            if (exercise == null)
            {
                throw new ArgumentNullException(nameof(exercise));
            }
            
            _context.Exercises.Remove(exercise);
        }

        public void DeleteTraining(Training training)
        {
            if (training == null)
            {
                throw new ArgumentNullException(nameof(training));
            }
            
            _context.Trainings.Remove(training);
        }

        public IEnumerable<Exercise> GetAllExercises()
        {
            return _context.Exercises.ToList();
        }

        public IEnumerable<Training> GetAllTrainings()
        {
            return _context.Trainings
                .Include(training => training.Sets)
                .ThenInclude(set => set.SetItems)
                .ThenInclude(setItem => setItem.Exercise)
                .AsSplitQuery()
                .ToList();
        }

        public Exercise GetExerciseById(int id)
        {
            return _context.Exercises.FirstOrDefault(p => p.Id == id);
        }

        public Training GetTrainingById(int id)
        {
            return _context.Trainings
                .Where(p => p.Id == id)
                .OrderBy(p => p.Id)
                .Include(training => training.Sets)
                .ThenInclude(set => set.SetItems)
                .ThenInclude(setItem => setItem.Exercise)
                .AsSplitQuery()
                .FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateExercise(Exercise exercise)
        {
            // Nothing
        }

        public void UpdateTraining(Training training)
        {
            // Nothing
        }
    }
}