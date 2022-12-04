using BlackCaps.API.Models.Domain;

namespace BlackCaps.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
