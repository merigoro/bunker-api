namespace BunkerApi.Services;
using BunkerApi.Models;
public interface IBunkerService
{
    public Task<Bunker> CreateBunker(Bunker bunker);
    public Task<Bunker> GetBunker(Guid id);
    public Task<List<Bunker>> GetBunkers();
    public Task<Bunker> GetClosestBunker(double latitude, double longitude);
    public Task<Bunker> UpdateBunker(Guid id, Bunker bunker);
    public Task<Bunker> DeleteBunker(Guid id);
}