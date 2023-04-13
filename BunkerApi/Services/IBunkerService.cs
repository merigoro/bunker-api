namespace BunkerApi.Services;
using BunkerApi.Models;
public interface IBunkerService
{
    public Task<Bunker> CreateBunker(Guid id);
    public Task<Bunker> GetBunker(Guid id);
    public Task<List<Bunker>> GetBunkers();
    public Task<Bunker> GetClosestBunker(double latitudine, double longitude);
    public Task<Bunker> UpdateBunker(Guid id);
    public Task<Bunker> DeleteBunker(Guid id);
}