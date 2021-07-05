using CalisthenicsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalisthenicsAPI.Data
{
    public class CalisthenicsContext : DbContext
    {
        public CalisthenicsContext(DbContextOptions<CalisthenicsContext> opt) : base(opt)
        {
            
        }

        public DbSet<Exercise> Exercises { get; set; }
    }
}