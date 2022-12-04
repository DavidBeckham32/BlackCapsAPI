using BlackCaps.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlackCaps.API.Data
{
    public class BlackCapsDbContext: DbContext
    {
        public BlackCapsDbContext(DbContextOptions<BlackCapsDbContext> options): base(options)
        {

        }
        //Below line created Regions Table in database

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }


    }
}
