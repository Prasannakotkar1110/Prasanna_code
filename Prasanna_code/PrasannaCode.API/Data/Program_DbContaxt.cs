using Microsoft.EntityFrameworkCore;
using PrasannaCode.API.model.Domain;

namespace PrasannaCode.API.Data
{
    public class Program_DbContaxt : DbContext
    {
        public Program_DbContaxt(DbContextOptions<Program_DbContaxt> options) : base(options) 
        {
            
        }

        public DbSet<Region>? Regions { get; set; }

        public DbSet<Walk>? Walks { get; set; }

        public DbSet<WalkDifficulty>? WalkDifficulty { get; set; }

    }
}
