using BlackCaps.API.Data;
using BlackCaps.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlackCaps.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly BlackCapsDbContext blackCapsDbContext;

        public RegionRepository(BlackCapsDbContext blackCapsDbContext)
        {
            this.blackCapsDbContext = blackCapsDbContext;
        }
              
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await blackCapsDbContext.Regions.ToListAsync(); 
        }
    }
}
