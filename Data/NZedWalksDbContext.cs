using Microsoft.EntityFrameworkCore;
using NzedWalks.Model.Domain;

namespace NzedWalks.Data
{

    public class NZedWalksDbContext : DbContext
    {

        public NZedWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Regions> Regions { get; set; }

    }
}