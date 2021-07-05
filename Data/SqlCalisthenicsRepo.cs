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

        public IEnumerable<Exercise> GetAllExercises()
        {
            return _context.Exercises.ToList();
        }

        public Exercise GetExerciseById(int id)
        {
            return _context.Exercises.FirstOrDefault(p => p.Id == id);
        }
    }
}