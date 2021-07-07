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

        public void CreateTrainingExercise(TrainingExercise trainingExercise)
        {
            if (trainingExercise == null)
            {
                throw new ArgumentNullException(nameof(trainingExercise));
            }

            _context.TrainingExercises.Add(trainingExercise);
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

        public void DeleteTrainingExercise(TrainingExercise trainingExercise)
        {
            if (trainingExercise == null)
            {
                throw new ArgumentNullException(nameof(trainingExercise));
            }
            
            _context.TrainingExercises.Remove(trainingExercise);
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

        public void UpdateSet(Set set)
        {
            // Nothing
        }

        public void UpdateTraining(Training training)
        {
            // Nothing
        }

        public void UpdateTrainingExercise(TrainingExercise trainingExercise)
        {
            // Nothing
        }
    }
}