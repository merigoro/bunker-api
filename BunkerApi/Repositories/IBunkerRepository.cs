using BunkerApi.Models;
namespace BunkerApi.Repositories;
public interface IBunkerRepository
{
    public Task<Bunker> CreateBunker(Bunker bunker);
    public Task<Bunker> GetBunker(Guid id);
    public Task<List<Bunker>> GetBunkers();
    public Task<Bunker> UpdateBunker(Guid id, Bunker bunker);
    public Task<Bunker> DeleteBunker(Guid id);
}