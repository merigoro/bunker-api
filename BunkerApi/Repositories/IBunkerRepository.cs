using BunkerApi.Models;
namespace BunkerApi.Repositories;
public interface IBunkerRepository
{
    public Task<Bunker> CreateBunker(Guid id);
    public Task<Bunker> GetBunker(Guid id);
    public Task<List<Bunker>> GetBunkers();
    public Task<Bunker> UpdateBunker(Guid id);
    public Task<Bunker> DeleteBunker(Guid id);
}