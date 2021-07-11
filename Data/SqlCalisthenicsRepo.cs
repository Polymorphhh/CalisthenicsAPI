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

        public void CreateSet(Set set)
        {
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            _context.Sets.Add(set);
        }

        public void CreateTraining(Training training)
        {
            if (training == null)
            {
                throw new ArgumentNullException(nameof(training));
            }

            _context.Trainings.Add(training);
        }

        public void CreateSetItem(SetItem setItem)
        {
            if (setItem == null)
            {
                throw new ArgumentNullException(nameof(setItem));
            }

            _context.SetItems.Add(setItem);
        }

        public void DeleteExercise(Exercise exercise)
        {
            if (exercise == null)
            {
                throw new ArgumentNullException(nameof(exercise));
            }
            
            _context.Exercises.Remove(exercise);
        }

        public void DeleteSet(Set set)
        {
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }
            
            _context.Sets.Remove(set);
        }

        public void DeleteTraining(Training training)
        {
            if (training == null)
            {
                throw new ArgumentNullException(nameof(training));
            }
            
            _context.Trainings.Remove(training);
        }

        public void DeleteSetItem(SetItem setItem)
        {
            if (setItem == null)
            {
                throw new ArgumentNullException(nameof(setItem));
            }
            
            _context.SetItems.Remove(setItem);
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

        public void UpdateSet(Set set)
        {
            // Nothing
        }

        public void UpdateTraining(Training training)
        {
            // Nothing
        }

        public void UpdateSetItem(SetItem setItem)
        {
            // Nothing
        }
    }
}